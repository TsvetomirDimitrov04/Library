using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Add_Books : Form
    {
        public Add_Books()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtAuthor.Text != "" && txtBookPrice.Text != "" && txtPublication.Text != "" && txtQuantity.Text != "")
            {

                int id_book = int.Parse(txtIdBook.Text); 
                string bname = txtBookName.Text;
                string bauthor = txtAuthor.Text;
                string publication = txtPublication.Text;
                string pdate = dateTimePicker1.Text;
                Int64 price = Int64.Parse(txtBookPrice.Text);
                Int64 quan = Int64.Parse(txtQuantity.Text);

                string server = "localhost";
                string database = "library";
                string username = "root";
                string password = "programist";
                string connString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password;

                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();
                string queryString = "insert into NewBooks(id_book,bName, bAuthor, bPubl,bPDate,bPrice,bQuan)   value ('"+id_book+"','" + bname + "','" + bauthor + "','" + publication + "','" + pdate + "','"
                    + price + "','" + quan + "')";
                MySqlCommand command = new MySqlCommand(queryString, connection);
                MySqlDataReader reader = command.ExecuteReader();

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdBook.Clear();
                txtBookName.Clear();
                txtAuthor.Clear();
                txtBookPrice.Clear();
                txtPublication.Clear();
                txtQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Empty Failed NOT Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
