using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace gerenatecode
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            /* aaa */
            InitializeComponent();
            txtConnection.Text = @"Data Source=.; Integrated Security=True; Initial Catalog=TemplateGeneration; Pooling=True; MultipleActiveResultSets=True;";
            txtFilePath.Text = @"c:\GenerateCode\";
            txtProjectName.Text = "Partial";
        }

        #region 公共数据库操作方法

        /// <summary>        
        /// 执行ExecuteDataTable()，得到DataTable        
        /// </summary>        
        /// <param name="cmdText"></param>        
        /// <param name="parameters"></param>        
        /// <returns></returns>        
        public DataTable ExecuteDataTable(string cmdText, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(txtConnection.Text))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    cmd.Parameters.AddRange(parameters);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        /// <summary>        
        /// 数据库类型转换为C#类型        
        /// </summary>        
        /// <param name="dataType"></param>        
        /// <returns></returns>        
        private static Type GetType(string dataType)
        {
            switch (dataType.ToLower())
            {
                case "nvarchar":
                case "varchar":
                case "nchar":
                case "char":
                    return typeof(string);
                case "int":
                    return typeof(int);
                case "bigint":
                    return typeof(long);
                case "bit":
                    return typeof(bool);
                case "datetime":
                    return typeof(DateTime);
                default:
                    return typeof(object);
            }
        }

        /// <summary>        
        /// 数据库类型转换为C#类型        
        /// </summary>        
        /// <param name="dataType"></param>        
        /// <returns></returns>        
        private static string GetTypeString(string dataType)
        {
            switch (dataType.ToLower())
            {
                case "nvarchar":
                case "varchar":
                case "nchar":
                case "char":
                    return "string";
                case "int":
                    return "int";
                case "bigint":
                    return "long";
                case "bit":
                    return "bool";
                case "datetime":
                case "date":
                    return "DateTime";
                case "decimal":
                    return "decimal";
                case "text":
                    return "string";
                default:
                    return "object";
            }
        }

        private static string Get(string dataType)
        {
            switch (dataType.ToLower())
            {
                case "system.string":
                    return "ToString";
                case "system.int32":
                    return "ToInt32";
                case "system.int64":
                    return "ToInt64";
                case "system.datetime":
                    return "ToDateTime";
                case "system.boolean":
                    return "ToBoolean";
                default:
                    throw new Exception("找不到匹配的数据类型");
            }
        }

        #endregion

        #region 用户操作
        private void btnTestConnection_Click(object sender, RoutedEventArgs e)
        {
            //清空          
            ltbAvalidList.Items.Clear();
            //查询系统试图           
            string sql = "Select name from sysObjects Where xtype='U' and name<>'dtproperties' Order By name";
            DataTable dt = ExecuteDataTable(sql);
            //根据系统视图取得TABLE_NAME           
            foreach (DataRow row in dt.Rows)
            {
                CheckBox cb = new CheckBox();

                string tablename = Convert.ToString(row["name"]);
                ltbAvalidList.Items.Add(new CheckBox() { Content = tablename });
            }
        }

        private void chkAvalidAll_Click(object sender, RoutedEventArgs e)
        {
            if (chkAvalidAll.IsChecked == true)
            {
                foreach (CheckBox chk in ltbAvalidList.Items)
                {
                    chk.IsChecked = true;
                }
            }
            else
            {
                foreach (CheckBox chk in ltbAvalidList.Items)
                {
                    chk.IsChecked = false;
                }
            }
        }

        private void chkSelectAll_Click(object sender, RoutedEventArgs e)
        {
            if (chkSelectAll.IsChecked == true)
            {
                foreach (CheckBox chk in ltbSelectedList.Items)
                {
                    chk.IsChecked = true;
                }
            }
            else
            {
                foreach (CheckBox chk in ltbSelectedList.Items)
                {
                    chk.IsChecked = false;
                }
            }
        }

        private void btnAddTable_Click(object sender, RoutedEventArgs e)
        {
            List<CheckBox> list = new List<CheckBox>();
            foreach (CheckBox chk in ltbAvalidList.Items)
            {
                if (chk.IsChecked == true)
                {
                    list.Add(chk);
                }
            }

            foreach (CheckBox chk in list)
            {
                ltbAvalidList.Items.Remove(chk);
                ltbSelectedList.Items.Add(chk);
            }

        }

        private void btnRemoveTable_Click(object sender, RoutedEventArgs e)
        {
            List<CheckBox> list = new List<CheckBox>();
            foreach (CheckBox chk in ltbSelectedList.Items)
            {
                if (chk.IsChecked == true)
                {
                    list.Add(chk);
                }
            }

            foreach (CheckBox chk in list)
            {
                ltbSelectedList.Items.Remove(chk);
                ltbAvalidList.Items.Add(chk);
            }


        }

        private void btnOpenFilePath_Click(object sender, RoutedEventArgs e)
        {
            if (Directory.Exists(txtFilePath.Text) == false)
            {
                Directory.CreateDirectory(txtFilePath.Text);
            }
            System.Diagnostics.Process.Start(txtFilePath.Text);

        }

        private void btnGenerateCode_Click(object sender, RoutedEventArgs e)
        {
            if (txtModelNamespace.Text.Trim().Length < 1)
            {
                MessageBox.Show("请输入模块命名空间");
                txtModelNamespace.Focus();
                return;
            }
            #region
            if (chkDBContext.IsChecked == true)
            {
                GenerateDBContext();
            }

            //if (chkCtxconfig.IsChecked == true)
            //{
            //    GenerateCtxConfig();
            //}

            if (chkRptconfig.IsChecked == true)
            {
                GenerateRptConfig();
            }

            if (chkSvcconfig.IsChecked == true)
            {
                GenerateSvcConfig();
            }

            if (chkAppconfig.IsChecked == true)
            {
                GenerateAppConfig();
            }

            if (chkSwap.IsChecked == true)
            {
                GenerateSwap();
            }
            #endregion
            foreach (CheckBox chk in ltbSelectedList.Items)
            {
                if (chkEnt.IsChecked == true)
                {
                    string msg = GenerateEnt(chk.Content.ToString());
                }
                if (chkBasicDto.IsChecked == true)
                {

                    string msg = GenerateBasicDto(chk.Content.ToString());
                }

                if (chkpartialdto.IsChecked == true)
                {
                    string msg = GeneratePartialDto(chk.Content.ToString());
                }

                if (chkRpt.IsChecked == true)
                {
                    string msg = GenerateRpt(chk.Content.ToString());
                }

                if (chkISvc.IsChecked == true)
                {
                    string msg = GenerateISvc(chk.Content.ToString());
                }

                if (chkBaseSvc.IsChecked == true)
                {
                    string msg = GenerateBaseSvc(chk.Content.ToString());
                }

                if (chksvc.IsChecked == true)
                {
                    string msg = GenerateSvc(chk.Content.ToString());
                }

            }
            MessageBox.Show("代码生成完毕");

        }
        #endregion

        #region 文件生成
        private void WriteToCSFile(string tablename, StringBuilder sb, string model, string prefileName, string endfileName, string extendPath)
        {
            #region 文件夹及文件路径处理
            string filePath = txtFilePath.Text + model + "\\";
            if (!string.IsNullOrEmpty(extendPath))
            {
                filePath = filePath + extendPath + "\\";
            }

            if (Directory.Exists(filePath) == false)
            {
                Directory.CreateDirectory(filePath);
            }


            string fileName = filePath + prefileName + tablename + endfileName + ".cs";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            #endregion
            ///写文件
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(sb.ToString());
                sw.Close();
                fs.Close();
            }
        }

        /// <summary>
        /// 写入Cs文件txtModelNamespace.Text.Trim(), sb, "svc", "", "DBContext"
        /// </summary> 
        private void WriteToCSFile(string tablename, StringBuilder sb, string model, string prefileName, string endfileName)
        {
            #region 文件夹及文件路径处理
            string filePath = txtFilePath.Text + model + "\\";
            if (Directory.Exists(filePath) == false)
            {
                Directory.CreateDirectory(filePath);
            }


            string fileName = filePath + prefileName + tablename + endfileName + ".cs";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            #endregion
            ///写文件
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(sb.ToString());
                sw.Close();
                fs.Close();
            }
        }

        /// <summary>
        /// 写配置文件
        /// </summary>
        /// <param name="tablename"></param>
        /// <param name="sb"></param>
        /// <param name="model"></param>
        /// <param name="prefileName"></param>
        /// <param name="endfileName"></param>
        private void WriteToConfigFile(string tablename, StringBuilder sb, string model, string prefileName, string endfileName)
        {
            #region 文件夹及文件路径处理
            string filePath = txtFilePath.Text + model + "\\Config\\";
            if (Directory.Exists(filePath) == false)
            {
                Directory.CreateDirectory(filePath);
            }


            string fileName = filePath + prefileName + tablename + endfileName + "-config.xml";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            #endregion
            ///写文件
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(sb.ToString());
                sw.Close();
                fs.Close();
            }
        }
        #endregion

        #region  文件类型
        /// <summary>
        /// 生成实体类
        /// </summary>
        /// <param name="tablename"></param>
        /// <returns></returns>
        private string GenerateEnt(string tablename)
        {
            string msg = tablename + "ent文件生成";
            string sql = "Select  c.name As ColumnName,t.name As TypeName,c.Length,c.xprec,c.xscale,c.isnullable From syscolumns c, systypes t, sysobjects o Where c.xtype = t.xusertype And c.id = o.id And o.name ='" + tablename + "' Order By c.colorder ";
            DataTable dt = ExecuteDataTable(sql);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using System;");
            sb.AppendLine("using sct.cm.data;");
            sb.AppendLine("using System.ComponentModel.DataAnnotations;");
            sb.AppendLine("");
            sb.AppendLine("");

            sb.AppendLine("namespace sct.ent." + txtModelNamespace.Text.Trim().ToLower());
            sb.AppendLine("{");
            sb.AppendLine("");
            sb.AppendLine("  public class " + tablename + " : Entity");
            sb.AppendLine("  {");
            foreach (DataRow row in dt.Rows)
            {
                string ColumnName = row["ColumnName"].ToString();
                string TypeName = GetTypeString(row["TypeName"].ToString());
                string Length = row["Length"].ToString();
                string isnullable = "";// row["isnullable"].ToString() == "1" && TypeName != "string" ? "?" : "";
                if (ColumnName != "Id" && ColumnName.IndexOf("SYS_") == -1)
                {
                    //字符串限定长度
                    if (TypeName == "string" && row["TypeName"].ToString().ToLower() != "text")
                    {
                        sb.AppendLine("    [StringLength(" + Length + ")]");
                    }
                    sb.AppendLine("    public " + TypeName + isnullable + " " + ColumnName + "{ get; set; } ");
                    sb.AppendLine("");
                }
            }
            sb.AppendLine("  }");
            sb.AppendLine("");
            sb.AppendLine("}");

            WriteToCSFile(tablename, sb, "ent", "", "");
            return msg;
        }

        private string GenerateBasicDto(string tablename)
        {
            string msg = tablename + "dto文件生成";
            string sql = "Select  c.name As ColumnName,t.name As TypeName,c.Length,c.xprec,c.xscale,c.isnullable From syscolumns c, systypes t, sysobjects o Where c.xtype = t.xusertype And c.id = o.id And o.name ='" + tablename + "' Order By c.colorder ";
            DataTable dt = ExecuteDataTable(sql);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using System;");
            sb.AppendLine("using System.Runtime.Serialization;"); ;
            sb.AppendLine("using System.ComponentModel.DataAnnotations;");
            sb.AppendLine("");
            sb.AppendLine("");

            sb.AppendLine("namespace sct.dto." + txtModelNamespace.Text.Trim().ToLower());
            sb.AppendLine("{");
            sb.AppendLine("");
            sb.AppendLine("[DataContract]");
            sb.AppendLine("  public partial class " + tablename + "Info");
            sb.AppendLine("  {");
            foreach (DataRow row in dt.Rows)
            {
                string ColumnName = row["ColumnName"].ToString();
                string TypeName = GetTypeString(row["TypeName"].ToString());
                string Length = row["Length"].ToString();
                string isnullable = "";// row["isnullable"].ToString() == "1" && TypeName != "string" ? "?" : "";


                /*是否脏数据，默认为0非脏数据*/
                sb.AppendLine("    [DataMember]");
                sb.AppendLine("    internal int  _" + ColumnName + "IsDirty = 0; ");
                sb.AppendLine("");

                /*后台值*/
                sb.AppendLine("    [DataMember]");
                sb.AppendLine("    internal " + TypeName + isnullable + "  _" + ColumnName + "; ");
                sb.AppendLine("");

                /*前台设值*/
                sb.AppendLine("    [DataMember]");
                //字符串限定长度
                if (TypeName == "string" && row["TypeName"].ToString().ToLower() != "text")
                {
                    sb.AppendLine("    [StringLength(" + Length + ")]");
                }
                sb.AppendLine("    public " + TypeName + isnullable + "  " + ColumnName);
                sb.AppendLine("    {");
                sb.AppendLine("      get{");
                sb.AppendLine("         return _" + ColumnName + ";");
                sb.AppendLine("      }");
                sb.AppendLine("      set{");
                sb.AppendLine("         _" + ColumnName + " = value;");
                sb.AppendLine("         _" + ColumnName + "IsDirty = 1;");
                sb.AppendLine("      }");
                sb.AppendLine("    }");
                sb.AppendLine("");

            }
            sb.AppendLine("  }");
            sb.AppendLine("");
            sb.AppendLine("}");

            WriteToCSFile(tablename, sb, "dto", "", "Info", "Basic");
            return msg;
        }

        private string GeneratePartialDto(string tablename)
        {
            string msg = tablename + "dto文件生成";
            string sql = "Select  c.name As ColumnName,t.name As TypeName,c.Length,c.xprec,c.xscale,c.isnullable From syscolumns c, systypes t, sysobjects o Where c.xtype = t.xusertype And c.id = o.id And o.name ='" + tablename + "' Order By c.colorder ";
            DataTable dt = ExecuteDataTable(sql);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using System;");
            sb.AppendLine("using System.Runtime.Serialization;");
            sb.AppendLine("using System.ComponentModel.DataAnnotations;");
            sb.AppendLine("");
            sb.AppendLine("");

            sb.AppendLine("namespace sct.dto." + txtModelNamespace.Text.Trim().ToLower());
            sb.AppendLine("{");
            sb.AppendLine("");
            sb.AppendLine("  public partial class " + tablename + "Info");
            sb.AppendLine("  {");
            sb.AppendLine("   ");
            sb.AppendLine("  }");
            sb.AppendLine("");
            sb.AppendLine("}");

            WriteToCSFile(tablename, sb, "dto", "", "Info", txtProjectName.Text.Trim());
            return msg;
        }

        private string GenerateISvc(string tablename)
        {
            string msg = tablename + "Isvc文件生成";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using sct.dto." + txtModelNamespace.Text.Trim().ToLower() + ";");
            sb.AppendLine("using sct.cm.data;");
            sb.AppendLine("using System.Collections.Specialized;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("namespace sct.svc." + txtModelNamespace.Text.Trim().ToLower());
            sb.AppendLine("{");
            sb.AppendLine("");
            sb.AppendLine("    public interface I" + tablename + "Service");
            sb.AppendLine("    { ");
            sb.AppendLine("");
            sb.AppendLine("         OperationResult Create(" + tablename + "Info info);");
            sb.AppendLine("");
            sb.AppendLine("         OperationResult Modify(" + tablename + "Info info);");
            sb.AppendLine("");
            sb.AppendLine("         OperationResult Remove(string key);");
            sb.AppendLine("");
            sb.AppendLine("         " + tablename + "Info Load(string key);");
            sb.AppendLine("");
            sb.AppendLine("         OperationResult Create(IEnumerable<" + tablename + "Info> infoList);");
            sb.AppendLine("");
            sb.AppendLine("         OperationResult Modify(IEnumerable<" + tablename + "Info> infoList);");
            sb.AppendLine("");
            sb.AppendLine("         OperationResult Remove(IEnumerable<string> keyList);");
            sb.AppendLine("");
            sb.AppendLine("         PageResult<" + tablename + "Info>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);");
            sb.AppendLine("");
            sb.AppendLine("         List<" + tablename + "Info> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("    }");
            sb.AppendLine("");
            sb.AppendLine("}");

            WriteToCSFile(tablename, sb, "isvc", "I", "Service");
            return msg;
        }

        private string GenerateRpt(string tablename)
        {
            string msg = tablename + "Rpt文件生成";
            StringBuilder sb = new StringBuilder();


            sb.AppendLine("using sct.ent." + txtModelNamespace.Text.Trim().ToLower() + ";");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Data.Entity;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("");
            sb.AppendLine("namespace sct.svc." + txtModelNamespace.Text.Trim().ToLower() + ".imp");
            sb.AppendLine("{");
            sb.AppendLine("");
            sb.AppendLine("  public class " + tablename + "Rpt");
            sb.AppendLine("  {");
            sb.AppendLine("");
            sb.AppendLine("    public void Insert(DbContext DbContext," + tablename + " entity)");
            sb.AppendLine("    {");
            sb.AppendLine("      DbContext.Entry(entity).State = EntityState.Added;");
            sb.AppendLine("    }");
            sb.AppendLine("");
            sb.AppendLine("     public void Update(DbContext DbContext," + tablename + " entity)");
            sb.AppendLine("     {");
            sb.AppendLine("       EntityState state = DbContext.Entry(entity).State;");
            sb.AppendLine("       if (state == EntityState.Detached)");
            sb.AppendLine("       {");
            sb.AppendLine("          DbContext.Entry(entity).State = EntityState.Modified;");
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("");
            sb.AppendLine("    public void Delete(DbContext DbContext," + tablename + "  entity)");
            sb.AppendLine("    {");
            sb.AppendLine("       DbContext.Entry(entity).State = EntityState.Deleted;");
            sb.AppendLine("    }");
            sb.AppendLine("");
            sb.AppendLine("     public " + tablename + " Get(DbContext DbContext, string key)");
            sb.AppendLine("    {");
            sb.AppendLine("        return DbContext.Set<" + tablename + ">().Where(p => p.Id.Equals(key)).FirstOrDefault();");
            sb.AppendLine("    }");
            sb.AppendLine("");
            sb.AppendLine("    public void Insert(DbContext DbContext, IEnumerable<" + tablename + "> entities)");
            sb.AppendLine("    {");
            sb.AppendLine("       try");
            sb.AppendLine("       {");
            sb.AppendLine("          DbContext.Configuration.AutoDetectChangesEnabled = false;");
            sb.AppendLine("          foreach (" + tablename + "  entity in entities)");
            sb.AppendLine("          {");
            sb.AppendLine("            DbContext.Entry(entity).State = EntityState.Added;");
            sb.AppendLine("          }");
            sb.AppendLine("       }");
            sb.AppendLine("       finally");
            sb.AppendLine("       {");
            sb.AppendLine("         DbContext.Configuration.AutoDetectChangesEnabled = true;");
            sb.AppendLine("       }");
            sb.AppendLine("    }");
            sb.AppendLine("");
            sb.AppendLine("    public void Update(DbContext DbContext, IEnumerable<" + tablename + "> entities)");
            sb.AppendLine("    {");
            sb.AppendLine("       try");
            sb.AppendLine("       {");
            sb.AppendLine("          DbContext.Configuration.AutoDetectChangesEnabled = false;");
            sb.AppendLine("          foreach (" + tablename + "  entity in entities)");
            sb.AppendLine("          {");
            sb.AppendLine("              EntityState state = DbContext.Entry(entity).State;");
            sb.AppendLine("              if (state == EntityState.Detached)");
            sb.AppendLine("             {");
            sb.AppendLine("                DbContext.Entry(entity).State = EntityState.Modified;");
            sb.AppendLine("             }");
            sb.AppendLine("          }");
            sb.AppendLine("       }");
            sb.AppendLine("       finally");
            sb.AppendLine("       {");
            sb.AppendLine("         DbContext.Configuration.AutoDetectChangesEnabled = true;");
            sb.AppendLine("       }");
            sb.AppendLine("    }");
            sb.AppendLine("");
            sb.AppendLine("    public void Delete(DbContext DbContext, IEnumerable<" + tablename + "> entities)");
            sb.AppendLine("    {");
            sb.AppendLine("       try");
            sb.AppendLine("       {");
            sb.AppendLine("          DbContext.Configuration.AutoDetectChangesEnabled = false;");
            sb.AppendLine("          foreach (" + tablename + "  entity in entities)");
            sb.AppendLine("          {");
            sb.AppendLine("             DbContext.Entry(entity).State = EntityState.Deleted;");
            sb.AppendLine("          }");
            sb.AppendLine("       }");
            sb.AppendLine("       finally");
            sb.AppendLine("       {");
            sb.AppendLine("         DbContext.Configuration.AutoDetectChangesEnabled = true;");
            sb.AppendLine("       }");
            sb.AppendLine("      }");
            sb.AppendLine("");
            sb.AppendLine("  }");
            sb.AppendLine("");
            sb.AppendLine("}");

            WriteToCSFile(tablename, sb, "svc", "", "Rpt", "Rpt");
            return msg;
        }




        private string GenerateBaseSvc(string tablename)
        {
            string msg = tablename + "svc文件生成";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using sct.cm.data;");
            sb.AppendLine("using sct.dto." + txtModelNamespace.Text.Trim().ToLower() + ";");
            sb.AppendLine("using sct.ent." + txtModelNamespace.Text.Trim().ToLower() + ";");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Data.Entity;");
            sb.AppendLine("using System.Collections.Specialized;");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("namespace sct.svc." + txtModelNamespace.Text.Trim().ToLower() + ".imp");
            sb.AppendLine("{");
            sb.AppendLine("");
            sb.AppendLine("    public class " + tablename + "BaseService");
            sb.AppendLine("    { ");
            sb.AppendLine("");
            sb.AppendLine("         protected virtual " + tablename + "Rpt " + tablename + "Rpt { get; set; }");
            sb.AppendLine("");
            //sb.AppendLine("         protected DbContext DbContext { get; set; }");
            //sb.AppendLine("");
            sb.AppendLine("         public virtual OperationResult Create(" + tablename + "Info info)");
            sb.AppendLine("         {");
            sb.AppendLine("            OperationResult result = new OperationResult(OperationResultType.Error, \"操作失败,请稍后重试!\");");
            sb.AppendLine("            using (var DbContext = new " + txtModelNamespace.Text.Trim() + "DbContext())");
            sb.AppendLine("            {");
            sb.AppendLine("              " + tablename + " entity = new " + tablename + "();");
            sb.AppendLine("              DESwap." + tablename + "DTE(info, entity);");
            sb.AppendLine("              " + tablename + "Rpt.Insert(DbContext, entity);");
            sb.AppendLine("              DbContext.SaveChanges();");
            sb.AppendLine("            }");
            sb.AppendLine("            result.ResultType = OperationResultType.Success;");
            sb.AppendLine("            result.Message = \"操作成功!\";");
            sb.AppendLine("            return result;");
            sb.AppendLine("        }");
            sb.AppendLine("");
            sb.AppendLine("         public virtual OperationResult Modify(" + tablename + "Info info)");
            sb.AppendLine("         {");
            sb.AppendLine("            OperationResult result = new OperationResult(OperationResultType.Error, \"操作失败,请稍后重试!\");");
            sb.AppendLine("            using (var DbContext = new " + txtModelNamespace.Text.Trim() + "DbContext())");
            sb.AppendLine("            {");
            sb.AppendLine("            " + tablename + " entity = " + tablename + "Rpt.Get(DbContext, info.Id);");
            sb.AppendLine("            DESwap." + tablename + "DTE(info, entity);");
            sb.AppendLine("            " + tablename + "Rpt.Update(DbContext, entity);");
            sb.AppendLine("            DbContext.SaveChanges();");
            sb.AppendLine("            }");
            sb.AppendLine("            result.ResultType = OperationResultType.Success;");
            sb.AppendLine("            result.Message = \"操作成功!\";");
            sb.AppendLine("            return result;");
            sb.AppendLine("         }");
            sb.AppendLine("");
            sb.AppendLine("         public virtual OperationResult Remove(string key)");
            sb.AppendLine("         {");
            sb.AppendLine("            OperationResult result = new OperationResult(OperationResultType.Error, \"操作失败,请稍后重试!\");");
            sb.AppendLine("            using (var DbContext = new " + txtModelNamespace.Text.Trim() + "DbContext())");
            sb.AppendLine("            {");
            sb.AppendLine("            " + tablename + " entity = " + tablename + "Rpt.Get(DbContext, key);");
            sb.AppendLine("            " + tablename + "Rpt.Delete(DbContext, entity);");
            sb.AppendLine("            DbContext.SaveChanges();");
            sb.AppendLine("            }");
            sb.AppendLine("            result.ResultType = OperationResultType.Success;");
            sb.AppendLine("            result.Message = \"操作成功!\";");
            sb.AppendLine("            return result;");
            sb.AppendLine("         }");
            sb.AppendLine("");
            sb.AppendLine("         public virtual " + tablename + "Info Load(string key)");
            sb.AppendLine("         {");
            sb.AppendLine("            " + tablename + "Info info = new " + tablename + "Info();");
            sb.AppendLine("            using (var DbContext = new " + txtModelNamespace.Text.Trim() + "DbContext())");
            sb.AppendLine("            {");
            sb.AppendLine("            " + tablename + " entity = " + tablename + "Rpt.Get(DbContext, key);");
            sb.AppendLine("            DESwap." + tablename + "ETD(entity,info);");
            sb.AppendLine("            }");
            sb.AppendLine("            return info;");
            sb.AppendLine("         }");
            sb.AppendLine("");
            sb.AppendLine("         public virtual OperationResult Create(IEnumerable<" + tablename + "Info> infoList)");
            sb.AppendLine("         {");
            sb.AppendLine("            OperationResult result = new OperationResult(OperationResultType.Error, \"操作失败,请稍后重试!\");");
            sb.AppendLine("            List<" + tablename + "> eList = new List<" + tablename + ">();");
            sb.AppendLine("            infoList.ForEach(x =>");
            sb.AppendLine("            {");
            sb.AppendLine("                " + tablename + " entity = new " + tablename + "();");
            sb.AppendLine("                DESwap. " + tablename + "DTE(x, entity);");
            sb.AppendLine("                eList.Add(entity);");
            sb.AppendLine("            });");
            sb.AppendLine("            using (var DbContext = new " + txtModelNamespace.Text.Trim() + "DbContext())");
            sb.AppendLine("            {");
            sb.AppendLine("            " + tablename + "Rpt.Insert(DbContext, eList);");
            sb.AppendLine("            DbContext.SaveChanges();");
            sb.AppendLine("            }");
            sb.AppendLine("            result.ResultType = OperationResultType.Success;");
            sb.AppendLine("            result.Message = \"操作成功!\";");
            sb.AppendLine("            return result;");
            sb.AppendLine("         }");
            sb.AppendLine("");
            sb.AppendLine("         public virtual OperationResult Modify(IEnumerable<" + tablename + "Info> infoList)");
            sb.AppendLine("         {");
            sb.AppendLine("            OperationResult result = new OperationResult(OperationResultType.Error, \"操作失败,请稍后重试!\");");
            sb.AppendLine("            List<" + tablename + "> eList = new List<" + tablename + ">();");
            sb.AppendLine("            infoList.ForEach(x =>");
            sb.AppendLine("            {");
            sb.AppendLine("                " + tablename + " entity = new " + tablename + "();");
            sb.AppendLine("                DESwap. " + tablename + "DTE(x, entity);");
            sb.AppendLine("                eList.Add(entity);");
            sb.AppendLine("            });");
            sb.AppendLine("            using (var DbContext = new " + txtModelNamespace.Text.Trim() + "DbContext())");
            sb.AppendLine("            {");
            sb.AppendLine("            " + tablename + "Rpt.Update(DbContext, eList);");
            sb.AppendLine("            DbContext.SaveChanges();");
            sb.AppendLine("            }");
            sb.AppendLine("            result.ResultType = OperationResultType.Success;");
            sb.AppendLine("            result.Message = \"操作成功!\";");
            sb.AppendLine("            return result;");
            sb.AppendLine("         }");
            sb.AppendLine("");
            sb.AppendLine("         public virtual OperationResult Remove(IEnumerable<string> keyList)");
            sb.AppendLine("         {");
            sb.AppendLine("            OperationResult result = new OperationResult(OperationResultType.Error, \"操作失败,请稍后重试!\");");
            sb.AppendLine("            List<" + tablename + "> eList = new List<" + tablename + ">();");
            sb.AppendLine("            using (var DbContext = new " + txtModelNamespace.Text.Trim() + "DbContext())");
            sb.AppendLine("            {");
            sb.AppendLine("            keyList.ForEach(x =>");
            sb.AppendLine("            {");
            sb.AppendLine("                " + tablename + " entity = " + tablename + "Rpt.Get(DbContext, x);");
            sb.AppendLine("                eList.Add(entity);");
            sb.AppendLine("            });");
            sb.AppendLine("            " + tablename + "Rpt.Delete(DbContext, eList);");
            sb.AppendLine("            DbContext.SaveChanges();");
            sb.AppendLine("            }");
            sb.AppendLine("            result.ResultType = OperationResultType.Success;");
            sb.AppendLine("            result.Message = \"操作成功!\";");
            sb.AppendLine("            return result;");
            sb.AppendLine("         }");
            sb.AppendLine("");
            sb.AppendLine("         public virtual List<" + tablename + "Info>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)");
            sb.AppendLine("         {");
            sb.AppendLine("");
            sb.AppendLine("            List<" + tablename + "> list = null;");
            sb.AppendLine("");
            sb.AppendLine("            using (var DbContext = new " + txtModelNamespace.Text.Trim() + "DbContext())");
            sb.AppendLine("            {");
            sb.AppendLine("            var query = from i in DbContext." + tablename);
            sb.AppendLine("                        select i;");
            sb.AppendLine("");
            sb.AppendLine("            #region 条件");
            sb.AppendLine("            foreach (string key in searchCondtionCollection)");
            sb.AppendLine("            {");
            sb.AppendLine("                string condition = searchCondtionCollection[key];");
            sb.AppendLine("                switch (key.ToLower())");
            sb.AppendLine("                {");
            sb.AppendLine("                    case \"isvalid\":");
            sb.AppendLine("                        int value = Convert.ToInt32(condition);");
            sb.AppendLine("                        query = query.Where(x => x.SYS_IsValid.Equals(value));");
            sb.AppendLine("                        break;");
            sb.AppendLine("                    default:");
            sb.AppendLine("                        break;");
            sb.AppendLine("                }");
            sb.AppendLine("            }");
            sb.AppendLine("            #endregion");
            sb.AppendLine("");
            sb.AppendLine("            #region 排序");
            sb.AppendLine("            foreach (string sort in sortCollection)");
            sb.AppendLine("            {");
            sb.AppendLine("                string direct = string.Empty;");
            sb.AppendLine("                switch (sort.ToLower())");
            sb.AppendLine("                {");
            sb.AppendLine("                    case \"createtime\":");
            sb.AppendLine("                        if (direct.ToLower().Equals(\"asc\"))");
            sb.AppendLine("                        {");
            sb.AppendLine("                            query = query.OrderBy(x => new { x.SYS_CreateTime });");
            sb.AppendLine("                        }");
            sb.AppendLine("                        else");
            sb.AppendLine("                        {");
            sb.AppendLine("                            query = query.OrderByDescending(x => new { x.SYS_CreateTime });");
            sb.AppendLine("                        }");
            sb.AppendLine("                        break;");
            sb.AppendLine("                    default:");
            sb.AppendLine("                        query = query.OrderByDescending(x => new { x.SYS_OrderSeq });");
            sb.AppendLine("                        break;");
            sb.AppendLine("                }");
            sb.AppendLine("            }");
            sb.AppendLine("           list = query.ToList();");
            sb.AppendLine("            }");
            sb.AppendLine("            #endregion");
            sb.AppendLine("            #region linq to entity");
            sb.AppendLine("            List<" + tablename + "Info> ilist = new List<" + tablename + "Info>();");
            sb.AppendLine("            list.ForEach(x =>");
            sb.AppendLine("            {");
            sb.AppendLine("                " + tablename + "Info info = new " + tablename + "Info();");
            sb.AppendLine("                DESwap." + tablename + "ETD(x, info);");
            sb.AppendLine("                ilist.Add(info);");
            sb.AppendLine("            });");
            sb.AppendLine("            #endregion");
            sb.AppendLine("");
            sb.AppendLine("            return ilist;;");
            sb.AppendLine("         }");
            sb.AppendLine("");
            sb.AppendLine("    }");
            sb.AppendLine("");
            sb.AppendLine("}");
            WriteToCSFile(tablename, sb, "svc", "", "BaseService", "Base");
            return msg;
        }





        private string GenerateSvc(string tablename)
        {
            string msg = tablename + "svc文件生成";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using sct.cm.data;");
            sb.AppendLine("using sct.dto." + txtModelNamespace.Text.Trim().ToLower() + ";");
            sb.AppendLine("using sct.ent." + txtModelNamespace.Text.Trim().ToLower() + ";");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Data.Entity;");
            sb.AppendLine("using System.Collections.Specialized;");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("namespace sct.svc." + txtModelNamespace.Text.Trim().ToLower() + ".imp");
            sb.AppendLine("{");
            sb.AppendLine("");
            sb.AppendLine("    public  class " + tablename + "Service" + " : " + tablename + "BaseService" + ",I" + tablename + "Service");
            sb.AppendLine("    { ");
            sb.AppendLine("");
            sb.AppendLine("         public PageResult<" + tablename + "Info>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize)");
            sb.AppendLine("         {");
            sb.AppendLine("            PageResult<" + tablename + "Info> result = new PageResult<" + tablename + "Info>();");
            sb.AppendLine("            int skip = (pageNumber - 1) * pageSize;");
            sb.AppendLine("            int take = pageSize;");
            sb.AppendLine("            List<" + tablename + "> list = null;");
            sb.AppendLine("");
            sb.AppendLine("            using (var DbContext = new " + txtModelNamespace.Text.Trim() + "DbContext())");
            sb.AppendLine("            {");
            sb.AppendLine("            var query = from i in DbContext." + tablename);
            sb.AppendLine("                        select i;");
            sb.AppendLine("");
            sb.AppendLine("            #region 条件");
            sb.AppendLine("            foreach (string key in searchCondtionCollection)");
            sb.AppendLine("            {");
            sb.AppendLine("                string condition = searchCondtionCollection[key];");
            sb.AppendLine("                switch (key.ToLower())");
            sb.AppendLine("                {");
            sb.AppendLine("                    case \"isvalid\":");
            sb.AppendLine("                        int value = Convert.ToInt32(condition);");
            sb.AppendLine("                        query = query.Where(x => x.SYS_IsValid.Equals(value));");
            sb.AppendLine("                        break;");
            sb.AppendLine("                    default:");
            sb.AppendLine("                        break;");
            sb.AppendLine("                }");
            sb.AppendLine("            }");
            sb.AppendLine("            #endregion");
            sb.AppendLine("");
            sb.AppendLine("            result.TotalRecords = query.Count();");
            sb.AppendLine("");
            sb.AppendLine("            #region 排序");
            sb.AppendLine("            foreach (string sort in sortCollection)");
            sb.AppendLine("            {");
            sb.AppendLine("                string direct = string.Empty;");
            sb.AppendLine("                switch (sort.ToLower())");
            sb.AppendLine("                {");
            sb.AppendLine("                    case \"createtime\":");
            sb.AppendLine("                        if (direct.ToLower().Equals(\"asc\"))");
            sb.AppendLine("                        {");
            sb.AppendLine("                            query = query.OrderBy(x => new { x.SYS_CreateTime }).Skip(skip).Take(take);");
            sb.AppendLine("                        }");
            sb.AppendLine("                        else");
            sb.AppendLine("                        {");
            sb.AppendLine("                            query = query.OrderByDescending(x => new { x.SYS_CreateTime }).Skip(skip).Take(take);");
            sb.AppendLine("                        }");
            sb.AppendLine("                        break;");
            sb.AppendLine("                    default:");
            sb.AppendLine("                        query = query.OrderByDescending(x => new { x.SYS_OrderSeq }).Skip(skip).Take(take);");
            sb.AppendLine("                        break;");
            sb.AppendLine("                }");
            sb.AppendLine("            }");
            sb.AppendLine("           list = query.ToList();");
            sb.AppendLine("            }");
            sb.AppendLine("            #endregion");
            sb.AppendLine("            #region linq to entity");
            sb.AppendLine("            List<" + tablename + "Info> ilist = new List<" + tablename + "Info>();");
            sb.AppendLine("            list.ForEach(x =>");
            sb.AppendLine("            {");
            sb.AppendLine("                " + tablename + "Info info = new " + tablename + "Info();");
            sb.AppendLine("                DESwap." + tablename + "ETD(x, info);");
            sb.AppendLine("                ilist.Add(info);");
            sb.AppendLine("            });");
            sb.AppendLine("            #endregion");
            sb.AppendLine("");
            sb.AppendLine("            result.PageSize = pageSize;");
            sb.AppendLine("            result.PageNumber = pageNumber;");
            sb.AppendLine("            result.Data = ilist;");
            sb.AppendLine("            return result;;");
            sb.AppendLine("         }");
            sb.AppendLine("");
            sb.AppendLine("    }");
            sb.AppendLine("");
            sb.AppendLine("}");
            WriteToCSFile(tablename, sb, "svc", "", "Service", txtProjectName.Text.Trim());
            return msg;
        }



        private string GenerateSwap()
        {
            string sql = "Select name from sysObjects Where xtype='U' and name<>'dtproperties' Order By name";
            DataTable dt = ExecuteDataTable(sql);

            string msg = txtModelNamespace.Text.Trim() + "DE转换";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using sct.ent." + txtModelNamespace.Text.Trim().ToLower() + ";");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("namespace sct.dto." + txtModelNamespace.Text.Trim().ToLower());
            sb.AppendLine("{");
            sb.AppendLine("");
            sb.AppendLine("  public class DESwap");
            sb.AppendLine("  {");
            sb.AppendLine("");
            foreach (DataRow row in dt.Rows)
            {
                string csql = "Select  c.name As ColumnName,t.name As TypeName,c.Length,c.xprec,c.xscale,c.isnullable From syscolumns c, systypes t, sysobjects o Where c.xtype = t.xusertype And c.id = o.id And o.name ='" + Convert.ToString(row["name"]) + "' Order By c.colorder ";
                DataTable cdt = ExecuteDataTable(csql);
                /*DTE*/
                sb.AppendLine("    public static void " + Convert.ToString(row["name"]) + "DTE(" + Convert.ToString(row["name"]) + "Info info, " + Convert.ToString(row["name"]) + " entity)");
                sb.AppendLine("    {");
                foreach (DataRow crow in cdt.Rows)
                {
                    string ColumnName = crow["ColumnName"].ToString();
                    sb.AppendLine("       if (info._" + ColumnName + "IsDirty == 1)");
                    sb.AppendLine("        {");
                    sb.AppendLine("           entity." + ColumnName + " = info." + ColumnName + ";");
                    sb.AppendLine("           info._" + ColumnName + "IsDirty = 0;");
                    sb.AppendLine("        }");
                    sb.AppendLine("");
                }
                sb.AppendLine("    }");
                sb.AppendLine("");

                /*ETD*/
                sb.AppendLine("    public static void " + Convert.ToString(row["name"]) + "ETD(" + Convert.ToString(row["name"]) + " entity, " + Convert.ToString(row["name"]) + "Info info)");
                sb.AppendLine("    {");
                foreach (DataRow crow in cdt.Rows)
                {
                    string ColumnName = crow["ColumnName"].ToString();
                    sb.AppendLine("       info." + crow["ColumnName"].ToString() + " = entity." + crow["ColumnName"].ToString() + ";");
                    sb.AppendLine("       info._" + crow["ColumnName"].ToString() + "IsDirty = 0;");
                    sb.AppendLine("");
                }
                sb.AppendLine("    }");
                sb.AppendLine("");
            }
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("  }");
            sb.AppendLine("");
            sb.AppendLine("}");
            //WriteToCSFile("DE", sb, "dto", "", "Swap");
            WriteToCSFile("DE", sb, "dto", "", "Swap");

            return msg;
        }
        #endregion

        #region 配置文件
        private string GenerateDBContext()
        {
            string sql = "Select name from sysObjects Where xtype='U' and name<>'dtproperties' Order By name";
            DataTable dt = ExecuteDataTable(sql);


            string msg = txtModelNamespace.Text.Trim() + "DbContext数据库上下文生成";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Data.Entity;");
            sb.AppendLine("using System.Data.Entity.ModelConfiguration.Conventions;");
            sb.AppendLine("using sct.ent." + txtModelNamespace.Text.Trim().ToLower() + ";");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("namespace sct.svc." + txtModelNamespace.Text.Trim().ToLower() + ".imp");
            sb.AppendLine("{");
            sb.AppendLine("");
            sb.AppendLine("  public class " + txtModelNamespace.Text.Trim() + "DbContext : DbContext");
            sb.AppendLine("  {");
            sb.AppendLine("");
            sb.AppendLine("    public " + txtModelNamespace.Text.Trim() + "DbContext() : base(\"" + txtModelNamespace.Text.Trim() + "Entities\") { }");
            sb.AppendLine("");
            //sb.AppendLine("    public " + txtModelNamespace.Text.Trim() + "DbContext(string nameOrConnectionString) : base(nameOrConnectionString) { }");
            sb.AppendLine("");


            sb.AppendLine("    #region 包含对象");
            foreach (DataRow row in dt.Rows)
            {
                sb.AppendLine("    public DbSet<" + Convert.ToString(row["name"]) + ">  " + Convert.ToString(row["name"]) + "  {　get;　set;　}");
                sb.AppendLine("");
            }
            sb.AppendLine("    #endregion");


            sb.AppendLine("");
            sb.AppendLine("    protected override void OnModelCreating(DbModelBuilder modelBuilder)");
            sb.AppendLine("    {");
            //sb.AppendLine("     modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();");
            sb.AppendLine("       modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();");
            sb.AppendLine("    }");
            sb.AppendLine("");
            sb.AppendLine("  }");
            sb.AppendLine("");
            sb.AppendLine("}");
            WriteToCSFile(txtModelNamespace.Text.Trim(), sb, "svc", "", "DbContext");
            return msg;

        }
        //private string GenerateCtxConfig()
        //{
        //    string msg = txtModelNamespace.Text.Trim() + "ctx配置文件生成";
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
        //    sb.AppendLine("<objects  xmlns=\"http://www.springframework.net\" default-autowire=\"byName\">");
        //    sb.AppendLine("<object id=\"" + txtModelNamespace.Text.Trim() + "DbContext\" type=\"sct.svc." + txtModelNamespace.Text.Trim().ToLower() + ".imp." + txtModelNamespace.Text.Trim() + "DbContext,sct.svc." + txtModelNamespace.Text.Trim().ToLower() + ".imp\">");
        //    sb.AppendLine("<constructor-arg name=\"nameOrConnectionString\" value=\"" + txtModelNamespace.Text.Trim() + "Entities\"/>");
        //    sb.AppendLine("</object>");
        //    sb.AppendLine("</objects>");
        //    WriteToConfigFile("ctx", sb, "svc", "", "");
        //    return msg;
        //}

        private string GenerateRptConfig()
        {
            string sql = "Select name from sysObjects Where xtype='U' and name<>'dtproperties' Order By name";
            DataTable dt = ExecuteDataTable(sql);
            string msg = txtModelNamespace.Text.Trim() + "rpt配置文件生成";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sb.AppendLine("<objects  xmlns=\"http://www.springframework.net\" default-autowire=\"byName\">");
            foreach (DataRow row in dt.Rows)
            {
                sb.AppendLine("<object id=\"" + Convert.ToString(row["name"]) + "Rpt\" type=\"sct.svc." + txtModelNamespace.Text.Trim().ToLower() + ".imp." + Convert.ToString(row["name"]) + "Rpt,sct.svc." + txtModelNamespace.Text.Trim().ToLower() + ".imp\">");
                sb.AppendLine("</object>");
            }
            sb.AppendLine("</objects>");

            WriteToConfigFile("rpt", sb, "svc", "", "");
            return msg;
        }

        private string GenerateSvcConfig()
        {
            string sql = "Select name from sysObjects Where xtype='U' and name<>'dtproperties' Order By name";
            DataTable dt = ExecuteDataTable(sql);
            string msg = txtModelNamespace.Text.Trim() + "svc配置文件生成";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sb.AppendLine("<objects  xmlns='http://www.springframework.net' default-autowire=\"byName\">");
            foreach (DataRow row in dt.Rows)
            {
                sb.AppendLine("<object id=\"" + Convert.ToString(row["name"]) + "Service\" type=\"sct.svc." + txtModelNamespace.Text.Trim() + ".Imp." + Convert.ToString(row["name"]) + "Service,sct.svc." + txtModelNamespace.Text.Trim() + ".Imp\">");
                sb.AppendLine("<property name=\"" + Convert.ToString(row["name"]) + "Rpt\" ref=\"" + Convert.ToString(row["name"]) + "Rpt\" />");
                //sb.AppendLine("<property name=\"DbContext\" ref=\"" + txtModelNamespace.Text.Trim() + "DbContext\" />");
                sb.AppendLine(" </object>");
            }
            sb.AppendLine("</objects>");
            WriteToConfigFile("svc", sb, "svc", "", "");
            return msg;
        }

        private string GenerateAppConfig()
        {
            string msg = txtModelNamespace.Text.Trim() + "svc配置文件生成";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sb.AppendLine("<objects xmlns='http://www.springframework.net' xmlns:tx=\"http://www.springframework.net/tx\" xmlns:aop=\"http://www.springframework.net/aop\" default-autowire=\"byName\">");
            //sb.AppendLine("<import resource=\"assembly://sct.svc." + txtModelNamespace.Text.Trim().ToLower() + ".imp/sct.svc." + txtModelNamespace.Text.Trim().ToLower() + ".imp.Config/ctx-config.xml\"/>");
            sb.AppendLine("<import resource=\"assembly://sct.svc." + txtModelNamespace.Text.Trim().ToLower() + ".imp/sct.svc." + txtModelNamespace.Text.Trim().ToLower() + ".imp.Config/rpt-config.xml\"/>");
            sb.AppendLine("<import resource=\"assembly://sct.svc." + txtModelNamespace.Text.Trim().ToLower() + ".imp/sct.svc." + txtModelNamespace.Text.Trim().ToLower() + ".imp.Config/svc-config.xml\"/>");
            sb.AppendLine("</objects>");
            WriteToConfigFile("app", sb, "svc", "", "");

            return msg;

        }
        #endregion
    }
}