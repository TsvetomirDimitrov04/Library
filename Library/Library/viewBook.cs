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
    public partial class viewBook : Form
    {
        public viewBook()
        {
            InitializeComponent();
        }

        private void viewBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            string server = "localhost";
            string database = "library";
            string username = "root";
            string password = "programist";
            string connString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password;

            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            string queryString = "select * from newBooks";
            MySqlDataAdapter da = new MySqlDataAdapter(queryString, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdBook.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBookName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAuthor.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPublication.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtQuantity.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();                    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
            
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id_book = int.Parse(txtIdBook.Text);
            string bname = txtBookName.Text;
            string bauthor = txtAuthor.Text;
            string publication = txtPublication.Text;
            string pdate = dateTimePicker1.Text;
            Int64 price = Int64.Parse(txtPrice.Text);
            Int64 quan = Int64.Parse(txtQuantity.Text);

            string server = "localhost";
            string database = "library";
            string username = "root";
            string password = "programist";
            string connString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password;

            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            string queryString = "update newBooks set bname = '"+bname+"', bAuthor = '"+bauthor+"', bPubl = '"+publication+"', bPDate= '"+pdate+"', bPrice= '"+price+"', bQuan= '"+quan+"' where id_book ="+id_book;
            MySqlDataAdapter da = new MySqlDataAdapter(queryString, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "library";
            string username = "root";
            string password = "programist";
            string connString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password;

            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            string queryString = "select * from newBooks";
            MySqlDataAdapter da = new MySqlDataAdapter(queryString, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id_book = int.Parse(txtIdBook.Text);
            string bname = txtBookName.Text;
            string bauthor = txtAuthor.Text;
            string publication = txtPublication.Text;
            string pdate = dateTimePicker1.Text;
            Int64 price = Int64.Parse(txtPrice.Text);
            Int64 quan = Int64.Parse(txtQuantity.Text);

            string server = "localhost";
            string database = "library";
            string username = "root";
            string password = "programist";
            string connString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password;

            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            string queryString = "delete from newBooks where id_book=" + id_book; ;
            MySqlCommand command = new MySqlCommand(queryString, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
