using System;
using System.Collections.Generic;
using System.Windows.Forms;

using PetaPoco;
using AntsResource;
using HR.Core.Data;

namespace HR.Forms
{
    public partial class DeptSingle : Form
    {
        private Database database;
        public Database Database
        {
            get { return database; }
            set { database = value; }
        }


        private Company company;
        public Company Company
        {
            get { return company; }
            set 
            { 
                if (company != value)
                {
                    company = value;
                    LoadCompany();
                }
            }
        }

        private List<Dept> parents;
        public List<Dept> Parents
        {
            get { return parents; }
            set {
                if (parents != value)
                {
                    parents = value;
                    LoadParents();
                }
            }
        }


        private Dept parent;
        public Dept Parent
        {
            get { return parent; }
            set 
            { 
                if (parent != value)
                {
                    parent = value;
                    SelectParent(parent);
                }
            }
        }

        private Dept dept;
        public Dept Dept
        {
            get { return dept; }
            set { 
                if (dept != value)
                {
                    dept = value;
                    LoadDept();
                }
            }
        }


        public DeptSingle()
        {
            InitializeComponent();

            Customize();
        }

        public void Customize()
        {
            this.Load += _Load;
            this.btnOK.Click += (se, ea) => OK();
            this.btnCancel.Click += (se, ea) => Cancel();
        }

        private void _Load(object sender, EventArgs e)
        {

        }

        private void LoadCompany()
        {
            if (company != null)
            {
                cmbCompany.DataSource = new List<Company> { company };
                cmbCompany.DisplayMember = nameof(company.CompanyName);
                cmbCompany.ValueMember = nameof(company.CompanyID);
            }
        }

        private void LoadParents()
        {
            if (parents == null)
            {
                cmbParent.DataSource = null;
            }
            else
            {
                cmbParent.DataSource = parents;
                cmbParent.DisplayMember = nameof(parent.DeptFullName);
                cmbParent.ValueMember = nameof(parent.DeptID);
            }
        }

        private void SelectParent(Dept current)
        {
            if (current != null)
            {
                cmbParent.SelectedItem = current;
            }
        }

        private void LoadDept()
        {
            if (dept == null)
            {
                txtDeptNO.Text = string.Empty;
                txtDeptName.Text = string.Empty;
                txtSortNO.Text = string.Empty;
            }
            else
            {
                txtDeptNO.Text = dept.DeptNO;
                txtDeptName.Text = dept.DeptName;
                txtSortNO.Text = dept.SortNO;

                if (dept.Parent != null)
                {
                    cmbParent.SelectedItem = dept.Parent;
                }
            }

        }

        private bool Valid()
        {
            if (string.IsNullOrWhiteSpace(txtDeptName.Text))
            {
                MessageBox.Show($"{lblDeptName.Text} {Resources.__IsRequired}", Resources.WarningInformation, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void OK()
        {
            if (!Valid())
            {
                return;
            }
            try
            {
                if (dept == null)
                {
                    dept = new Dept()
                    {
                        DeptNO = txtDeptNO.Text,
                        DeptName = txtDeptName.Text,
                        SortNO = txtSortNO.Text,
                        Company = cmbCompany.SelectedItem as Company,
                        Parent = cmbParent.SelectedItem as Dept,
                    };
                    Depts.Create(database, dept);
                }
                else
                {
                    dept.DeptNO = txtDeptNO.Text;
                    dept.DeptName = txtDeptName.Text;
                    dept.SortNO = txtSortNO.Text;
                    dept.Company = cmbCompany.SelectedItem as Company;
                    dept.Parent = cmbParent.SelectedItem as Dept;

                    Depts.Update(database, dept, parent);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.ErrorInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void Cancel()
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
