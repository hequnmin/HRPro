namespace HR.Forms
{
    partial class DeptSingle
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
            this.tabDept = new System.Windows.Forms.TabControl();
            this.tabDeptPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblParentRequired = new System.Windows.Forms.Label();
            this.lblDeptTextRequired = new System.Windows.Forms.Label();
            this.lblCompanyRequired = new System.Windows.Forms.Label();
            this.chkDisused = new System.Windows.Forms.CheckBox();
            this.txtSortNO = new System.Windows.Forms.TextBox();
            this.lblSortNO = new System.Windows.Forms.Label();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.cmbParent = new System.Windows.Forms.ComboBox();
            this.lblParent = new System.Windows.Forms.Label();
            this.txtDeptNO = new System.Windows.Forms.TextBox();
            this.lblDeptNO = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabDept.SuspendLayout();
            this.tabDeptPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDept
            // 
            this.tabDept.Controls.Add(this.tabDeptPage1);
            this.tabDept.Location = new System.Drawing.Point(14, 13);
            this.tabDept.Name = "tabDept";
            this.tabDept.SelectedIndex = 0;
            this.tabDept.Size = new System.Drawing.Size(497, 314);
            this.tabDept.TabIndex = 0;
            // 
            // tabDeptPage1
            // 
            this.tabDeptPage1.Controls.Add(this.groupBox1);
            this.tabDeptPage1.Location = new System.Drawing.Point(4, 26);
            this.tabDeptPage1.Name = "tabDeptPage1";
            this.tabDeptPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeptPage1.Size = new System.Drawing.Size(489, 284);
            this.tabDeptPage1.TabIndex = 0;
            this.tabDeptPage1.Text = "基本信息";
            this.tabDeptPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblParentRequired);
            this.groupBox1.Controls.Add(this.lblDeptTextRequired);
            this.groupBox1.Controls.Add(this.lblCompanyRequired);
            this.groupBox1.Controls.Add(this.chkDisused);
            this.groupBox1.Controls.Add(this.txtSortNO);
            this.groupBox1.Controls.Add(this.lblSortNO);
            this.groupBox1.Controls.Add(this.txtDeptName);
            this.groupBox1.Controls.Add(this.lblDeptName);
            this.groupBox1.Controls.Add(this.cmbParent);
            this.groupBox1.Controls.Add(this.lblParent);
            this.groupBox1.Controls.Add(this.txtDeptNO);
            this.groupBox1.Controls.Add(this.lblDeptNO);
            this.groupBox1.Controls.Add(this.cmbCompany);
            this.groupBox1.Controls.Add(this.lblCompany);
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(452, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblParentRequired
            // 
            this.lblParentRequired.ForeColor = System.Drawing.Color.Red;
            this.lblParentRequired.Location = new System.Drawing.Point(394, 64);
            this.lblParentRequired.Name = "lblParentRequired";
            this.lblParentRequired.Size = new System.Drawing.Size(15, 25);
            this.lblParentRequired.TabIndex = 5;
            this.lblParentRequired.Text = "*";
            this.lblParentRequired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeptTextRequired
            // 
            this.lblDeptTextRequired.ForeColor = System.Drawing.Color.Red;
            this.lblDeptTextRequired.Location = new System.Drawing.Point(394, 100);
            this.lblDeptTextRequired.Name = "lblDeptTextRequired";
            this.lblDeptTextRequired.Size = new System.Drawing.Size(15, 25);
            this.lblDeptTextRequired.TabIndex = 8;
            this.lblDeptTextRequired.Text = "*";
            this.lblDeptTextRequired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompanyRequired
            // 
            this.lblCompanyRequired.ForeColor = System.Drawing.Color.Red;
            this.lblCompanyRequired.Location = new System.Drawing.Point(394, 26);
            this.lblCompanyRequired.Name = "lblCompanyRequired";
            this.lblCompanyRequired.Size = new System.Drawing.Size(15, 25);
            this.lblCompanyRequired.TabIndex = 2;
            this.lblCompanyRequired.Text = "*";
            this.lblCompanyRequired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkDisused
            // 
            this.chkDisused.AutoSize = true;
            this.chkDisused.Location = new System.Drawing.Point(139, 210);
            this.chkDisused.Name = "chkDisused";
            this.chkDisused.Size = new System.Drawing.Size(51, 21);
            this.chkDisused.TabIndex = 13;
            this.chkDisused.Text = "停用";
            this.chkDisused.UseVisualStyleBackColor = true;
            // 
            // txtSortNO
            // 
            this.txtSortNO.Location = new System.Drawing.Point(139, 171);
            this.txtSortNO.Name = "txtSortNO";
            this.txtSortNO.Size = new System.Drawing.Size(250, 23);
            this.txtSortNO.TabIndex = 12;
            // 
            // lblSortNO
            // 
            this.lblSortNO.Location = new System.Drawing.Point(13, 171);
            this.lblSortNO.Name = "lblSortNO";
            this.lblSortNO.Size = new System.Drawing.Size(120, 25);
            this.lblSortNO.TabIndex = 11;
            this.lblSortNO.Text = "排序编号";
            this.lblSortNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(139, 100);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(250, 23);
            this.txtDeptName.TabIndex = 7;
            // 
            // lblDeptName
            // 
            this.lblDeptName.Location = new System.Drawing.Point(13, 100);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(120, 25);
            this.lblDeptName.TabIndex = 6;
            this.lblDeptName.Text = "部门名称";
            this.lblDeptName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbParent
            // 
            this.cmbParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParent.FormattingEnabled = true;
            this.cmbParent.Location = new System.Drawing.Point(139, 64);
            this.cmbParent.Name = "cmbParent";
            this.cmbParent.Size = new System.Drawing.Size(250, 25);
            this.cmbParent.TabIndex = 4;
            // 
            // lblParent
            // 
            this.lblParent.Location = new System.Drawing.Point(13, 64);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(120, 25);
            this.lblParent.TabIndex = 3;
            this.lblParent.Text = "上级部门";
            this.lblParent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDeptNO
            // 
            this.txtDeptNO.Location = new System.Drawing.Point(139, 134);
            this.txtDeptNO.Name = "txtDeptNO";
            this.txtDeptNO.Size = new System.Drawing.Size(250, 23);
            this.txtDeptNO.TabIndex = 10;
            // 
            // lblDeptNO
            // 
            this.lblDeptNO.Location = new System.Drawing.Point(13, 134);
            this.lblDeptNO.Name = "lblDeptNO";
            this.lblDeptNO.Size = new System.Drawing.Size(120, 25);
            this.lblDeptNO.TabIndex = 9;
            this.lblDeptNO.Text = "部门编号";
            this.lblDeptNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCompany
            // 
            this.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(139, 26);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(250, 25);
            this.cmbCompany.TabIndex = 1;
            // 
            // lblCompany
            // 
            this.lblCompany.Location = new System.Drawing.Point(13, 26);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(120, 25);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "所属公司";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(432, 338);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(341, 338);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 35);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // DeptSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 391);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabDept);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeptSingle";
            this.ShowIcon = false;
            this.Text = "部门信息";
            this.tabDept.ResumeLayout(false);
            this.tabDeptPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDept;
        private System.Windows.Forms.TabPage tabDeptPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.TextBox txtDeptNO;
        private System.Windows.Forms.Label lblDeptNO;
        private System.Windows.Forms.ComboBox cmbParent;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.TextBox txtSortNO;
        private System.Windows.Forms.Label lblSortNO;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.CheckBox chkDisused;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblCompanyRequired;
        private System.Windows.Forms.Label lblDeptTextRequired;
        private System.Windows.Forms.Label lblParentRequired;
    }
}