using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        string slotValue1;
        string slotValue2;
        string slotValue3;
        double totalWinnings = 0;
        double previousWinnings= 0;
        double totalBets = 0;
        double won = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private static readonly Random slotRandomizer = new Random();
        private int[] slotNumbers;

        private void spin_Click(object sender, EventArgs e)
        { if (amount.Text != ""){
            slotNumbers = new int[3];
            slotNumbers[0] = slotRandomizer.Next(0, 100);
            slotNumbers[1] = slotRandomizer.Next(0, 100);
            slotNumbers[2] = slotRandomizer.Next(0, 100);

            if (slotNumbers[0] <= 33 && slotNumbers[0] >= 0)
            {
                slotBox1.Image = Properties.Resources.cherry;
                slotValue1 = "cherry";
                slotBox1.Refresh();
                slotBox1.Visible = true;
            }
            else if (slotNumbers[0] >= 34 && slotNumbers[0] <= 66)
            {
                slotBox1.Image = Properties.Resources.orange;
                slotValue1 = "orange";
                slotBox1.Refresh();
                slotBox1.Visible = true;
            }
            else if (slotNumbers[0] >= 67 && slotNumbers[0] <= 100)
            {
                slotBox1.Image = Properties.Resources.strawberry;
                slotValue1 = "strawberry";
                slotBox1.Refresh();
                slotBox1.Visible = true;
            }

            if (slotNumbers[1] <= 33 && slotNumbers[1] >= 0)
            {
                slotBox2.Image = Properties.Resources.cherry;
                slotValue2 = "cherry";
                slotBox2.Refresh();
                slotBox2.Visible = true;
            }
            else if (slotNumbers[1] >= 34 && slotNumbers[1] <= 66)
            {
                slotBox2.Image = Properties.Resources.orange;
                slotValue2 = "orange";
                slotBox2.Refresh();
                slotBox2.Visible = true;
            }
            else if (slotNumbers[1] >= 67 && slotNumbers[1] <= 100)
            {
                slotBox2.Image = Properties.Resources.strawberry;
                slotValue2 = "strawberry";
                slotBox2.Refresh();
                slotBox2.Visible = true;
            }
            //Third slot box.  Figure out an image and a value to pop up based off of random number generation used above.
            if (slotNumbers[2] <= 33 && slotNumbers[2] >= 0)
            {
                slotBox3.Image = Properties.Resources.cherry;
                slotValue3 = "cherry";
                slotBox3.Refresh();
                slotBox3.Visible = true;
            }
            else if (slotNumbers[2] >= 34 && slotNumbers[2] <= 67)
            {
                slotBox3.Image = Properties.Resources.orange;
                slotValue3 = "orange";
                slotBox3.Refresh();
                slotBox3.Visible = true;
            }
            else if (slotNumbers[2] >= 68 && slotNumbers[2] <= 100)
            {
                slotBox3.Image = Properties.Resources.strawberry;
                slotValue3 = "strawberry";
                slotBox3.Refresh();
                slotBox3.Visible = true;
            }
            //Now, calculate the amount they've won, if any.  If they did not win, subtract the amount from total winnings.
            //If two of the values match, they win double their money, if it's three of the values that match, then they win 3x their money & if it's 1 or none, they lose their bet.
            double betAmount = Convert.ToDouble(amount.Text);
            totalBets = totalBets + betAmount;
            if (slotValue1 == "orange" && slotValue2 == "orange" && slotValue3 != "orange" || slotValue2 == "orange" && slotValue3 == "orange" && slotValue1 != "orange" || slotValue1 == "orange" && slotValue3 == "orange" && slotValue2 != "orange")
            {
                previousWinnings = totalWinnings;
                won = betAmount * 2;
                totalWinnings = won + previousWinnings;
                winnings.Text = "Amount Won: $" + won.ToString("N");
                totalWon.Text = "Total Amount Won: $"+ totalWinnings.ToString("N");
            }
            else if (slotValue1 == "strawberry" && slotValue2 == "strawberry" && slotValue3 != "strawberry" || slotValue2 == "strawberry" && slotValue3 == "strawberry" && slotValue1 != "strawberry" || slotValue1 == "strawberry" && slotValue3 == "strawberry" && slotValue2 != "strawberry")
            {
                previousWinnings = totalWinnings;
                won = betAmount * 2;
                totalWinnings = won + previousWinnings;
                winnings.Text = "Amount Won: $" + won.ToString("N");
                totalWon.Text = "Total Amount Won: $" + totalWinnings.ToString("N");
            }
            else if (slotValue1 == "cherry" && slotValue2 == "cherry" && slotValue3 != "cherry" || slotValue2 == "cherry" && slotValue3 == "cherry" && slotValue1 != "cherry" || slotValue1 == "cherry" && slotValue3 == "cherry" && slotValue2 != "cherry")
            {
                previousWinnings = totalWinnings;
                won = betAmount * 2;
                totalWinnings = won + previousWinnings;
                winnings.Text = "Amount Won: $" + won.ToString("N");
                totalWon.Text = "Total Amount Won: $" + totalWinnings.ToString("N");
            }
            else if (slotValue1 == "orange" && slotValue2 == "orange" && slotValue3 == "orange" || slotValue2 == "orange" && slotValue3 == "orange" && slotValue1 == "orange" || slotValue1 == "orange" && slotValue3 == "orange" && slotValue2 == "orange")
            {
                previousWinnings = totalWinnings;
                won = betAmount * 3;
                totalWinnings = won + previousWinnings;
                winnings.Text = "Amount Won: $" + won.ToString("N");
                totalWon.Text = "Total Amount Won: $" + totalWinnings.ToString("N");
            }
            else if (slotValue1 == "strawberry" && slotValue2 == "strawberry" && slotValue3 == "strawberry" || slotValue2 == "strawberry" && slotValue3 == "strawberry" && slotValue1 == "strawberry" || slotValue1 == "strawberry" && slotValue3 == "strawberry" && slotValue2 == "strawberry")
            {
                previousWinnings = totalWinnings;
                won = betAmount * 3;
                totalWinnings = won + previousWinnings;
                winnings.Text = "Amount Won: $" + won.ToString("N");
                totalWon.Text = "Total Amount Won: $" + totalWinnings.ToString("N");
            }
            else if (slotValue1 == "cherry" && slotValue2 == "cherry" && slotValue3 == "cherry" || slotValue2 == "cherry" && slotValue3 == "cherry" && slotValue1 == "cherry" || slotValue1 == "cherry" && slotValue3 == "cherry" && slotValue2 == "cherry")
            {
                previousWinnings = totalWinnings;
                won = betAmount * 3;
                totalWinnings = won + previousWinnings;
                winnings.Text = "Amount Won: $" + won.ToString("N");
                totalWon.Text = "Total Amount Won: $" + totalWinnings.ToString("N");
            }
            else
            {
                previousWinnings = totalWinnings -betAmount;
                won = 0- betAmount;
                totalWinnings = totalWinnings + won;
                winnings.Text = "Amount Won: -$" + betAmount.ToString("N");
                totalWon.Text = "Total Amount Won: $" + totalWinnings.ToString("N");
            }
        }
            else if (amount.Text == "")
            {
                MessageBox.Show("Please enter a valid bet amount.");
        }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //If they click exit, then show them what they've won/bet and ask if they really want to quit.
            DialogResult result = MessageBox.Show("Thanks for Playing! You've won $"+Convert.ToString(totalWinnings)+" and you've bet a total amount of $"+Convert.ToString(totalBets)+". Are you sure you want to quit?", "Exit?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keypress validation.  Only allow numeric entries for the bet amount.
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Please enter a valid numerical amount for your bet.  Please do not include the $ sign.");
            }
        }
    }
}
