using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.CodeDom;

using AntsResource;
using HR.Core.Entity;
using HR.Core.Data;
using HR.Core.Util;

namespace HR.Forms
{
    public partial class DatabaseSetting : Form
    {
        public string ConfigFileServer { get; set; }
        public string ConfigFileLocal { get; set; }

        public string AppNO { get; set; }
        public string AppVer { get; set; }

        public Server Server { get; set; }
        public DatabaseSetting()
        {
            InitializeComponent();
        }

        private void _Load(object sender, EventArgs e)
        {
            Localize();

            Server server = ServerHelper.Load(ConfigFileServer, $"{AppNO} v{AppVer}");
            if (server == null)
            {
                txtHost.Text = "127.0.0.1";    // Min 2023-10-16
                txtPort.Text = "5432";
                txtDatabase.Text = "HRDATA";
                txtUserID.Text = "postgres";
                txtPassword.Text = "";
            }
            else
            {
                txtHost.Text = server.Host;
                txtPort.Text = server.Port;
                txtDatabase.Text = server.DatabaseName;
                txtUserID.Text = server.DatabaseUserID;
                txtPassword.Text = server.GetPassword();
            }
            //btnTesting.Click += ConnectionTesting;
            btnTesting.Click += (se, ev) => { 
                ConnectTesting(true); 
            };

            Server local = ServerHelper.Load(ConfigFileLocal);
            if (local == null)
            {
                local = new Server();
            }



            btnOK.Click += Save;
            btnCancel.Click += Close;
        }

        private void Localize()
        {

        }

        private bool ConnectTesting(bool hasPrompt)
        {
            bool result = false;
            this.Cursor = Cursors.WaitCursor;

            using (Server srv = new Server()
            {
                Host = txtHost.Text,
                Port = txtPort.Text,
                DatabaseName = txtDatabase.Text,
                DatabaseUserID = txtUserID.Text,
            })
            {
                srv.SetPassword(txtPassword.Text);
                try
                {
                    result = srv.ConnectionTesting();
                    this.Cursor = Cursors.Default;
                    if (hasPrompt)
                    {
                        if (result)
                        { 
                            MessageBox.Show(Resources.__TestingSuccessfully, Resources.PromptInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(Resources.__TestingFailed + System.Environment.NewLine, Resources.ErrorInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    this.Cursor = Cursors.Default;
                    if (hasPrompt) MessageBox.Show(Resources.__TestingFailed + System.Environment.NewLine + ex.Message, Resources.ErrorInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return result;
        }

        private bool Vail()
        {
            if (string.IsNullOrWhiteSpace(txtHost.Text))
            {
                MessageBox.Show($"{tabPageServer.Text} {lblHost.Text} {Resources.__IsRequired}", Resources.ErrorInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPort.Text))
            {
                MessageBox.Show($"{tabPageServer.Text} {lblPort.Text} {Resources.__IsRequired}", Resources.ErrorInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDatabase.Text))
            {
                MessageBox.Show($"{tabPageServer.Text} {lblDatabase.Text} {Resources.__IsRequired}", Resources.ErrorInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                MessageBox.Show($"{tabPageServer.Text} {lblUserID.Text} {Resources.__IsRequired}", Resources.ErrorInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (!ConnectTesting(false))
            {
                if (MessageBox.Show($"{tabPageServer.Text} {Resources.__TestingFailed} {System.Environment.NewLine} {Resources.__FileChanged_DoYouSave}", Resources.ErrorInformation, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private void Save(object sender, EventArgs e)
        {
            if (!Vail())
            {
                return;
            }

            Server = new Server();
            Server.Host = txtHost.Text;
            Server.Port = txtPort.Text;
            Server.DatabaseName = txtDatabase.Text;
            Server.DatabaseUserID = txtUserID.Text;
            Server.SetPassword(txtPassword.Text);
            Server.ApplicationName = AppNO;

            bool result = ServerHelper.Save(ConfigFileServer, Server);

            if (result)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                MessageBox.Show(Resources.__FileSaveFailed, Resources.ErrorInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Close(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

    }
}
