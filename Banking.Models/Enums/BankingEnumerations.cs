using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Models.Enums
{
    public enum AccountType
    {
        Savings,
        Current,
        FD,
        OverDraft,
        Loan
    }

    public enum SavingsAccountType
    {
        Salaried,
        Self,
        Joint
    }

    public enum AccountOperationType
    {
        Debit,
        Credit,
        Foreclosure,
        NewLoan
    }
}
