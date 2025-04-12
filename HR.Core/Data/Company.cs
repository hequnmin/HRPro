using System;
using System.Collections.Generic;

using PetaPoco;

namespace HR.Core.Data
{
    [TableName("company")]
    [PrimaryKey("companyid", AutoIncrement = true)]
    public class Company
    {
        [Column(Name = "companyid")]
        public int CompanyID { get; set; }

        [Column(Name = "companyno")]
        public string CompanyNO { get; set; }

        [Column(Name = "companyname")]
        public string CompanyName { get; set; }

        [Column(Name = "companynameenglish")]
        public string CompanyNameEnglish { get; set; }

        [Column(Name = "address")]
        public string Address { get; set; }

        [Column(Name = "website")]
        public string Website { get; set; }

        [Column(Name = "registrationnumber")]
        public string RegistrationNumber { get; set; }

        [Column(Name = "legalrepresentativename")]
        public string LegalRepresentativeName { get; set; }

        [Column(Name = "phone")]
        public string Phone { get; set; }

        [Column(Name = "email")]
        public string Email { get; set; }

        [Column(Name = "founded")]
        public DateTime Founded { get; set; }

        [Column(Name = "description")]
        public string Description { get; set; }

        public Company() { 
        }

    }
}
