using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI.Docking;

namespace HRPro.Forms
{
    public partial class DocumentWindow : DockContent
    {
        public DocumentWindow()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;

            Customize();
        }

        private void Customize()
        {
            this.Load += _Load;
            this.menuOptionClose.Click += CloseCurrentDocument;
            this.menuOptionCloseOther.Click += CloseOtherDocuments;
            this.menuOptionCloseAll.Click += CloseAllDocuments;
        }

        private void _Load(object sender, EventArgs e)
        {
        }

        private void CloseCurrentDocument(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseAllDocuments(object sender, EventArgs e)
        {
            if (this.DockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                    form.Close();
            }
            else
            {
                foreach (IDockContent document in this.DockPanel.DocumentsToArray())
                {
                    document.DockHandler.DockPanel = null;
                    document.DockHandler.Close();
                }
            }

        }

        private void CloseOtherDocuments(object sender, EventArgs e)
        {
            if (this.DockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                    form.Close();
            }
            else
            {
                foreach (IDockContent document in this.DockPanel.DocumentsToArray())
                {
                    // IMPORANT: dispose all panes.
                    if (!document.DockHandler.IsActivated)
                    {
                        document.DockHandler.DockPanel = null;
                        document.DockHandler.Close();
                    }
                }
            }
        }

    }
}
