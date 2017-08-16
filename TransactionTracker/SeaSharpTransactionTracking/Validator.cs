using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Durias Thomas
 * Winter 2017
 * validator class
 */
namespace SeaSharpTransactionTracking
{
    class Validator
    {
        private static string title = "Entry Error";

        /// <summary>
        ///  checks if text is in a textbox
        /// </summary>
        public static bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", title);
                textBox.Focus();
                return false;
            }
            return true;
        }//end IsPresent method


        /// <summary>
        ///  checks if the text in a textbox is a decimal
        /// </summary>
        public static bool IsDecimal(TextBox textBox, string Name)
        {
            decimal number = 0m;
            if (decimal.TryParse(textBox.Text, out number))//checks to make sure that the value entered is a number
            {
                if(number >= 0)//checks that its a positive number
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(Name + " Must be a positive number.",
                "Entry Error");
                    textBox.Focus();
                }
            }
            else MessageBox.Show(Name + " Must be a Numeric Value.",
                "Entry Error");
            textBox.Focus();
            return false;
        }// End Method


        /// <summary>
        /// checks that the user picked a valid date in the datetime picker
        /// </summary>
        public static bool IsValidDate(DateTimePicker dtmPicker, string name)
        {
            DateTime today = DateTime.Today;
            DateTime dateEntered = dtmPicker.Value;
            if (dateEntered <= today)
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a today or an earlier date. ", title);
                dtmPicker.Focus();
                return false;
            }
        }//end IsValidDate method


        

    }//end class
}//end namespace
