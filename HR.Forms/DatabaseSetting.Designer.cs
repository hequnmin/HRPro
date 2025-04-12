namespace HR.Forms
{
    partial class DatabaseSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpServer = new System.Windows.Forms.GroupBox();
            this.btnTesting = new System.Windows.Forms.Button();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabDatabase = new System.Windows.Forms.TabControl();
            this.tabPageServer = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.grpServer.SuspendLayout();
            this.tabDatabase.SuspendLayout();
            this.tabPageServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpServer
            // 
            this.grpServer.Controls.Add(this.btnTesting);
            this.grpServer.Controls.Add(this.txtDatabase);
            this.grpServer.Controls.Add(this.lblDatabase);
            this.grpServer.Controls.Add(this.txtPassword);
            this.grpServer.Controls.Add(this.lblPassword);
            this.grpServer.Controls.Add(this.lblUserID);
            this.grpServer.Controls.Add(this.txtUserID);
            this.grpServer.Controls.Add(this.txtPort);
            this.grpServer.Controls.Add(this.lblPort);
            this.grpServer.Controls.Add(this.txtHost);
            this.grpServer.Controls.Add(this.lblHost);
            this.grpServer.Location = new System.Drawing.Point(16, 8);
            this.grpServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpServer.Name = "grpServer";
            this.grpServer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpServer.Size = new System.Drawing.Size(381, 258);
            this.grpServer.TabIndex = 0;
            this.grpServer.TabStop = false;
            // 
            // btnTesting
            // 
            this.btnTesting.Location = new System.Drawing.Point(268, 214);
            this.btnTesting.Name = "btnTesting";
            this.btnTesting.Size = new System.Drawing.Size(80, 25);
            this.btnTesting.TabIndex = 8;
            this.btnTesting.Text = "测试";
            this.btnTesting.UseVisualStyleBackColor = true;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(133, 106);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(215, 23);
            this.txtDatabase.TabIndex = 3;
            this.txtDatabase.Text = "ate2020";
            // 
            // lblDatabase
            // 
            this.lblDatabase.Location = new System.Drawing.Point(27, 106);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(100, 20);
            this.lblDatabase.TabIndex = 10;
            this.lblDatabase.Text = "数据库";
            this.lblDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(133, 178);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(215, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Blueway123456";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(27, 178);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 20);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "密码";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserID
            // 
            this.lblUserID.Location = new System.Drawing.Point(27, 142);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(100, 20);
            this.lblUserID.TabIndex = 7;
            this.lblUserID.Text = "用户名称";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(133, 142);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(215, 23);
            this.txtUserID.TabIndex = 4;
            this.txtUserID.Text = "postgres";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(133, 70);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(215, 23);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "5432";
            // 
            // lblPort
            // 
            this.lblPort.Location = new System.Drawing.Point(27, 70);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(100, 20);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "端口";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(133, 34);
            this.txtHost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(215, 23);
            this.txtHost.TabIndex = 1;
            this.txtHost.Text = "127.0.0.1";
            // 
            // lblHost
            // 
            this.lblHost.Location = new System.Drawing.Point(27, 34);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(100, 20);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "服务器";
            this.lblHost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(248, 326);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 35);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(334, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 35);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tabDatabase
            // 
            this.tabDatabase.Controls.Add(this.tabPageServer);
            this.tabDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabDatabase.Location = new System.Drawing.Point(5, 5);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.SelectedIndex = 0;
            this.tabDatabase.Size = new System.Drawing.Size(422, 311);
            this.tabDatabase.TabIndex = 4;
            // 
            // tabPageServer
            // 
            this.tabPageServer.Controls.Add(this.grpServer);
            this.tabPageServer.Location = new System.Drawing.Point(4, 26);
            this.tabPageServer.Name = "tabPageServer";
            this.tabPageServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServer.Size = new System.Drawing.Size(414, 281);
            this.tabPageServer.TabIndex = 0;
            this.tabPageServer.Text = "服务器";
            this.tabPageServer.UseVisualStyleBackColor = true;
            // 
            // DatabaseSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 371);
            this.Controls.Add(this.tabDatabase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DatabaseSetting";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库";
            this.Load += new System.EventHandler(this._Load);
            this.grpServer.ResumeLayout(false);
            this.grpServer.PerformLayout();
            this.tabDatabase.ResumeLayout(false);
            this.tabPageServer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpServer;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Button btnTesting;
        private System.Windows.Forms.TabControl tabDatabase;
        private System.Windows.Forms.TabPage tabPageServer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}