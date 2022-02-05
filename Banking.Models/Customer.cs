using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Models
{
    public partial class Customer
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public string EmailID { get; set; }
        public long ContactNumber { get; set; }
        public string PANNumber { get; set; }
        public string ADHAARDetail { get; set; }
        public string InternetBankingId { get; set; }
        public string InternetBankingPassword { get; set; }
        public string UPIId { get; set; }
        public string UPIPassword { get; set; }
        public string NomineeName { get; set; }
        public string DebitCardNumber { get; set; }
        public SavingsBankAccount SavingsBankAccount { get; set; }
    }
}
