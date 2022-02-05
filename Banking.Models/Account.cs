using Banking.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Models
{
    public partial class Account
    {
        public int BankId { get; set; }
        public int BranchId { get; set; }
        public Customer Customer { get; set; }
        public int AccountNumber { get; set; }
        public int AccountId { get; set; }
        public DateTime DateOfOpening { get; set; }
        public DateTime LastTransacation { get; set; }
        public AccountType AccountType { get; set; }
    }

    public class SavingsBankAccount : Account
    {
        public SavingsAccountType SavingsAccountType { get; set; }
        public double SavingsInterestRate { get; set; }
        public double OpeningBalance { get; set; }
        public double CurrentBalance { get; set; }
        public List<AccountHistory> AccountHistory { get; set; }
    }

    /// <summary>
    /// History 
    /// </summary>
    public class AccountHistory
    {
        public int AccountId { get; set; }
        public AccountOperationType AccountOperationType { get; set; }
        public double Amount { get; set; }
        public DateTime OperationTime { get; set; }
    }
}
