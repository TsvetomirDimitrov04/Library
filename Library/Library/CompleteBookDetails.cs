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
    public partial class CompleteBookDetails : Form
    {
        public CompleteBookDetails()
        {
            InitializeComponent();
        }

        private void CompleteBookDetails_Load(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "library";
            string username = "root";
            string password = "programist";
            string connString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password;

            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            string queryString = "select * from irbook where book_return_date is null";
            MySqlDataAdapter da = new MySqlDataAdapter(queryString, connection);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];


            MySqlConnection connection1 = new MySqlConnection(connString);
            string queryString1 = "select * from irbook where book_return_date is not null";
            MySqlDataAdapter da1 = new MySqlDataAdapter(queryString1, connection1);
            DataSet dt1 = new DataSet();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1.Tables[0];
        }
    }
}
