using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void revTxtBtn_Click(object sender, EventArgs e)
        {
            string input = revTxtStr.Text; //Gets the text from the user
            string newText = ""; // Creates a new string that will hold the reversed text
            char[] charArray = input.ToCharArray(); //Makes a character array to hold user input
            int length = input.Length; // Length of the user input

            for (int i = (length - 1); i >= 0; i--)
            {
                newText += charArray[i];
            }

            revTxtStr.Text = newText;

        }

        private void swtDigBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(swtDigX.Text); // Gets the user input as an int
                int y = int.Parse(swtDigY.Text);
                // Switching the inputs using only these two variables, as the instructions called for
                x += y;
                y = x - y;
                x -= y;
                swtDigX.Text = x.ToString();
                swtDigY.Text = y.ToString();
            }
            catch (Exception ex) { }; // No need to inform user of exception since input is obviouse. Try/Catch blocks being used for safty purposes incase the user forgets to add input
            
        }

        private void fndNumBtn_Click(object sender, EventArgs e)
        {
            string input = fndNumStr.Text; //Gets input from text box
            int count = 1; // This represents the amount of numbers found
            System.Text.RegularExpressions.MatchCollection results = System.Text.RegularExpressions.Regex.Matches(input, @"\d+"); // Reads the string as a regular expression and pulls out the numbers
            fndNumStr.Text = ""; // Sets the current text in the box to null
            foreach (System.Text.RegularExpressions.Match i in results) // Iterate through each regular expression
            {
                fndNumStr.AppendText(" Num " + count + "= " + i.Value);
                count++;
            }
        }
    }
}
