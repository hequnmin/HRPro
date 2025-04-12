namespace HR.Forms
{
    partial class CompanySingle
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
            this.tabCompany = new System.Windows.Forms.TabControl();
            this.tabCompanyPage1 = new System.Windows.Forms.TabPage();
            this.boxDescription = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.boxOther = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtLegalRepresentativeName = new System.Windows.Forms.TextBox();
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblLegalRepresentativeName = new System.Windows.Forms.Label();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.lblRegistrationNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.boxBaseInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCompanyNORequired = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyNameEnglish = new System.Windows.Forms.TextBox();
            this.lblCompanyNameEnglish = new System.Windows.Forms.Label();
            this.lblCompanyNO = new System.Windows.Forms.Label();
            this.txtCompanyNO = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabCompany.SuspendLayout();
            this.tabCompanyPage1.SuspendLayout();
            this.boxDescription.SuspendLayout();
            this.boxOther.SuspendLayout();
            this.boxBaseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCompany
            // 
            this.tabCompany.Controls.Add(this.tabCompanyPage1);
            this.tabCompany.Location = new System.Drawing.Point(13, 12);
            this.tabCompany.Name = "tabCompany";
            this.tabCompany.SelectedIndex = 0;
            this.tabCompany.Size = new System.Drawing.Size(497, 585);
            this.tabCompany.TabIndex = 0;
            // 
            // tabCompanyPage1
            // 
            this.tabCompanyPage1.Controls.Add(this.boxDescription);
            this.tabCompanyPage1.Controls.Add(this.boxOther);
            this.tabCompanyPage1.Controls.Add(this.boxBaseInfo);
            this.tabCompanyPage1.Location = new System.Drawing.Point(4, 26);
            this.tabCompanyPage1.Name = "tabCompanyPage1";
            this.tabCompanyPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabCompanyPage1.Size = new System.Drawing.Size(489, 555);
            this.tabCompanyPage1.TabIndex = 0;
            this.tabCompanyPage1.Text = "公司信息";
            this.tabCompanyPage1.UseVisualStyleBackColor = true;
            // 
            // boxDescription
            // 
            this.boxDescription.Controls.Add(this.txtDescription);
            this.boxDescription.Location = new System.Drawing.Point(16, 418);
            this.boxDescription.Name = "boxDescription";
            this.boxDescription.Size = new System.Drawing.Size(456, 120);
            this.boxDescription.TabIndex = 2;
            this.boxDescription.TabStop = false;
            this.boxDescription.Text = "公司简介";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(15, 24);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(428, 81);
            this.txtDescription.TabIndex = 0;
            // 
            // boxOther
            // 
            this.boxOther.Controls.Add(this.lblEmail);
            this.boxOther.Controls.Add(this.lblPhone);
            this.boxOther.Controls.Add(this.txtLegalRepresentativeName);
            this.boxOther.Controls.Add(this.txtRegistrationNumber);
            this.boxOther.Controls.Add(this.txtAddress);
            this.boxOther.Controls.Add(this.lblLegalRepresentativeName);
            this.boxOther.Controls.Add(this.txtWebsite);
            this.boxOther.Controls.Add(this.lblRegistrationNumber);
            this.boxOther.Controls.Add(this.txtEmail);
            this.boxOther.Controls.Add(this.lblAddress);
            this.boxOther.Controls.Add(this.txtPhone);
            this.boxOther.Controls.Add(this.lblWebsite);
            this.boxOther.Location = new System.Drawing.Point(15, 163);
            this.boxOther.Name = "boxOther";
            this.boxOther.Size = new System.Drawing.Size(458, 242);
            this.boxOther.TabIndex = 1;
            this.boxOther.TabStop = false;
            this.boxOther.Text = "其他信息";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(14, 61);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(120, 23);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "邮箱";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(14, 26);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(120, 23);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "电话";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLegalRepresentativeName
            // 
            this.txtLegalRepresentativeName.Location = new System.Drawing.Point(144, 197);
            this.txtLegalRepresentativeName.Name = "txtLegalRepresentativeName";
            this.txtLegalRepresentativeName.Size = new System.Drawing.Size(255, 23);
            this.txtLegalRepresentativeName.TabIndex = 11;
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.Location = new System.Drawing.Point(144, 162);
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(255, 23);
            this.txtRegistrationNumber.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(144, 127);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(255, 23);
            this.txtAddress.TabIndex = 7;
            // 
            // lblLegalRepresentativeName
            // 
            this.lblLegalRepresentativeName.Location = new System.Drawing.Point(14, 197);
            this.lblLegalRepresentativeName.Name = "lblLegalRepresentativeName";
            this.lblLegalRepresentativeName.Size = new System.Drawing.Size(120, 23);
            this.lblLegalRepresentativeName.TabIndex = 10;
            this.lblLegalRepresentativeName.Text = "法定代表人";
            this.lblLegalRepresentativeName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(144, 94);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(255, 23);
            this.txtWebsite.TabIndex = 5;
            // 
            // lblRegistrationNumber
            // 
            this.lblRegistrationNumber.Location = new System.Drawing.Point(14, 162);
            this.lblRegistrationNumber.Name = "lblRegistrationNumber";
            this.lblRegistrationNumber.Size = new System.Drawing.Size(120, 23);
            this.lblRegistrationNumber.TabIndex = 8;
            this.lblRegistrationNumber.Text = "统一社会信用代码";
            this.lblRegistrationNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(144, 61);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(14, 127);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(120, 23);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "地址";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(144, 26);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(255, 23);
            this.txtPhone.TabIndex = 1;
            // 
            // lblWebsite
            // 
            this.lblWebsite.Location = new System.Drawing.Point(14, 94);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(120, 23);
            this.lblWebsite.TabIndex = 4;
            this.lblWebsite.Text = "网址";
            this.lblWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // boxBaseInfo
            // 
            this.boxBaseInfo.Controls.Add(this.label1);
            this.boxBaseInfo.Controls.Add(this.lblCompanyNORequired);
            this.boxBaseInfo.Controls.Add(this.txtCompanyName);
            this.boxBaseInfo.Controls.Add(this.lblCompanyName);
            this.boxBaseInfo.Controls.Add(this.txtCompanyNameEnglish);
            this.boxBaseInfo.Controls.Add(this.lblCompanyNameEnglish);
            this.boxBaseInfo.Controls.Add(this.lblCompanyNO);
            this.boxBaseInfo.Controls.Add(this.txtCompanyNO);
            this.boxBaseInfo.Location = new System.Drawing.Point(15, 13);
            this.boxBaseInfo.Name = "boxBaseInfo";
            this.boxBaseInfo.Size = new System.Drawing.Size(458, 136);
            this.boxBaseInfo.TabIndex = 0;
            this.boxBaseInfo.TabStop = false;
            this.boxBaseInfo.Text = "基本信息";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(405, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompanyNORequired
            // 
            this.lblCompanyNORequired.ForeColor = System.Drawing.Color.Red;
            this.lblCompanyNORequired.Location = new System.Drawing.Point(330, 26);
            this.lblCompanyNORequired.Name = "lblCompanyNORequired";
            this.lblCompanyNORequired.Size = new System.Drawing.Size(15, 23);
            this.lblCompanyNORequired.TabIndex = 2;
            this.lblCompanyNORequired.Text = "*";
            this.lblCompanyNORequired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(144, 61);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(255, 23);
            this.txtCompanyName.TabIndex = 4;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Location = new System.Drawing.Point(14, 61);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(120, 23);
            this.lblCompanyName.TabIndex = 3;
            this.lblCompanyName.Text = "中文名称";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCompanyNameEnglish
            // 
            this.txtCompanyNameEnglish.Location = new System.Drawing.Point(144, 95);
            this.txtCompanyNameEnglish.Name = "txtCompanyNameEnglish";
            this.txtCompanyNameEnglish.Size = new System.Drawing.Size(255, 23);
            this.txtCompanyNameEnglish.TabIndex = 7;
            // 
            // lblCompanyNameEnglish
            // 
            this.lblCompanyNameEnglish.Location = new System.Drawing.Point(14, 95);
            this.lblCompanyNameEnglish.Name = "lblCompanyNameEnglish";
            this.lblCompanyNameEnglish.Size = new System.Drawing.Size(120, 23);
            this.lblCompanyNameEnglish.TabIndex = 6;
            this.lblCompanyNameEnglish.Text = "英文名称";
            this.lblCompanyNameEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompanyNO
            // 
            this.lblCompanyNO.Location = new System.Drawing.Point(14, 26);
            this.lblCompanyNO.Name = "lblCompanyNO";
            this.lblCompanyNO.Size = new System.Drawing.Size(120, 23);
            this.lblCompanyNO.TabIndex = 0;
            this.lblCompanyNO.Text = "公司代号";
            this.lblCompanyNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCompanyNO
            // 
            this.txtCompanyNO.Location = new System.Drawing.Point(144, 26);
            this.txtCompanyNO.Name = "txtCompanyNO";
            this.txtCompanyNO.Size = new System.Drawing.Size(180, 23);
            this.txtCompanyNO.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(337, 610);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 35);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(429, 610);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // CompanySingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 661);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabCompany);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CompanySingle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "公司信息";
            this.tabCompany.ResumeLayout(false);
            this.tabCompanyPage1.ResumeLayout(false);
            this.boxDescription.ResumeLayout(false);
            this.boxDescription.PerformLayout();
            this.boxOther.ResumeLayout(false);
            this.boxOther.PerformLayout();
            this.boxBaseInfo.ResumeLayout(false);
            this.boxBaseInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCompany;
        private System.Windows.Forms.TabPage tabCompanyPage1;
        private System.Windows.Forms.GroupBox boxBaseInfo;
        private System.Windows.Forms.Label lblCompanyNO;
        private System.Windows.Forms.TextBox txtCompanyNO;
        private System.Windows.Forms.Label lblCompanyNameEnglish;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyNameEnglish;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.GroupBox boxOther;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblRegistrationNumber;
        private System.Windows.Forms.TextBox txtLegalRepresentativeName;
        private System.Windows.Forms.TextBox txtRegistrationNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblLegalRepresentativeName;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox boxDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCompanyNORequired;
        private System.Windows.Forms.Label label1;
    }
}