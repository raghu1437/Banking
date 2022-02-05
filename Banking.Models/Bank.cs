using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Models
{
    public class Bank
    {
        /// <summary>
        /// This is a unique BankId
        /// </summary>
        public int BankId { get; set; }
        /// <summary>
        /// This is the name of the Bank
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Address of the Bank
        /// </summary>
        public string Address { get; set; }
    }
}
