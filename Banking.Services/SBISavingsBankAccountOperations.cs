using Banking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Services
{
    public class SBISavingsBankAccountOperations : ISavingsAccountOperation
    {
        /// <summary>
        /// Deposit amount to user's Account
        /// </summary>
        /// <param name="account"></param>
        /// <param name="amount"></param>
        /// <returns>AccountHistory</returns>
        public AccountHistory DoCredit(SavingsBankAccount account, double amount)
        {
            var objAccountHist = new AccountHistory();
            try
            {
                account.CurrentBalance += amount;
                objAccountHist.AccountId = account.AccountId;
                objAccountHist.AccountOperationType = Models.Enums.AccountOperationType.Credit;
                objAccountHist.Amount = amount;
                objAccountHist.OperationTime = DateTime.Now;
                return objAccountHist;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public AccountHistory DoDebit(SavingsBankAccount account, double amount)
        {
            var objAccountHist = new AccountHistory();
            try
            {
                if (account.CurrentBalance > amount)
                {
                    account.CurrentBalance -= amount;
                    objAccountHist.AccountId = account.AccountId;
                    objAccountHist.AccountOperationType = Models.Enums.AccountOperationType.Debit;
                    objAccountHist.Amount = amount;
                    objAccountHist.OperationTime = DateTime.Now;
                    return objAccountHist;
                }
                else throw new Exception($"Account with number {account.AccountNumber} doesn't have enough funds.Account's current balance is {account.CurrentBalance}.");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
