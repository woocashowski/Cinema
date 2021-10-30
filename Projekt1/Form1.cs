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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Decode passwords
        static string Caesar(string value, int shift)
        {
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                // Letter.
                char letter = buffer[i];
                // Add shift to all.
                letter = (char)(letter + shift);
                // Store.
                buffer[i] = letter;
            }
            return new string(buffer);
        }

        private void signinButton_Click(object sender, EventArgs e)
        {

            //loginBox
            string login = loginBox.Text;
            string password = PasswordBox.Text;

            cinema_dbDataSet.usersDataTable usersRows = new cinema_dbDataSet.usersDataTable();
            DataRow user = usersRows.FindByIdentyfikator(1);
            Console.WriteLine(user);
            Console.WriteLine("teeeest");
            //MessageBox.Show();
            bool isAdmin = true;
            if (isAdmin)
            {
                var frm = new AdminForm();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();
            }
            else
            {
                var frm = new ReservationForm();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            var frm = new SignUpForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        
    }
}