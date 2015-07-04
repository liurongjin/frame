using sct.cm.util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc; 

namespace sct.bll.util
{
    public class UploadHandlerController : Controller
    {
        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="Filedata">上传文件</param>
        /// <returns>返回jsondata格式"操作结果:bool,图片资源路径</returns>
        public ActionResult UploadImage(HttpPostedFileBase Filedata)
        {
            bool bResult = false;
            string rdata = "";
            UploadConfig UploadConfig = new UploadConfig()
            {
                AllowExtensions = Config.GetStringList("imageAllowFiles"),
                PathFormat = Config.GetString("imagePathFormat"),
                SizeLimit = Config.GetInt("imageMaxSize"),
                UploadFieldName = Config.GetString("imageFieldName")
            };

            byte[] uploadFileBytes = null;
            string uploadFileName = null;

            if (Filedata == null || string.IsNullOrEmpty(Filedata.FileName) || Filedata.ContentLength == 0)
            {
                rdata = "没有要上传的文件";
            }
            else
            {
                //if (UploadConfig.Base64)
                //{
                //    uploadFileName = UploadConfig.Base64Filename;
                //    //uploadFileBytes = Convert.FromBase64String(Request[UploadConfig.UploadFieldName]);
                //    uploadFileBytes = Convert.FromBase64String(Filedata.FileName);
                //}
                //else
                //{

                uploadFileName = Filedata.FileName;
                if (!CheckFileType(UploadConfig, uploadFileName))
                {
                    rdata = "不允许的文件格式";
                }
                if (!CheckFileSize(UploadConfig, Filedata.ContentLength))
                {
                    rdata = "文件大小超出服务器限制";
                }

                uploadFileBytes = new byte[Filedata.ContentLength];
                try
                {
                    Filedata.InputStream.Read(uploadFileBytes, 0, Filedata.ContentLength);
                }
                catch (Exception)
                {
                    rdata = "网络错误";
                }
                //}

                var savePath = PathFormatter.Format(uploadFileName, UploadConfig.PathFormat);
                var localPath = System.Web.HttpContext.Current.Server.MapPath(savePath);
                try
                {
                    if (!Directory.Exists(Path.GetDirectoryName(localPath)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(localPath));
                    }
                    System.IO.File.WriteAllBytes(localPath, uploadFileBytes);
                    rdata = savePath;
                    bResult = true;
                }
                catch (Exception e)
                {
                    rdata = "文件访问出错，请检查写入权限";
                }


            }


            return Json(new JsonResultHelper(bResult, rdata));

        }

        /// <summary>
        /// 上传视频
        /// </summary>
        /// <param name="Filedata">上传文件</param>
        /// <returns>返回jsondata格式"操作结果:bool,视频资源路径</returns>
        public ActionResult UploadVideo(HttpPostedFileBase Filedata)
        {
            bool bResult = false;
            string rdata = "";
            UploadConfig UploadConfig = new UploadConfig()
            {
                AllowExtensions = Config.GetStringList("videoAllowFiles"),
                PathFormat = Config.GetString("videoPathFormat"),
                SizeLimit = Config.GetInt("videoMaxSize"),
                UploadFieldName = Config.GetString("videoFieldName")
            };

            byte[] uploadFileBytes = null;
            string uploadFileName = null;

            if (Filedata == null || string.IsNullOrEmpty(Filedata.FileName) || Filedata.ContentLength == 0)
            {
                rdata = "没有要上传的文件";
            }
            else
            {
                //if (UploadConfig.Base64)
                //{
                //    uploadFileName = UploadConfig.Base64Filename;
                //    //uploadFileBytes = Convert.FromBase64String(Request[UploadConfig.UploadFieldName]);
                //    uploadFileBytes = Convert.FromBase64String(Filedata.FileName);
                //}
                //else
                //{

                uploadFileName = Filedata.FileName;
                if (!CheckFileType(UploadConfig, uploadFileName))
                {
                    rdata = "不允许的文件格式";
                }
                if (!CheckFileSize(UploadConfig, Filedata.ContentLength))
                {
                    rdata = "文件大小超出服务器限制";
                }

                uploadFileBytes = new byte[Filedata.ContentLength];
                try
                {
                    Filedata.InputStream.Read(uploadFileBytes, 0, Filedata.ContentLength);
                }
                catch (Exception)
                {
                    rdata = "网络错误";
                }
                //}

                var savePath = PathFormatter.Format(uploadFileName, UploadConfig.PathFormat);
                var localPath = Server.MapPath(savePath);
                try
                {
                    if (!Directory.Exists(Path.GetDirectoryName(localPath)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(localPath));
                    }
                    System.IO.File.WriteAllBytes(localPath, uploadFileBytes);
                    rdata = savePath;
                    bResult = true;
                }
                catch (Exception e)
                {
                    rdata = "文件访问出错，请检查写入权限";
                }


            }


            return Json(new JsonResultHelper(bResult, rdata));

        }


        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="Filedata">上传文件</param>
        /// <returns>返回jsondata格式"操作结果:bool,文件资源路径</returns>
        public ActionResult UploadFile(HttpPostedFileBase Filedata)
        {
            bool bResult = false;
            string rdata = "";
            UploadConfig UploadConfig = new UploadConfig()
            {
                AllowExtensions = Config.GetStringList("fileAllowFiles"),
                PathFormat = Config.GetString("filePathFormat"),
                SizeLimit = Config.GetInt("fileMaxSize"),
                UploadFieldName = Config.GetString("fileFieldName")
            };

            byte[] uploadFileBytes = null;
            string uploadFileName = null;

            if (Filedata == null || string.IsNullOrEmpty(Filedata.FileName) || Filedata.ContentLength == 0)
            {
                rdata = "没有要上传的文件";
            }
            else
            {
                //if (UploadConfig.Base64)
                //{
                //    uploadFileName = UploadConfig.Base64Filename;
                //    //uploadFileBytes = Convert.FromBase64String(Request[UploadConfig.UploadFieldName]);
                //    uploadFileBytes = Convert.FromBase64String(Filedata.FileName);
                //}
                //else
                //{

                uploadFileName = Filedata.FileName;
                if (!CheckFileType(UploadConfig, uploadFileName))
                {
                    rdata = "不允许的文件格式";
                }
                if (!CheckFileSize(UploadConfig, Filedata.ContentLength))
                {
                    rdata = "文件大小超出服务器限制";
                }

                uploadFileBytes = new byte[Filedata.ContentLength];
                try
                {
                    Filedata.InputStream.Read(uploadFileBytes, 0, Filedata.ContentLength);
                }
                catch (Exception)
                {
                    rdata = "网络错误";
                }
                //}

                var savePath = PathFormatter.Format(uploadFileName, UploadConfig.PathFormat);
                var localPath = Server.MapPath(savePath);
                try
                {
                    if (!Directory.Exists(Path.GetDirectoryName(localPath)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(localPath));
                    }
                    System.IO.File.WriteAllBytes(localPath, uploadFileBytes);
                    rdata = savePath;
                    bResult = true;
                }
                catch (Exception e)
                {
                    rdata = "文件访问出错，请检查写入权限";
                }


            }


            return Json(new JsonResultHelper(bResult, rdata));

        }

