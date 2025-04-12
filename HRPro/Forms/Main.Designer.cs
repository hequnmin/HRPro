namespace HRPro.Forms
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrganizationCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewDockEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolsDatabaseSettting = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.vs2015LightTheme = new WeifenLuo.WinFormsUI.Docking.VS2015LightTheme();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.menuDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDocumentEmployeeManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem,
            this.menuOrganization,
            this.menuDocument,
            this.menuView,
            this.menuTools,
            this.menuHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuMain.Size = new System.Drawing.Size(892, 27);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "MenuStrip";
            // 
            // menuSystem
            // 
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(59, 21);
            this.menuSystem.Text = "系统(&S)";
            // 
            // menuOrganization
            // 
            this.menuOrganization.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOrganizationCompany});
            this.menuOrganization.Name = "menuOrganization";
            this.menuOrganization.Size = new System.Drawing.Size(62, 21);
            this.menuOrganization.Text = "组织(&O)";
            // 
            // menuOrganizationCompany
            // 
            this.menuOrganizationCompany.Name = "menuOrganizationCompany";
            this.menuOrganizationCompany.Size = new System.Drawing.Size(180, 22);
            this.menuOrganizationCompany.Text = "公司信息";
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewDockEmployees,
            this.menuViewStatusBar});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(60, 21);
            this.menuView.Text = "视图(&V)";
            // 
            // menuViewDockEmployees
            // 
            this.menuViewDockEmployees.Name = "menuViewDockEmployees";
            this.menuViewDockEmployees.Size = new System.Drawing.Size(180, 22);
            this.menuViewDockEmployees.Text = "员工浏览器";
            // 
            // menuViewStatusBar
            // 
            this.menuViewStatusBar.Checked = true;
            this.menuViewStatusBar.CheckOnClick = true;
            this.menuViewStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuViewStatusBar.Name = "menuViewStatusBar";
            this.menuViewStatusBar.Size = new System.Drawing.Size(180, 22);
            this.menuViewStatusBar.Text = "状态栏(&S)";
            // 
            // menuTools
            // 
            this.menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolsOptions,
            this.menuToolsDatabaseSettting});
            this.menuTools.Name = "menuTools";
            this.menuTools.Size = new System.Drawing.Size(59, 21);
            this.menuTools.Text = "工具(&T)";
            // 
            // menuToolsOptions
            // 
            this.menuToolsOptions.Name = "menuToolsOptions";
            this.menuToolsOptions.Size = new System.Drawing.Size(118, 22);
            this.menuToolsOptions.Text = "选项(&O)";
            // 
            // menuToolsDatabaseSettting
            // 
            this.menuToolsDatabaseSettting.Name = "menuToolsDatabaseSettting";
            this.menuToolsDatabaseSettting.Size = new System.Drawing.Size(118, 22);
            this.menuToolsDatabaseSettting.Text = "数据库";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(61, 21);
            this.menuHelp.Text = "帮助(&H)";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.contentsToolStripMenuItem.Text = "目录(&C)";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.indexToolStripMenuItem.Text = "索引(&I)";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.searchToolStripMenuItem.Text = "搜索(&S)";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(163, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aboutToolStripMenuItem.Text = "关于(&A) ... ...";
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusMain.Location = new System.Drawing.Point(0, 557);
            this.statusMain.Name = "statusMain";
            this.statusMain.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusMain.Size = new System.Drawing.Size(892, 22);
            this.statusMain.TabIndex = 2;
            this.statusMain.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel.Text = "状态";
            // 
            // dockPanel
            // 
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DockBackColor = System.Drawing.SystemColors.Window;
            this.dockPanel.Location = new System.Drawing.Point(0, 27);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(892, 530);
            this.dockPanel.TabIndex = 4;
            // 
            // menuDocument
            // 
            this.menuDocument.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDocumentEmployeeManage});
            this.menuDocument.Name = "menuDocument";
            this.menuDocument.Size = new System.Drawing.Size(61, 21);
            this.menuDocument.Text = "档案(&D)";
            // 
            // menuDocumentEmployeeManage
            // 
            this.menuDocumentEmployeeManage.Name = "menuDocumentEmployeeManage";
            this.menuDocumentEmployeeManage.Size = new System.Drawing.Size(180, 22);
            this.menuDocumentEmployeeManage.Text = "员工管理";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(892, 579);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "HR Pro";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuViewStatusBar;
        private System.Windows.Forms.ToolStripMenuItem menuTools;
        private System.Windows.Forms.ToolStripMenuItem menuToolsOptions;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer timer;
        private WeifenLuo.WinFormsUI.Docking.VS2015LightTheme vs2015LightTheme;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStripMenuItem menuViewDockEmployees;
        private System.Windows.Forms.ToolStripMenuItem menuToolsDatabaseSettting;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem menuOrganization;
        private System.Windows.Forms.ToolStripMenuItem menuOrganizationCompany;
        private System.Windows.Forms.ToolStripMenuItem menuDocument;
        private System.Windows.Forms.ToolStripMenuItem menuDocumentEmployeeManage;
    }
}



