/*
 *Durias Thomas
 *CIS 166
 *3/4/2017
 * TransactionFile class
 * Uses IO streams
 * FileStreams are buffered by default
 * Represents sequential data access
 * The design of the System.IO classes provides simplified stream composing
 * Base streams can be attached to one or more pass-through streams that provide
 * the functionality you want. A reader or writer can be attached to the end of 
 * the chain so that the preferred types can be read or written easily
 * FileMode Enumeration (Append,Create,CreateNew,Open,OpenOrCreate,Truncate)
 * FileAccess Enumeration (Read,ReadWrite,Write)
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaSharpTransactionTracking
{

    public static class TransactionFile
    {
        private const string dir = @"G:\School\CIS 166-BusObjects\Class Files\Week8-9\Homework\"; 
        private const string path = dir + "Transaction.txt";

        public static void SaveTransactions(List<Transaction> transactions)
        {
            

            StreamWriter textOut = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));


            // write each customer field to the text file separating them using a split vertical bar |
            // include an <eoln>
            foreach (Transaction t in transactions)
            {
                //write to the file
                textOut.Write(t.TransactionDate.ToString() + "|");
                textOut.Write(t.Amount.ToString() + "|");
                textOut.Write(t.Payee + "|");
                textOut.Write(t.CheckNumber + "|");
                textOut.WriteLine(t.Cleared); 

            }

            
            textOut.Close();  //closes the current StreamWriter object
        }//end save transaction


        public static List<Transaction> GetTransactions()
        {
           
            // if the directory doesn't exist, create it
            if (!Directory.Exists(dir))         //determines whether given path refers to an existing directory on disk
                Directory.CreateDirectory(dir); //creates all the directories in a specified path

            // create the object for the input stream for a text file (file mode is open or create, file access is read)
            //CODE HERE to create a "chain" instantiation of a FileStream and Streamreader for input
            StreamReader textIn =
                new StreamReader(                   //open or create with avoid errors by trying to open a file that doesnt exist
                    new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            // create the array list for customers read from file
            List<Transaction> transactions = new List<Transaction>();
            string amount;
            string clear;
            string date;
            // read the data from the file and store it in the ArrayList
            //CODE HERE to make sure the file has data (use Peek method)
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                /*
                 * Split - returns a string array that contains the substrings in this instance 
                 * that are delimited by elements of a specified string or Unicode character array
                 */
                string[] columns = row.Split('|');
                Transaction transaction = new Transaction();  //new customer object


                date = columns[0];
                transaction.TransactionDate = Convert.ToDateTime(date);
                amount = columns[1];
                transaction.Amount = Convert.ToDecimal(amount);
                transaction.Payee = columns[2];
                transaction.CheckNumber = columns[3];
                clear = columns[4];
                transaction.Cleared = Convert.ToBoolean(clear);
                
               

                transactions.Add(transaction);
            }

            textIn.Close();
            return transactions;
        }


    }//end class

}//end namespace
