using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class signInForm : Form
    {
        public signInForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username1 = txtUsername.Text;
            string pass = txtPassword.Text;

            string server = "localhost";
            string database = "library";
            string username = "root";
            string password = "programist";
            string connString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password;

            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            string queryString = "insert into logintable(username,pass)   value ('" + username1 + "','" + pass + "')";
            MySqlCommand command = new MySqlCommand(queryString, connection);
            MySqlDataReader reader = command.ExecuteReader();
            MessageBox.Show("You have been SIGNED IN","Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
