using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordcountcost
{
    public partial class FrmWordCount : Form
    {
        public FrmWordCount()
        {
            InitializeComponent();
        }

        //Assume that the cost, not including tax, for sending a telegram from Hamilton to Montreal is $4.50 for the first twenty
        //words or less, plus $.17 for each additional word beyond twenty.Write a program which accepts the number of words
        //and then determines the total cost.


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        double words = 0;
        double result;
        string fullwords;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //caluclate cost of number of words entered in text box - as a number
            if (string.IsNullOrEmpty(txtfullwords.Text)){            
                words = double.Parse(txtWords.Text);
                if (words <= 20)
                {
                    result = 4.50;
                    string formattedMoneyValue = String.Format("{0:C2}", result);
                    lblResult.Text = "Cost of sending Telegram is " + formattedMoneyValue;
                    lblResult.Visible = true;
                }
                else if (words > 20)
                {
                    result = (words - 20) * 0.17 + (4.50);
                    string formattedMoneyValue = String.Format("{0:C2}", result);
                    lblResult.Text = "Cost of sending Telegram is " + formattedMoneyValue;
                    lblResult.Visible = true;
                }
            }
            else
            {
                //calculate number of words in text that has been written
                //words = double.Parse(txtfullwords.Text);
                int numberofwords = txtfullwords.Text.Length;

                if (numberofwords <= 20)
                {
                    result = 4.50;
                    string formattedMoneyValue = String.Format("{0:C2}", result);
                    lblResult.Text = "Cost of sending Telegram is " + formattedMoneyValue;
                    lblResult.Visible = true;
                }
                else if (numberofwords > 20)
                {
                    result = (numberofwords - 20) * 0.17 + (4.50);
                    string formattedMoneyValue = String.Format("{0:C2}", result);
                    lblResult.Text = "Cost of sending Telegram is " + formattedMoneyValue;
                    lblResult.Visible = true;
                }
            }
        }

        private void txtfullwords_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
