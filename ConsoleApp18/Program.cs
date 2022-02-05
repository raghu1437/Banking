using Banking.Models;
using Banking.Models.Enums;
using Banking.Services;
using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new Bank");

            try
            {
                //Create a new customer
                Customer objCustomer = new Customer()
                {
                    FirstName = "Raghu",
                    LastName = "Devualapalli",
                    ContactNumber = 9676025367,
                    ADHAARDetail = "xxxx",
                    EmailID = "raghuiram.d.s@gmail.com"
                };

                var objAccount = new SavingsBankAccount()
                {
                    Customer = objCustomer,
                    AccountId = 1,
                    AccountNumber = 1,
                    AccountType = AccountType.Savings,
                    SavingsAccountType = SavingsAccountType.Salaried,
                    BankId = 1,
                    BranchId = 1,
                    DateOfOpening = DateTime.Now,
                    OpeningBalance = 5000,
                    CurrentBalance=5000,
                    SavingsInterestRate = 2,
                    AccountHistory = null
                };

                ISavingsAccountOperation objAccountOps = new SBISavingsBankAccountOperations();
                var history = objAccountOps.DoCredit(objAccount, 10000);
                objAccount.AccountHistory = new System.Collections.Generic.List<AccountHistory>();
                objAccount.AccountHistory.Add(history);
                objAccount.AccountHistory.Add(objAccountOps.DoDebit(objAccount, 10000));
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }


    }


}
