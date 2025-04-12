using System;
using System.Collections.Generic;
using System.Windows.Forms;

using HR.Core.Data;

namespace HR.Forms
{
    public partial class CompanySelector : Form
    {
        private List<Company> companys;
        public List<Company> Companys
        {
            get { return companys; }
            set { companys = value; }
        }

        private Company selectedCompany;

        public Company SelectedCompany
        {
            get { return selectedCompany; }
            set { selectedCompany = value; }
        }

        public CompanySelector()
        {
            InitializeComponent();

            this.Load += _Load;
            this.btnOK.Click += OK;
        }

        private void OK(object sender, EventArgs e)
        {
            object result = cmbCompany.SelectedItem;
        }

        private void _Load(object sender, EventArgs e)
        {
            cmbCompany.DataSource = companys;
            cmbCompany.DisplayMember = "CompanyText";
            cmbCompany.ValueMember = "CompanyID";
        }

    }
}
