/*
 By: Durias Thomas
 2/22/17
 CIS-166
An application for SEA-SHARP (Seattle-South Association of Retired Persons)
for tracking checking transactions. Allows the user to enter a transaction dollar amount,
specify the type of transaction (deposit, withdrawal, or service fee), and enter the date of the transaction. 
 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SeaSharpTransactionTracking
{
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
        }
        decimal dispayBalance = 0.0m;
        decimal enteredAmount;
        DateTime enteredDate;
        string checkNumber;
        string enteredPayee;
        bool didCheckClear;
        bool wasClearedButtonPressed = false;
        AccountBalance accountBalance = new AccountBalance();

        
        /// <summary>
        ///  allow the storing of
        ///  Transactions objects to grow as necessary
        /// </summary>
        Transaction transaction;
        public List<Transaction> transactionHistory = new List<Transaction>();

        //frmTransaction loads
        private void frmTransaction_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToShortDateString();//fill the label with the current date
            accountBalance.Balance = 1000.0m;//starting balance of 1000$
            dispayBalance = accountBalance.Balance;

            txtBnkBalance.Text = dispayBalance.ToString("c");//convert it to string/currency
            radDeposit.Checked = true;
            btnHistory.Enabled = false;
            btnChkClear.Enabled = false;
            /*
             open the file dialog when the form first opens 
            */
            
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                transactionHistory = TransactionFile.GetTransactions();
                AddItemsToListBox();
            }
        }
        //when the process button is pressed
        private void btnProcess_Click(object sender, EventArgs e)
        {
            
            if (ValidData())
            {

                ChangeEntriesToVariables();
                ProcessTransaction(enteredAmount);
                transactionHistory.Add(transaction);

                btnHistory.Enabled = true;
                btnChkClear.Enabled = true;
            }

        }//end process method

        //history button clicked event
        private void btnHistory_Click(object sender, EventArgs e)
        {
            AddItemsToListBox();//call method to fill listbox
            
        }//end history button

        //check cleared button click event
        private void btnChkClear_Click(object sender, EventArgs e)
        {

            DateTime today = DateTime.Today;
            DateTime enteredDate = transaction.TransactionDate;
            foreach (Transaction t in transactionHistory)
            {
                if(t.Cleared == false)
                {
                    if (t.Type.Equals(Transaction.TransactionType.Withdrawal))
                    {
                        t.Cleared = t.TransactionDate.AddDays(3) < today;
                    }
                }
                
                
                AddItemsToListBox();
            }
            wasClearedButtonPressed = true;

        }//end check clear

        //change the user entries to variables to work with
        private void ChangeEntriesToVariables()
        {
            enteredAmount = Convert.ToDecimal(txtAmount.Text);
            enteredDate = dtmPicker.Value;
            checkNumber = txtChkNumber.Text;
            enteredPayee = txtPayee.Text;
            
        }



        /// <summary>
        /// checks which of the radio buttons was selected then does the math based on that.
        /// changes font color to red if balance drops below 0;
        /// </summary>
        private void ProcessTransaction(decimal dollarAmount)
        {

            if (radDeposit.Checked == true)//deposit logic
            {
                transaction = new Transaction(enteredAmount, enteredDate, checkNumber, enteredPayee, didCheckClear, Transaction.TransactionType.Deposit);
                accountBalance.Balance = accountBalance.Balance + dollarAmount;
                dispayBalance = accountBalance.Balance;
                if (dispayBalance < 0)
                {
                    txtBnkBalance.ForeColor = Color.Red;
                }
                txtBnkBalance.Text = String.Format("{0:C}", dispayBalance);
                MessageBox.Show("Deposit of: " + dollarAmount.ToString("c") +
               " on " + dtmPicker.Value.ToShortDateString(), "Processing Activity");
            }
            else if (radServiceFee.Checked == true)// service fee logic
            {
                transaction = new Transaction(enteredAmount, enteredDate, checkNumber, enteredPayee, didCheckClear, Transaction.TransactionType.ServiceFee);
                accountBalance.Balance = accountBalance.Balance - dollarAmount;
                dispayBalance = accountBalance.Balance;
                if (dispayBalance < 0)
                {
                    txtBnkBalance.ForeColor = Color.Red;
                }
                txtBnkBalance.Text = String.Format("{0:C}", dispayBalance);
                MessageBox.Show("Serfice Fee Payment of: " + dollarAmount.ToString("c") +
                " on " + dtmPicker.Value.ToShortDateString(), "Processing Activity");
            }
            else if (radWithdrawal.Checked == true)//withdrawal logic
            {
                transaction = new Transaction(enteredAmount, enteredDate, checkNumber, enteredPayee, didCheckClear, Transaction.TransactionType.Withdrawal);
                accountBalance.Balance = accountBalance.Balance - dollarAmount;
                dispayBalance = accountBalance.Balance;
                if (dispayBalance < 0)
                {
                    txtBnkBalance.ForeColor = Color.Red;
                }
                txtBnkBalance.Text = String.Format("{0:C}", dispayBalance);
                MessageBox.Show("Withdrawal of: " + dollarAmount.ToString("c") +
                " on " + dtmPicker.Value.ToShortDateString(), "Processing Activity");
            }

            
        }//end Process transaction


        /// <summary>
        /// method to add items to the list box
        /// </summary>
        public void AddItemsToListBox()
        {
            lstBoxHistory.Items.Clear();
            
            foreach (Transaction t in transactionHistory)
            {
                lstBoxHistory.Items.Add("Payee: " + t.Payee);
                lstBoxHistory.Items.Add("Dollar Amount: " + t.Amount.ToString("c"));
                lstBoxHistory.Items.Add("CheckNumber: " + t.CheckNumber);
                lstBoxHistory.Items.Add("Did Check Clear: " + t.Cleared);
                lstBoxHistory.Items.Add("Transaction Date: " + t.TransactionDate.ToShortDateString());
                lstBoxHistory.Items.Add("******************************");
                
            }
              
        }//end  add items to list

        
        
        /// <summary>
        /// verifies that the use selected a valid radio button then verifies that the user put in valid information
        /// </summary>
        private bool ValidData()
        {

            if (ValidRadButton())
            {
                if (radDeposit.Checked == true)
                {
                    if ((Validator.IsDecimal(txtAmount, "Amount")) && (Validator.IsValidDate(dtmPicker, "Date")))
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
                else if (radServiceFee.Checked == true)
                {
                    if ((Validator.IsDecimal(txtAmount, "Amount")) && (Validator.IsValidDate(dtmPicker, "Date")))
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
                else if (radWithdrawal.Checked == true)
                {
                    if ((Validator.IsDecimal(txtAmount, "Amount")) && (Validator.IsValidDate(dtmPicker, "Date")) &&
                    (Validator.IsPresent(txtPayee, "Payee")) && (Validator.IsPresent(txtChkNumber, "Check Number")))
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }



                if ((Validator.IsDecimal(txtAmount, "Amount")) && (Validator.IsValidDate(dtmPicker, "Date")) &&
                    (Validator.IsPresent(txtPayee, "Payee")) && (Validator.IsPresent(txtChkNumber, "Check Number")))
                {
                    return true;
                }
               
                else
                {
                    return false;
                }
                 
            }
            else
            {
                return false;
            }

        }//end validData

        /// <summary>
        /// verifies the user selected a radio button
        /// </summary>
        private bool ValidRadButton()
        {

            if (radDeposit.Checked == true)
            {
                return true;
            }
            else if (radServiceFee.Checked == true)
            {
                return true;
            }
            else if (radWithdrawal.Checked == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show(" You must select a transaction type");
                return false;
            }
             
        }//end ValidRadButton














        /// <summary>
        ///             3 methods that change the textboxes based on radio button option
        /// </summary>
        private void radDeposit_CheckedChanged(object sender, EventArgs e)
        {
            txtPayee.Enabled = false;
            txtChkNumber.Enabled = false;
            txtPayee.Text = "Deposit";
            txtChkNumber.Text = null;
        }

        private void radServiceFee_CheckedChanged(object sender, EventArgs e)
        {
            txtPayee.Enabled = false;
            txtChkNumber.Enabled = false;
            txtPayee.Text = "Service Fee";
            txtChkNumber.Text = null;
        }

        private void radWithdrawal_CheckedChanged(object sender, EventArgs e)
        {
            txtPayee.Enabled = true;
            txtChkNumber.Enabled = true;
            txtPayee.Text = null;
            txtChkNumber.Text = null;
        }
        /// <summary>
        ///             ^^^ end radio button methods
        /// </summary>
       

        //close the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            radDeposit.Checked = true;
            radServiceFee.Checked = false;
            radWithdrawal.Checked = false;
            txtAmount.Text = null;
            txtPayee.Text = null;
            txtChkNumber.Text = null;
            DateTime today = DateTime.Today;
            dtmPicker.Value = today;
            lstBoxHistory.Items.Clear();
            transactionHistory.Clear();
            accountBalance.Balance = 1000m;
            dispayBalance = 1000m;
            txtBnkBalance.Text = String.Format("{0:C}", dispayBalance);
        }
       
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            lstBoxHistory.Items.Clear();
            transactionHistory.Clear();
            accountBalance.Balance = 1000m;
            dispayBalance = 1000m;
            txtBnkBalance.Text = String.Format("{0:C}", dispayBalance);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxHelp HelpBox = new AboutBoxHelp();
            HelpBox.Show();
            
        }
        //closes the form. wired so that either button or menu option can be clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(wasClearedButtonPressed == true)
            {
                
                DialogResult dR = MessageBox.Show("Save your transaction history?", "Saving File...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dR == DialogResult.OK)
                {
                    DialogResult result = saveFileDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        TransactionFile.SaveTransactions(transactionHistory);
                        this.Close();
                    }
                    
                    
                }
                else
                {
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("You must see if your checks cleared before closing the app.", "Finalization Error");
            }
            
        }
    }//end class
}//end namespace
