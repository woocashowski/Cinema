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

        private void signinButton_Click(object sender, EventArgs e)
        {
            //string message = "Simple MessageBox";
            //MessageBox.Show(message);

            //loginBox
            string login = loginBox.Text;
            string password = PasswordBox.Text;

            cinema_dbDataSet.usersDataTable usersRows = new cinema_dbDataSet.usersDataTable();
            DataRow user = usersRows.FindByIdentyfikator(1);
            //MessageBox.Show();

            if (true)
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
