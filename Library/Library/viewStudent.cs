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
    public partial class viewStudent : Form
    {
        public viewStudent()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdStudent.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtEnroll.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDepartment.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSemester.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtContact.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id_student = int.Parse(txtIdStudent.Text);
            string sname = txtName.Text;
            string enroll = txtEnroll.Text;
            string dep = txtDepartment.Text;
            string sem = txtSemester.Text;
            Int64 contact = Int64.Parse(txtContact.Text);
            string email = txtEmail.Text;

            string server = "localhost";
            string database = "library";
            string username = "root";
            string password = "programist";
            string connString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password;

            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            string queryString = "update  addstudent set sname = '" + sname + "', enroll = '" + enroll + "', dep = '" + dep + "', sem= '" + sem + "', contact= '" + contact + "', email= '" + email + "' where id_student =" + id_student;
            MySqlDataAdapter da = new MySqlDataAdapter(queryString, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void viewStudent_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            string server = "localhost";
            string database = "library";
            string username = "root";
            string password = "programist";
            string connString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password;

            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            string queryString = "select * from addstudent";
            MySqlDataAdapter da = new MySqlDataAdapter(queryString, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id_student = int.Parse(txtIdStudent.Text);
            string sname = txtName.Text;
            string enroll = txtEnroll.Text;
            string dep = txtDepartment.Text;
            string sem = txtSemester.Text;
            Int64 contact = Int64.Parse(txtContact.Text);
            string email = txtEmail.Text;

            string server = "localhost";
            string database = "library";
            string username = "root";
            string password = "programist";
            string connString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password;

            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            string queryString = "delete from addstudent where id_student=" + id_student; ;
            MySqlCommand command = new MySqlCommand(queryString, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string queryString = "select * from addstudent";
            MySqlDataAdapter da = new MySqlDataAdapter(queryString, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
