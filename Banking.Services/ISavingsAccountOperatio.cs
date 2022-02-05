using Banking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Services
{
    public interface ISavingsAccountOperation
    {
        AccountHistory DoCredit(SavingsBankAccount account,double amount);
        AccountHistory DoDebit(SavingsBankAccount account, double amount);
    }
}
