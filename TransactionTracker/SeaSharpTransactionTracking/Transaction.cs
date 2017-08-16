/*
 * Durias Thomas
 * 2/22/2017
 * CIS 166
 * a class for the transaction object
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaSharpTransactionTracking
{
    public class Transaction
    {
        
        public Transaction()
        {
            //default values
        }


        public Transaction(decimal amount, DateTime transactionDate, string checkNumber, string payee, bool cleared, TransactionType type)
        {
            this.Amount = amount;
            this.TransactionDate = transactionDate;
            this.CheckNumber = checkNumber;
            this.Payee = payee;
            this.Cleared = cleared;
            this.Type = type;
        }
        /// <summary>
        /// Enum for the transaction type
        /// </summary>
        public enum TransactionType
        {
            Deposit = 0,
            Withdrawal = 1,
            ServiceFee = 2
        };

        private TransactionType type; 
        public TransactionType Type
        {

            get { return type; }

            set { type = value; }

        }
        //properties
        public decimal Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        public string CheckNumber { get; set; }

        public string Payee { get; set; }

        public bool Cleared { get; set; }
        

    }//end class
}//end namespace
