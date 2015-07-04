using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace sct.cm.util
{
    public class EncryptHelper
    {
        #region 哈希算法

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="plaintext">明文</param>
        /// <returns></returns>
        public static string Md5(string plaintext)
        {
            return ComputeHash(plaintext, FormsAuthPasswordFormat.MD5, Encoding.Default);
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="plaintext">明文</param>
        /// <param name="encode">编码</param>
        /// <returns></returns>
        public static string Md5(string plaintext, Encoding encode)
        {
            return ComputeHash(plaintext, FormsAuthPasswordFormat.MD5, encode);
        }


        /// <summary>
        /// SHA1加密
        /// </summary>
        /// <param name="plaintext">明文</param>
        /// <returns></returns>
        public static string Sha1(string plaintext)
        {
            return ComputeHash(plaintext, FormsAuthPasswordFormat.SHA1, Encoding.Default);
        }

        /// <summary>
        /// SHA1加密
        /// </summary>
        /// <param name="plaintext">明文</param>
        /// <param name="encode">编码</param>
        /// <returns></returns>
        public static string Sha1(string plaintext, Encoding encode)
        {
            return ComputeHash(plaintext, FormsAuthPasswordFormat.SHA1, encode);
        }

        ///<summary>
        /// 哈希算法加密
        ///</summary>
        ///<param name="plaintext">明文</param>
        ///<param name="format">哈希方式：SHA1、MD5</param>
        ///<param name="encode">编码</param>
        ///<returns></returns>
        public static string ComputeHash(string plaintext, FormsAuthPasswordFormat format, Encoding encode)
        {

            if (format == FormsAuthPasswordFormat.MD5)
            {
                byte[] result = encode.GetBytes(plaintext);
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] output = md5.ComputeHash(result);
                return BitConverter.ToString(output).Replace("-", "");
            }
            if (format == FormsAuthPasswordFormat.SHA1)
            {
                byte[] result = encode.GetBytes(plaintext);
                SHA1 sha1 = new SHA1CryptoServiceProvider();
                byte[] output = sha1.ComputeHash(result);
                return BitConverter.ToString(output).Replace("-", "");
            }
            return plaintext;
        }

        #endregion 哈希算法

        #region 对称加解密

        /// <summary>
        /// DES加密
        /// </summary>
        /// <param name="plaintext">明文</param>
        /// <param name="key">秘钥</param>
        /// <returns></returns>
        public static string DESEncrypt(string plaintext, string key)
        {
            byte[] data = Encoding.UTF8.GetBytes(plaintext);
            using (var des = new DESCryptoServiceProvider())
            {
                des.Key = Encoding.ASCII.GetBytes(key);
                des.IV = Encoding.ASCII.GetBytes(key);
                ICryptoTransform desencrypt = des.CreateEncryptor();
                byte[] result = desencrypt.TransformFinalBlock(data, 0, data.Length);
                return BitConverter.ToString(result);
            }
        }

        /// <summary>
        /// DES解密
        /// </summary>
        /// <param name="ciphertext">密文</param>
        /// <param name="key">秘钥</param>
        /// <returns></returns>
        public static string DESDecrypt(string ciphertext, string key)
        {
            string[] sInput = ciphertext.Split("-".ToCharArray());
            var data = new byte[sInput.Length];
            for (int i = 0; i < sInput.Length; i++)
            {
                data[i] = byte.Parse(sInput[i], NumberStyles.HexNumber);
            }
            using (var des = new DESCryptoServiceProvider())
            {
                des.Key = Encoding.ASCII.GetBytes(key);
                des.IV = Encoding.ASCII.GetBytes(key);
                ICryptoTransform desencrypt = des.CreateDecryptor();
                byte[] result = desencrypt.TransformFinalBlock(data, 0, data.Length);
                return Encoding.UTF8.GetString(result);
            }
        }

        /// <summary>
        /// 3DES加密
        /// </summary>
        /// <param name="plaintext">明文</param>
        /// <param name="key">密钥</param>
        /// <returns></returns>
        public static string DES3Encrypt(string plaintext, string key)
        {
            var DES = new TripleDESCryptoServiceProvider();
            var hashMD5 = new MD5CryptoServiceProvider();
            DES.Key = hashMD5.ComputeHash(Encoding.Default.GetBytes(key));
            DES.Mode = CipherMode.ECB;
            ICryptoTransform DESEncrypt = DES.CreateEncryptor();
            byte[] Buffer = Encoding.Default.GetBytes(plaintext);
            return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
        }

        /// <summary>
        /// 3DES解密
        /// </summary>
        /// <param name="ciphertext">密文</param>
        /// <param name="key">密钥</param>
        /// <returns></returns>
        public static string DES3Decrypt(string ciphertext, string key)
        {
            var DES = new TripleDESCryptoServiceProvider();
            var hashMD5 = new MD5CryptoServiceProvider();
            DES.Key = hashMD5.ComputeHash(Encoding.Default.GetBytes(key));
            DES.Mode = CipherMode.ECB;
            ICryptoTransform DESDecrypt = DES.CreateDecryptor();

            byte[] Buffer = Convert.FromBase64String(ciphertext);
            return Encoding.Default.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
        }

        //AES默认密钥向量
        private static readonly byte[] AES_IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF, 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="plaintext">明文</param>
        /// <param name="key">密钥</param>
        /// <returns></returns>
        public static string AESEncrypt(string plaintext, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key.Substring(0, 32));
            using (var aesAlg = new AesCryptoServiceProvider())
            {
                aesAlg.Key = keyBytes;
                aesAlg.IV = AES_IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plaintext);
                        }
                        byte[] bytes = msEncrypt.ToArray();
                        //return Convert.ToBase64String(bytes);//此方法不可用
                        return BitConverter.ToString(bytes);
                    }
                }
            }
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="ciphertext">密文</param>
        /// <param name="key">密钥</param>
        /// <returns></returns>
        public static string AESDecrypt(string ciphertext, string key)
        {
            //byte[] inputBytes = Convert.FromBase64String(input); //Encoding.UTF8.GetBytes(input);
            string[] sInput = ciphertext.Split("-".ToCharArray());
            var inputBytes = new byte[sInput.Length];
            for (int i = 0; i < sInput.Length; i++)
            {
                inputBytes[i] = byte.Parse(sInput[i], NumberStyles.HexNumber);
            }
            byte[] keyBytes = Encoding.UTF8.GetBytes(key.Substring(0, 32));
            using (var aesAlg = new AesCryptoServiceProvider())
            {
                aesAlg.Key = keyBytes;
                aesAlg.IV = AES_IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (var msEncrypt = new MemoryStream(inputBytes))
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srEncrypt = new StreamReader(csEncrypt))
                        {
                            return srEncrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        #endregion

        #region 非对称加解密

        /// <summary>
        /// RSA加密
        /// </summary>
        /// <param name="plaintext">明文</param>
        /// <param name="publicKey">公钥</param>
        /// <returns></returns>
        public static string RSAEncrypt(string plaintext, string publicKey)
        {
            var ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes(plaintext);
            using (var RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(publicKey);
                byte[] encryptedData = RSA.Encrypt(dataToEncrypt, false);
                return Convert.ToBase64String(encryptedData);
            }
        }

        /// <summary>
        /// RSA解密
        /// </summary>
        /// <param name="ciphertext">密文</param>
        /// <param name="privateKey">私钥</param>
        /// <returns></returns>
        public static string RSADecrypt(string ciphertext, string privateKey)
        {
            var byteConverter = new UnicodeEncoding();
            using (var RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(privateKey);
                byte[] encryptedData = Convert.FromBase64String(ciphertext);
                byte[] decryptedData = RSA.Decrypt(encryptedData, false);
                return byteConverter.GetString(decryptedData);
            }
        }

        #endregion

    }
}
