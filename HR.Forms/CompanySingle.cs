using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PetaPoco;
using AntsResource;
using HR.Core.Data;
using HR.Core.Entity;

namespace HR.Forms
{
    public partial class CompanySingle : Form
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
            set { company = value; }
        }



        public CompanySingle()
        {
            InitializeComponent();
            Customize();
        }

        private void Customize()
        {
            this.Load += _Load;
            this.btnOK.Click += (se, ea) => OK();
            this.btnClose.Click += (se, ea) => Cancel();
        }

        private void _Load(object sender, EventArgs e)
        {
            if (company != null)
            {
                txtCompanyNO.Text = company.CompanyNO;
                txtCompanyName.Text = company.CompanyName;
                txtCompanyNameEnglish.Text = company.CompanyNameEnglish;

                txtPhone.Text = company.Phone;
                txtEmail.Text = company.Email;
                txtAddress.Text = company.Address;
                txtWebsite.Text = company.Website;
                txtRegistrationNumber.Text = company.RegistrationNumber;
                txtLegalRepresentativeName.Text = company.LegalRepresentativeName;
                txtDescription.Text = company.Description;

            }
        }

        private bool Valid()
        {
            if (string.IsNullOrWhiteSpace(txtCompanyNO.Text))
            {
                MessageBox.Show($"{lblCompanyNO.Text} {Resources.__IsRequired}", Resources.WarningInformation, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
            {
                MessageBox.Show($"{lblCompanyName.Text} {Resources.__IsRequired}", Resources.WarningInformation, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (company == null)
                {
                    company = new Company()
                    {
                        CompanyNO = txtCompanyNO.Text,
                        CompanyName = txtCompanyName.Text,
                        CompanyNameEnglish = txtCompanyNameEnglish.Text,
                        Phone = txtPhone.Text,
                        Email = txtEmail.Text,
                        Address = txtAddress.Text,
                        Website = txtWebsite.Text,
                        RegistrationNumber = txtRegistrationNumber.Text,
                        LegalRepresentativeName = txtLegalRepresentativeName.Text,
                        Description = txtDescription.Text,
                    };
                    database.Insert(company);
                }
                else
                {
                    company.CompanyNO = txtCompanyNO.Text;
                    company.CompanyName = txtCompanyName.Text;
                    company.CompanyNameEnglish = txtCompanyNameEnglish.Text;
                    company.Phone = txtPhone.Text;
                    company.Email = txtEmail.Text;
                    company.Address = txtAddress.Text;
                    company.Website = txtWebsite.Text;
                    company.RegistrationNumber = txtRegistrationNumber.Text;
                    company.LegalRepresentativeName = txtLegalRepresentativeName.Text;
                    company.Description = txtDescription.Text;

                    database.Update(company);

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
            this.DialogResult= DialogResult.Cancel;
        }

    }
}
