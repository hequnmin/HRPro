namespace HR.Forms
{
    partial class DockEmployees
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
            this.employeesExplorer = new HR.Forms.Widgets.EmployeesExplorer();
            this.SuspendLayout();
            // 
            // employeesExplorer
            // 
            this.employeesExplorer.Company = null;
            this.employeesExplorer.Depts = null;
            this.employeesExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesExplorer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.employeesExplorer.Location = new System.Drawing.Point(0, 0);
            this.employeesExplorer.Margin = new System.Windows.Forms.Padding(4);
            this.employeesExplorer.Name = "employeesExplorer";
            this.employeesExplorer.Size = new System.Drawing.Size(265, 540);
            this.employeesExplorer.TabIndex = 0;
            // 
            // DockEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(265, 540);
            this.Controls.Add(this.employeesExplorer);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DockEmployees";
            this.Text = "员工浏览器";
            this.ResumeLayout(false);

        }

        #endregion

        private Widgets.EmployeesExplorer employeesExplorer;
    }
}