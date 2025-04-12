using System;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI.Docking;

using AntsResource;
using HR.Forms;
using HR.Core.Entity;
using HR.Core.Data;
using PetaPoco;
using System.Linq;

namespace HRPro.Forms
{
    public partial class Main : Form
    {
        #region 属性
        private Server server;
        public Server Server
        {
            get { return server; }
            set { server = value; }
        }

        private Database database;
        public Database Database
        {
            get { return database; }
            set { database = value; }
        }


        private Company company;
        public Company Company
        {
            get { return company; }
            set { company = value; }
        }
        #endregion


        private DeserializeDockContent deserializeDockContent;
        private readonly ToolStripRenderer toolStripProfessionalRenderer = new ToolStripProfessionalRenderer();
        private VisualStudioToolStripExtender toolStripExtender;

        public DockEmployees DockEmployees;
        public Main()
        {
            InitializeComponent();


            _Renderer();

            //关闭对其他线程的安全检查
            Control.CheckForIllegalCrossThreadCalls = false;

            //窗体双缓存减少界面闪烁
            this.DoubleBuffered = true;

            Customize();

            deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);
        }
        private void Customize()
        {
            this.Load += _Load;

            menuOrganizationCompany.Click += MenuOrganizationCompany_Click;

            menuDocumentEmployeeManage.Click += MenuDocumentEmployeeManage_Click;

            menuViewDockEmployees.Click += MenuViewDockEmployees_Click;

            menuToolsOptions.Click += MenuToolsOptions_Click;
            menuToolsDatabaseSettting.Click += MenuToolsDatabaseSettting_Click;
        }

        private void MenuDocumentEmployeeManage_Click(object sender, EventArgs e)
        {
            IDockContent content = FindDocument<EmployeeManage>();
            if (content == null)
            {
                EmployeeManage frm = new EmployeeManage()
                {
                    Database = database,
                    DockEmployees = DockEmployees,
                };
                frm.Show(dockPanel, DockState.Document);
            }
            else
            {
                content.DockHandler.Activate();
            }
        }

        private void MenuOrganizationCompany_Click(object sender, EventArgs e)
        {
            CompanySingle companySingle = new CompanySingle()
            {
                Database = Database,
                Company = Company,
            };
            if (companySingle.ShowDialog() == DialogResult.OK)
            {
                Company = companySingle.Company;
            }
        }

        private void MenuViewDockEmployees_Click(object sender, EventArgs e)
        {
            DockEmployees.Show(dockPanel, DockState.DockLeft);
        }

        private void MenuToolsOptions_Click(object sender, EventArgs e)
        {

        }

        private void MenuToolsDatabaseSettting_Click(object sender, EventArgs e)
        {
            DatabaseSetting frmDB = new DatabaseSetting();
            frmDB.AppNO = Launcher.Global.AppNO;
            frmDB.AppVer = Launcher.Global.AppVer;
            frmDB.ConfigFileServer = Launcher.Global.ConfigFileServer;
            frmDB.ShowDialog();
            if (frmDB.DialogResult == DialogResult.OK)
            {
                MessageBox.Show($"{Resources.__SetSuccessfully} {Resources.__PleaseLoginAgain}", Resources.WarningInformation, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    Form frm = Application.OpenForms[i];
                    frm.Close();
                }
                Application.Exit();
            }
        }

        public void _Renderer()
        {
            dockPanel.Theme = vs2015LightTheme;

            toolStripExtender = new VisualStudioToolStripExtender(components)
            {
                DefaultRenderer = toolStripProfessionalRenderer
            };
            toolStripExtender.SetStyle(menuMain, VisualStudioToolStripExtender.VsVersion.Vs2015, vs2015LightTheme);
            toolStripExtender.SetStyle(statusMain, VisualStudioToolStripExtender.VsVersion.Vs2015, vs2015LightTheme);
        }

        private void _Load(object sender, EventArgs e)
        {

            DockEmployees = new DockEmployees()
            { 
                HideOnClose = true,
                Database = database,
                Company = company,
            };
            DockEmployees.Show(dockPanel, DockState.DockLeft);
        }

        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(DockEmployees).ToString())
            {
                return DockEmployees;
            }
            //else if (persistString == typeof(DockEngines).ToString())
            //    return DockEngines;
            //else if (persistString == typeof(frmDockMultimeter).ToString())
            //    return DockMultimeter;
            //else if (persistString == typeof(frmDockNotify).ToString())
            //    return DockNotify;
            //else if (persistString == typeof(DockQRCode).ToString())
            //{
            //    return DockQRCodeScanners;
            //}
            //else if (persistString == typeof(DockProperty).ToString())
            //{
            //    return DockProperty;
            //}
            //else
            {
                return null;
            }
        }

        public IDockContent FindDocument<T>()
        {
            return dockPanel.Documents.FirstOrDefault(x => x.DockHandler.Form is T);
        }

    }
}
