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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void add_User(string name, string login, string password, string surname, bool worker)
        {
            cinema_dbDataSet.usersDataTable users = new cinema_dbDataSet.usersDataTable();
            users.AddusersRow(name, login, password, surname, worker);
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string surname = surnameBox.Text;
            string login = loginBox.Text;
            string password = passwordBox.Text;

            int length1 = name.Length;
            int length2 = surname.Length;
            int length3 = login.Length;
            int length4 = password.Length;

            

            if (length1 > 0 &&
                length2 > 0 &&
                length3 > 0 &&
                length4 > 0)
            {
                // Funkcja dodająca użytkownika do bazy
                add_User(name, login, password, surname, false);
                MessageBox.Show("Rejestracja zakończona");
            }
            else
            {
                MessageBox.Show("Rejestracja nieudana");
            }
            
        }

        


        private void backButton_Click(object sender, EventArgs e)
        {
            var frm = new LoginForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
