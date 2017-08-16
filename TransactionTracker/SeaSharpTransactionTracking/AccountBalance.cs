/*
 * Durias Thomas
 * 2/22/2017
 * CIS 166
 * a class for an account balance
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaSharpTransactionTracking
{
    class AccountBalance
    {

        public AccountBalance()
        {
            //default values
        }

        public AccountBalance(decimal balance)
        {
            this.Balance = balance;
        }
        //properties
        public decimal Balance { get; set; }

       
    }//end class
}//end namespace
