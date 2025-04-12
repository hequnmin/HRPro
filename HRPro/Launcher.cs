using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using PetaPoco;
using AntsResource;
using HR.Core.Config;
using HR.Core.Data;
using HR.Core.Util;
using HR.Forms;

namespace HRPro
{
    internal static class Launcher
    {
        public static Global Global;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InitializeGlobal();

            Global.Server = ServerHelper.Load(Global.ConfigFileServer, $"{Global.AppNO} v{Global.AppVer}");
            // 未配置数据库连接(数据库配置文件不存在)
            if (Global.Server == null)
            {
                DatabaseSetting dbSetting = new DatabaseSetting()
                {
                    AppNO = Global.AppNO,
                    AppVer = Global.AppVer,
                    ConfigFileServer = Global.ConfigFileServer,
                };
                Application.Run(dbSetting);
                if (dbSetting.DialogResult == DialogResult.OK)
                {
                    Global.Server = ServerHelper.Load(Global.ConfigFileServer, $"{Global.AppNO} v{Global.AppVer}");
                    if (Global.Server == null)
                    {
                        Application.Exit();
                        return;
                    }
                }
                else
                {
                    Application.Exit();
                    return;
                }
            }
            Global.Database = new Database(Global.Server.ConnectionString(), Global.Server.Provider);
            
            List<Company> companys = Global.Database.Fetch<Company>();
            if (companys.Count <= 0)
            {
                // 无本地配置，新增公司信息
                CompanySingle companySingle = new CompanySingle()
                {
                    Database = Global.Database,
                    Company = Global.Company,
                };
                if (companySingle.ShowDialog() == DialogResult.OK)
                {
                    Global.Company = companySingle.Company;
                    companys.Add(companySingle.Company);
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
                return;
            }

            // 本地配置文件
            Global.ConfigLocal = JsonHelper.DeserializeFile<ConfigLocal>(Global.ConfigFileLocal);
            if (Global.ConfigLocal == null )     
            {
                Global.ConfigLocal = new ConfigLocal();

                Global.Company = companys.FirstOrDefault();
                Global.ConfigLocal.CompanyID = Global.Company.CompanyID;

                if (!JsonHelper.SerializeFile(Global.ConfigLocal, Global.ConfigFileLocal))
                {
                    MessageBox.Show(Resources.__FileSaveFailed, Resources.ErrorInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return;
                }
            }
            else
            {
                // 有本地配置，获取公司信息
                try
                {
                    Global.Company = Global.Database.Single<Company>(Global.ConfigLocal.CompanyID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Resources.__AnErrorOccurred + System.Environment.NewLine + ex.Message , Resources.ErrorInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return;
                }

                if (Global.Company == null)
                {
                    MessageBox.Show(Resources.Company + Resources.__NotExist, Resources.ErrorInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Application.Exit();
                    return;
                }
            }

            Application.Run( 
                new Forms.Main()
                {
                    Server = Global.Server,
                    Database = Global.Database,
                    Company = Global.Company,
                }
            );
        }

        static void InitializeGlobal()
        {
            Global = new Global();

            //配置文件路径
            Global.AppPath = Application.StartupPath;
            Global.ConfigPath = $"{Global.AppPath}\\.ate\\config";
            Global.ConfigFile = $"{Global.ConfigPath}\\config.json";
            Global.ConfigFileLogin = $"{Global.ConfigPath}\\login.json";
            Global.ConfigFileServer = $"{Global.ConfigPath}\\server.json";
            Global.ConfigFileLocal = $"{Global.ConfigPath}\\local.json";
        }
    }
}
