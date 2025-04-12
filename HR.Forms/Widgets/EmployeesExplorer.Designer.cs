namespace HR.Forms.Widgets
{
    partial class EmployeesExplorer
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesExplorer));
            this.TreeView = new System.Windows.Forms.TreeView();
            this.images16 = new System.Windows.Forms.ImageList(this.components);
            this.menuDept = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDeptEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeptNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeptSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuDeptDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompany = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCompanySingle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompanyDeptNew = new System.Windows.Forms.ToolStripMenuItem();
            this.images32 = new System.Windows.Forms.ImageList(this.components);
            this.menuCompanySeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDept.SuspendLayout();
            this.menuCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeView
            // 
            this.TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView.ImageIndex = 0;
            this.TreeView.ImageList = this.images16;
            this.TreeView.ItemHeight = 23;
            this.TreeView.Location = new System.Drawing.Point(0, 0);
            this.TreeView.Margin = new System.Windows.Forms.Padding(4);
            this.TreeView.Name = "TreeView";
            this.TreeView.SelectedImageIndex = 0;
            this.TreeView.Size = new System.Drawing.Size(488, 455);
            this.TreeView.TabIndex = 0;
            // 
            // images16
            // 
            this.images16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images16.ImageStream")));
            this.images16.TransparentColor = System.Drawing.Color.Transparent;
            this.images16.Images.SetKeyName(0, "information");
            this.images16.Images.SetKeyName(1, "group");
            this.images16.Images.SetKeyName(2, "group_add");
            this.images16.Images.SetKeyName(3, "group_delete");
            this.images16.Images.SetKeyName(4, "group_edit");
            // 
            // menuDept
            // 
            this.menuDept.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDeptEdit,
            this.menuDeptNew,
            this.menuDeptSeparator1,
            this.menuDeptDelete});
            this.menuDept.Name = "menuDept";
            this.menuDept.Size = new System.Drawing.Size(149, 76);
            // 
            // menuDeptEdit
            // 
            this.menuDeptEdit.Image = ((System.Drawing.Image)(resources.GetObject("menuDeptEdit.Image")));
            this.menuDeptEdit.Name = "menuDeptEdit";
            this.menuDeptEdit.Size = new System.Drawing.Size(148, 22);
            this.menuDeptEdit.Text = "编辑部门";
            // 
            // menuDeptNew
            // 
            this.menuDeptNew.Image = ((System.Drawing.Image)(resources.GetObject("menuDeptNew.Image")));
            this.menuDeptNew.Name = "menuDeptNew";
            this.menuDeptNew.Size = new System.Drawing.Size(148, 22);
            this.menuDeptNew.Text = "新建下级部门";
            // 
            // menuDeptSeparator1
            // 
            this.menuDeptSeparator1.Name = "menuDeptSeparator1";
            this.menuDeptSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // menuDeptDelete
            // 
            this.menuDeptDelete.Image = ((System.Drawing.Image)(resources.GetObject("menuDeptDelete.Image")));
            this.menuDeptDelete.Name = "menuDeptDelete";
            this.menuDeptDelete.Size = new System.Drawing.Size(148, 22);
            this.menuDeptDelete.Text = "删除本部门";
            // 
            // menuCompany
            // 
            this.menuCompany.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRefresh,
            this.menuCompanySeparator1,
            this.menuCompanySingle,
            this.menuCompanyDeptNew});
            this.menuCompany.Name = "contextMenuStrip1";
            this.menuCompany.Size = new System.Drawing.Size(181, 98);
            // 
            // menuCompanySingle
            // 
            this.menuCompanySingle.Name = "menuCompanySingle";
            this.menuCompanySingle.Size = new System.Drawing.Size(180, 22);
            this.menuCompanySingle.Text = "公司信息";
            // 
            // menuCompanyDeptNew
            // 
            this.menuCompanyDeptNew.Image = ((System.Drawing.Image)(resources.GetObject("menuCompanyDeptNew.Image")));
            this.menuCompanyDeptNew.Name = "menuCompanyDeptNew";
            this.menuCompanyDeptNew.Size = new System.Drawing.Size(180, 22);
            this.menuCompanyDeptNew.Text = "新建一级部门";
            // 
            // images32
            // 
            this.images32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images32.ImageStream")));
            this.images32.TransparentColor = System.Drawing.Color.Transparent;
            this.images32.Images.SetKeyName(0, "information");
            this.images32.Images.SetKeyName(1, "group");
            // 
            // menuCompanySeparator1
            // 
            this.menuCompanySeparator1.Name = "menuCompanySeparator1";
            this.menuCompanySeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuRefresh
            // 
            this.menuRefresh.Image = ((System.Drawing.Image)(resources.GetObject("menuRefresh.Image")));
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.Size = new System.Drawing.Size(180, 22);
            this.menuRefresh.Text = "刷新";
            // 
            // EmployeesExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TreeView);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeesExplorer";
            this.Size = new System.Drawing.Size(488, 455);
            this.menuDept.ResumeLayout(false);
            this.menuCompany.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip menuDept;
        private System.Windows.Forms.ToolStripMenuItem menuDeptNew;
        private System.Windows.Forms.ToolStripMenuItem menuDeptEdit;
        private System.Windows.Forms.ToolStripMenuItem menuDeptDelete;
        private System.Windows.Forms.ContextMenuStrip menuCompany;
        private System.Windows.Forms.ToolStripMenuItem menuCompanySingle;
        private System.Windows.Forms.ToolStripMenuItem menuCompanyDeptNew;
        private System.Windows.Forms.ToolStripSeparator menuDeptSeparator1;
        public System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.ImageList images16;
        private System.Windows.Forms.ImageList images32;
        private System.Windows.Forms.ToolStripMenuItem menuRefresh;
        private System.Windows.Forms.ToolStripSeparator menuCompanySeparator1;
    }
}
