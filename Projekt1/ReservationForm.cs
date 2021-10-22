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

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != Color.Orange)
            {
                button1.BackColor = Color.Orange;
            }
            else
            {
                button1.BackColor = Color.Green;
            }
        }

    }
}
