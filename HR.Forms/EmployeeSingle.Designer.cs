namespace HR.Forms
{
    partial class EmployeeSingle
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
            this.tabEmployee = new System.Windows.Forms.TabControl();
            this.tabEmployeeBase = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDeptRequired = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.txtEmployeeCard = new System.Windows.Forms.TextBox();
            this.lblEmployeeCard = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSexRequired = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblEmployeeNameRequired = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeNORequired = new System.Windows.Forms.Label();
            this.txtEmployeeNO = new System.Windows.Forms.TextBox();
            this.lblEmployeeNO = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabEmployee.SuspendLayout();
            this.tabEmployeeBase.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.tabEmployeeBase);
            this.tabEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabEmployee.Location = new System.Drawing.Point(10, 10);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.SelectedIndex = 0;
            this.tabEmployee.Size = new System.Drawing.Size(764, 500);
            this.tabEmployee.TabIndex = 0;
            // 
            // tabEmployeeBase
            // 
            this.tabEmployeeBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabEmployeeBase.Controls.Add(this.panel3);
            this.tabEmployeeBase.Controls.Add(this.panel2);
            this.tabEmployeeBase.Controls.Add(this.panel1);
            this.tabEmployeeBase.Location = new System.Drawing.Point(4, 26);
            this.tabEmployeeBase.Margin = new System.Windows.Forms.Padding(0);
            this.tabEmployeeBase.Name = "tabEmployeeBase";
            this.tabEmployeeBase.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.tabEmployeeBase.Size = new System.Drawing.Size(756, 470);
            this.tabEmployeeBase.TabIndex = 0;
            this.tabEmployeeBase.Text = "基本信息";
            this.tabEmployeeBase.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(15, 80);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(724, 35);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDeptRequired);
            this.panel2.Controls.Add(this.cmbDept);
            this.panel2.Controls.Add(this.lblDept);
            this.panel2.Controls.Add(this.txtEmployeeCard);
            this.panel2.Controls.Add(this.lblEmployeeCard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(15, 45);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(724, 35);
            this.panel2.TabIndex = 2;
            // 
            // lblDeptRequired
            // 
            this.lblDeptRequired.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDeptRequired.ForeColor = System.Drawing.Color.Red;
            this.lblDeptRequired.Location = new System.Drawing.Point(575, 5);
            this.lblDeptRequired.Name = "lblDeptRequired";
            this.lblDeptRequired.Size = new System.Drawing.Size(15, 25);
            this.lblDeptRequired.TabIndex = 9;
            this.lblDeptRequired.Text = "*";
            this.lblDeptRequired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDept
            // 
            this.cmbDept.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(340, 5);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(235, 25);
            this.cmbDept.TabIndex = 8;
            // 
            // lblDept
            // 
            this.lblDept.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDept.Location = new System.Drawing.Point(225, 5);
            this.lblDept.Name = "lblDept";
            this.lblDept.Padding = new System.Windows.Forms.Padding(3);
            this.lblDept.Size = new System.Drawing.Size(115, 25);
            this.lblDept.TabIndex = 3;
            this.lblDept.Text = "部门";
            this.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmployeeCard
            // 
            this.txtEmployeeCard.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtEmployeeCard.Location = new System.Drawing.Point(105, 5);
            this.txtEmployeeCard.Name = "txtEmployeeCard";
            this.txtEmployeeCard.Size = new System.Drawing.Size(120, 23);
            this.txtEmployeeCard.TabIndex = 2;
            // 
            // lblEmployeeCard
            // 
            this.lblEmployeeCard.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEmployeeCard.Location = new System.Drawing.Point(5, 5);
            this.lblEmployeeCard.Name = "lblEmployeeCard";
            this.lblEmployeeCard.Padding = new System.Windows.Forms.Padding(3);
            this.lblEmployeeCard.Size = new System.Drawing.Size(100, 25);
            this.lblEmployeeCard.TabIndex = 0;
            this.lblEmployeeCard.Text = "卡号";
            this.lblEmployeeCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSexRequired);
            this.panel1.Controls.Add(this.cmbSex);
            this.panel1.Controls.Add(this.lblSex);
            this.panel1.Controls.Add(this.lblEmployeeNameRequired);
            this.panel1.Controls.Add(this.txtEmployeeName);
            this.panel1.Controls.Add(this.lblEmployeeName);
            this.panel1.Controls.Add(this.lblEmployeeNORequired);
            this.panel1.Controls.Add(this.txtEmployeeNO);
            this.panel1.Controls.Add(this.lblEmployeeNO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(15, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(724, 35);
            this.panel1.TabIndex = 1;
            // 
            // lblSexRequired
            // 
            this.lblSexRequired.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSexRequired.ForeColor = System.Drawing.Color.Red;
            this.lblSexRequired.Location = new System.Drawing.Point(695, 5);
            this.lblSexRequired.Name = "lblSexRequired";
            this.lblSexRequired.Size = new System.Drawing.Size(15, 25);
            this.lblSexRequired.TabIndex = 8;
            this.lblSexRequired.Text = "*";
            this.lblSexRequired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSex
            // 
            this.cmbSex.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(575, 5);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(120, 25);
            this.cmbSex.TabIndex = 7;
            // 
            // lblSex
            // 
            this.lblSex.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSex.Location = new System.Drawing.Point(475, 5);
            this.lblSex.Name = "lblSex";
            this.lblSex.Padding = new System.Windows.Forms.Padding(3);
            this.lblSex.Size = new System.Drawing.Size(100, 25);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "性别";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmployeeNameRequired
            // 
            this.lblEmployeeNameRequired.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEmployeeNameRequired.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeNameRequired.Location = new System.Drawing.Point(460, 5);
            this.lblEmployeeNameRequired.Name = "lblEmployeeNameRequired";
            this.lblEmployeeNameRequired.Size = new System.Drawing.Size(15, 25);
            this.lblEmployeeNameRequired.TabIndex = 5;
            this.lblEmployeeNameRequired.Text = "*";
            this.lblEmployeeNameRequired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtEmployeeName.Location = new System.Drawing.Point(340, 5);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(120, 23);
            this.txtEmployeeName.TabIndex = 4;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEmployeeName.Location = new System.Drawing.Point(240, 5);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Padding = new System.Windows.Forms.Padding(3);
            this.lblEmployeeName.Size = new System.Drawing.Size(100, 25);
            this.lblEmployeeName.TabIndex = 3;
            this.lblEmployeeName.Text = "姓名";
            this.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmployeeNORequired
            // 
            this.lblEmployeeNORequired.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEmployeeNORequired.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeNORequired.Location = new System.Drawing.Point(225, 5);
            this.lblEmployeeNORequired.Name = "lblEmployeeNORequired";
            this.lblEmployeeNORequired.Size = new System.Drawing.Size(15, 25);
            this.lblEmployeeNORequired.TabIndex = 2;
            this.lblEmployeeNORequired.Text = "*";
            this.lblEmployeeNORequired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmployeeNO
            // 
            this.txtEmployeeNO.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtEmployeeNO.Location = new System.Drawing.Point(105, 5);
            this.txtEmployeeNO.Name = "txtEmployeeNO";
            this.txtEmployeeNO.Size = new System.Drawing.Size(120, 23);
            this.txtEmployeeNO.TabIndex = 1;
            // 
            // lblEmployeeNO
            // 
            this.lblEmployeeNO.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEmployeeNO.Location = new System.Drawing.Point(5, 5);
            this.lblEmployeeNO.Name = "lblEmployeeNO";
            this.lblEmployeeNO.Padding = new System.Windows.Forms.Padding(3);
            this.lblEmployeeNO.Size = new System.Drawing.Size(100, 25);
            this.lblEmployeeNO.TabIndex = 0;
            this.lblEmployeeNO.Text = "员工编号";
            this.lblEmployeeNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(695, 516);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(603, 516);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 35);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // EmployeeSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabEmployee);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeSingle";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工信息";
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployeeBase.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEmployee;
        private System.Windows.Forms.TabPage tabEmployeeBase;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblEmployeeNO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEmployeeNO;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblEmployeeCard;
        private System.Windows.Forms.Label lblEmployeeNORequired;
        private System.Windows.Forms.Label lblEmployeeNameRequired;
        private System.Windows.Forms.Label lblSexRequired;
        private System.Windows.Forms.TextBox txtEmployeeCard;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblDeptRequired;
        private System.Windows.Forms.ComboBox cmbDept;
    }
}