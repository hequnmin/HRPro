namespace HR.Forms
{
    partial class DocumentWindow
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
            this.components = new System.ComponentModel.Container();
            this.menuOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuOptionClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptionCloseOther = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptionCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuOption
            // 
            this.menuOption.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOptionClose,
            this.menuOptionCloseOther,
            this.menuOptionCloseAll});
            this.menuOption.Name = "menuOption";
            this.menuOption.Size = new System.Drawing.Size(181, 92);
            // 
            // menuOptionClose
            // 
            this.menuOptionClose.Name = "menuOptionClose";
            this.menuOptionClose.Size = new System.Drawing.Size(180, 22);
            this.menuOptionClose.Text = "关闭";
            // 
            // menuOptionCloseOther
            // 
            this.menuOptionCloseOther.Name = "menuOptionCloseOther";
            this.menuOptionCloseOther.Size = new System.Drawing.Size(180, 22);
            this.menuOptionCloseOther.Text = "关闭其他";
            // 
            // menuOptionCloseAll
            // 
            this.menuOptionCloseAll.Name = "menuOptionCloseAll";
            this.menuOptionCloseAll.Size = new System.Drawing.Size(180, 22);
            this.menuOptionCloseAll.Text = "关闭所有";
            // 
            // DocumentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 586);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DocumentWindow";
            this.ShowIcon = false;
            this.Text = "DocumentWindow";
            this.menuOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip menuOption;
        private System.Windows.Forms.ToolStripMenuItem menuOptionClose;
        private System.Windows.Forms.ToolStripMenuItem menuOptionCloseOther;
        private System.Windows.Forms.ToolStripMenuItem menuOptionCloseAll;
    }
}