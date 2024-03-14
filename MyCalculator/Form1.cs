using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {   
        double enterFirstVal, enterSecondVal;   // Both have a value of 0
        String usedOperator;

        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;    // Sent it straight ot the button

            // Here it checks if the current text in the Textbox is "0", if so it clears the text by setting it to an empty string to avoid adding digits to zero. 
            // Once that happend the current state of the subsequent button presses are handled on the current state of the Textbox
            if (resultTxt.Text == "0")
                resultTxt.Clear();
            {
                if (num.Text == ",")    // IF the button for decimal is pressed 
                {
                    if (!resultTxt.Text.Contains(",")) // IF the text in the box does not contain decimal then add decimal behind the current text
                    {
                        resultTxt.Text = resultTxt.Text + ","; // Adds the decimal point behind the number
                    }
                }
                else    // Otherwise keep adding numbers behind it
                {
                    resultTxt.Text += num.Text;
                }
            }
        }

        private void numberOperator(object sender, EventArgs e)
        {
            // Creating an object for the pressed button of operators
            Button pressedOperator = (Button)sender;

            if (resultTxt.Text != "0" && resultTxt.Text != ",")
            {
                // Get the first value from the textbox 
                // Even after pressing equal for solution which the solution will be set in the Textbox
                // Once pressing the operator again will take that value to assign to the first value
                enterFirstVal = Convert.ToDouble(resultTxt.Text);
                // Get the operator from the textbox
                usedOperator = pressedOperator.Text;
                // Once the operator pressed clear the textbox to get the second value
                resultTxt.Clear();
            }
        }

        private void equalPressed(object sender, EventArgs e)
        {
            double solution = 0;
            // If the first value contains something except to zero do
            if (enterFirstVal != 0)
            {
                // Get the second value
                enterSecondVal = Convert.ToDouble(resultTxt.Text);
                
                    // Using a switch to check for all the operators
                switch (usedOperator)
                {
                    case "+":
                        solution = enterFirstVal + enterSecondVal;
                        break;
                    case "-":
                        solution = enterFirstVal - enterSecondVal;
                        break;
                    case "X":
                        solution = enterFirstVal * enterSecondVal;
                        break;
                    case "/":
                        solution = enterFirstVal / enterSecondVal;
                        break;

                    default:
                        break;
                }
                
                // Add the text in the textbox
                resultTxt.Text = solution.ToString();
            }
        }
        // Clear the Text back to zero
        private void clearGlobalBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Text = "0";   // Clear the textbox
            enterFirstVal = 0;  // Then it checks the statement to have a second value which the first value n
            usedOperator = null; // Clear the operator sign
        }

        private void clearEntryBtn_Click(object sender, EventArgs e)
        {
            // This will just clear the textbox keeping the remaining value
            resultTxt.Text = "0";
        }

        private void backspaceBtn_Click(object sender, EventArgs e)
        {

            if (resultTxt.Text.Length > 1) // Keep removing characters as long the string is bigger then 1
            {
                resultTxt.Text = resultTxt.Text.Substring(0, resultTxt.Text.Length - 1);
            }
            else if (resultTxt.Text.Length == 1)
            {
                resultTxt.Text = "0";
            }
        }

        private void absoluteBtn_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text != "0") // If it is zero does not matter if its a positive or negative value
            {
                double abs = Convert.ToDouble(resultTxt.Text);
                // This will change the current value to pos or negative
                resultTxt.Text = Convert.ToString(-1 * abs);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
