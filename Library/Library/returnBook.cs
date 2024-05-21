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
    public partial class returnBook : Form
    {
        public returnBook()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "library";
            string username = "root";
            string password = "programist";
            string connString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password;

            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            string queryString = "select * from irbook where std_enroll = '" + txtEnrollement.Text + "' and book_return_date is NULL";
            MySqlDataAdapter da = new MySqlDataAdapter(queryString, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count !=0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string bname;
        string bdate;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtName.Text = bname;
            txtIssueDate.Text = bdate;
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
            string queryString = "update irbook set book_return_date = '"+dateTimePicker1.Text+"' where std_enroll ='"+txtEnrollement.Text+"' and id = '"+rowid+"' ";
            MySqlCommand command = new MySqlCommand(queryString, connection);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Return Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        returnBook_Load(this, null);
        }

        private void returnBook_Load(object sender, EventArgs e)
        {
            txtEnrollement.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {    
            dataGridView1.DataSource = null;
            txtEnrollement.Clear();
        }
    }
}