        /// <summary>
        /// 上传scrawl图片
        /// </summary>
        /// <param name="Filedata">上传文件</param>
        /// <returns>返回jsondata格式"操作结果:bool,scrawl图片资源路径</returns>
        public ActionResult UploadScrawl(HttpPostedFileBase Filedata)
        {
            bool bResult = false;
            string rdata = "";
            UploadConfig UploadConfig = new UploadConfig()
            {
                AllowExtensions = new string[] { ".png" },
                PathFormat = Config.GetString("scrawlPathFormat"),
                SizeLimit = Config.GetInt("scrawlMaxSize"),
                UploadFieldName = Config.GetString("scrawlFieldName"),
                Base64 = true,
                Base64Filename = "scrawl.png"
            };

            byte[] uploadFileBytes = null;
            string uploadFileName = null;

            if (Filedata == null || string.IsNullOrEmpty(Filedata.FileName) || Filedata.ContentLength == 0)
            {
                rdata = "没有要上传的文件";
            }
            else
            {
                //if (UploadConfig.Base64)
                //{
                //    uploadFileName = UploadConfig.Base64Filename;
                //    //uploadFileBytes = Convert.FromBase64String(Request[UploadConfig.UploadFieldName]);
                //    uploadFileBytes = Convert.FromBase64String(Filedata.FileName);
                //}
                //else
                //{

                uploadFileName = Filedata.FileName;
                if (!CheckFileType(UploadConfig, uploadFileName))
                {
                    rdata = "不允许的文件格式";
                }
                if (!CheckFileSize(UploadConfig, Filedata.ContentLength))
                {
                    rdata = "文件大小超出服务器限制";
                }

                uploadFileBytes = new byte[Filedata.ContentLength];
                try
                {
                    Filedata.InputStream.Read(uploadFileBytes, 0, Filedata.ContentLength);
                }
                catch (Exception)
                {
                    rdata = "网络错误";
                }
                //}

                var savePath = PathFormatter.Format(uploadFileName, UploadConfig.PathFormat);
                var localPath = Server.MapPath(savePath);
                try
                {
                    if (!Directory.Exists(Path.GetDirectoryName(localPath)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(localPath));
                    }
                    System.IO.File.WriteAllBytes(localPath, uploadFileBytes);
                    rdata = savePath;
                    bResult = true;
                }
                catch (Exception e)
                {
                    rdata = "文件访问出错，请检查写入权限";
                }


            }


            return Json(new JsonResultHelper(bResult, rdata));

        }



        private bool CheckFileType(UploadConfig UploadConfig, string filename)
        {
            var fileExtension = Path.GetExtension(filename).ToLower();
            return UploadConfig.AllowExtensions.Select(x => x.ToLower()).Contains(fileExtension);
        }


        private bool CheckFileSize(UploadConfig UploadConfig, int size)
        {
            return size < UploadConfig.SizeLimit;
        }
    }
}