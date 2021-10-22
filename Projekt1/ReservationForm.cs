using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt1
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
            // green - avaible
            // gray - not avaible
            // orange - your choice

            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.BackColor != Color.Orange)
                {
                    button.BackColor = Color.Orange;
                }
                else
                {
                    button.BackColor = Color.Green;
                }
            }

        }

        private void button_Click(string which)
        {

            Button button = new Button();

            if (which=="1")
            {
                button = button1;
            }
            else if (which == "2")
            {
                button = button2;
            }
            else if (which == "3")
            {
                button = button3;
            }
            else if (which == "4")
            {
                button = button4;
            }
            else if (which == "5")
            {
                button = button5;
            }
            else if (which == "6")
            {
                button = button6;
            }
            else if (which == "7")
            {
                button = button7;
            }
            else if (which == "8")
            {
                button = button8;
            }
            else if (which == "9")
            {
                button = button9;
            }
            else if (which == "10")
            {
                button = button10;
            }
            else if (which == "11")
            {
                button = button11;
            }
            else if (which == "12")
            {
                button = button12;
            }
            else if (which == "13")
            {
                button = button13;
            }
            else if (which == "14")
            {
                button = button14;
            }
            else if (which == "15")
            {
                button = button15;
            }

            if (button.BackColor != Color.Orange)
            {
                button.BackColor = Color.Orange;
            }
            else
            {
                button.BackColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_Click("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_Click("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_Click("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_Click("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_Click("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_Click("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_Click("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_Click("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_Click("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button_Click("10");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button_Click("11");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button_Click("12");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button_Click("13");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button_Click("14");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button_Click("15");
        }
    }
}
