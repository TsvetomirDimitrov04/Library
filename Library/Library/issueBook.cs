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
    public partial class issueBook : Form
    {
        public issueBook()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void issueBook_Load(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "library";
            string username = "root";
            string password = "programist";
            string connString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password;

            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            string queryString = "select bName from NewBooks";
            MySqlCommand command = new MySqlCommand(queryString, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    cmbBooks.Items.Add(reader.GetString(i));
                }
            }
            reader.Close();
            connection.Close();
        }
       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string eid = txtEnrollement.Text;
            string server = "localhost";
            string database = "library";
            string username = "root";
            string password = "programist";
            string connString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password;

            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            string queryString = "select * from addstudent where enroll = '"+eid+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(queryString, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);

            //code to count how many books are issued on this enroll number
            string queryString1 = "select count (std_enroll) from irbook where std_enroll = '" + eid + "' and book_return_date is null";
            MySqlDataAdapter da1 = new MySqlDataAdapter(queryString, connection);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            count1 = int.Parse(ds1.Tables[0].Rows[0][0].ToString());

            //--------------------------------------------------------------
            if (ds.Tables[0].Rows.Count != 0)
            {
              
                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtDepartment.Text = ds.Tables[0].Rows[0][3].ToString();
                txtSemester.Text = ds.Tables[0].Rows[0][4].ToString();
                txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
            }
            else
            {
                txtID.Clear();
                txtName.Clear();
                txtDepartment.Clear();
                txtSemester.Clear();
                txtContact.Clear();
                txtEmail.Clear();
                MessageBox.Show("Invalid Enrollement No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int count1;
        private void BtxIssueBook_Click(object sender, EventArgs e)
        {
            if (txtName.Text !="")
            {
                if (cmbBooks.SelectedIndex != -1 && count1 <= 2)
                {
                    int id = int.Parse(txtID.Text);
                    string enroll = txtEnrollement.Text;
                    string sname = txtEnrollement.Text;
                    string sdep = txtDepartment.Text;
                    string sem = txtSemester.Text;
                    Int64 contact = Int64.Parse(txtContact.Text);
                    string email = txtEmail.Text;
                    string bookname = cmbBooks.Text;
                    string bookIssueDate = dateTimePicker1.Text;

                    string eid = txtEnrollement.Text;
                    string server = "localhost";
                    string database = "library";
                    string username = "root";
                    string password = "programist";
                    string connString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password;

                    MySqlConnection connection = new MySqlConnection(connString);
                    connection.Open();
                    string queryString = "insert into irbook (id,std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date) values('" + id + "','" + enroll+ "','" + sname + "','" + sdep + "','" + sem + "','" + contact + "','" + email + "','" + bookname + "','" + bookIssueDate + "')";
                    MySqlCommand command = new MySqlCommand(queryString, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Book Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select book or maximum nuber of books has been issued.", "No book selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter valic Enrollement number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEnrollement_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollement.Text != "")
            {
                txtID.Clear();
                txtName.Clear();
                txtDepartment.Clear();
                txtSemester.Clear();
                txtContact.Clear();
                txtEmail.Clear();
            }
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
