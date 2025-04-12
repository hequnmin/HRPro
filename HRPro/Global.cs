using System;
using System.Reflection;
using System.Windows.Forms;

using HR.Core.Data;
using HR.Core.Entity;
using HR.Core.Config;
using PetaPoco;

namespace HRPro
{
    public class Global
    {

        #region 属性
        public string AppNO { get; private set; }
        public string AppName { get; private set; }
        public string AppVer { get; private set; }

        public string AppPath { get; set; }
        public string ConfigPath { get; set; }
        public string ConfigFile { get; set; }
        public string ConfigFileServer { get; set; }
        public string ConfigFileLogin { get; set; }
        public string ConfigFileLocal { get; set; }

        public Server Server { get; set; }

        public Database Database { get; set; }

        public User User { get; set; }

        public ConfigLocal ConfigLocal { get; set; }

        public Company Company { get; set; }

        #endregion

        public Global()
        {
            AppNO = "HRIMS";
            AppName = "Human Resource Information Management System";
            AppVer = AssemblyVersion;
        }

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

    }

}
