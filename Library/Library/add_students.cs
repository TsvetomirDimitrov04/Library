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
    public partial class add_students : Form
    {
        public add_students()
        {
            InitializeComponent();
        }

        private void add_students_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIDStudent.Clear();
            txtStudentName.Clear();
            txtSemester.Clear();
            txtNumber.Clear();
            txtEmail.Clear();
            txtDepartment.Clear();
            txtContact.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text != "" && txtSemester.Text != "" && txtNumber.Text != "" && txtEmail.Text != "" && txtDepartment.Text != "" && txtContact.Text!="")
            {
                int id_student = int.Parse(txtIDStudent.Text);
            string sname = txtStudentName.Text;
            string enroll = txtNumber.Text;
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
            string queryString = "insert into addstudent(id_student,sname, enroll, dep,sem,contact,email)   value ('" + id_student + "','" + sname + "','" + enroll + "','" + dep + "','" + sem + "','"
                + contact + "','" + email + "')";
            MySqlCommand command = new MySqlCommand(queryString, connection);
            MySqlDataReader reader = command.ExecuteReader();

            MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDStudent.Clear();
            txtStudentName.Clear();
            txtSemester.Clear();
            txtNumber.Clear();
            txtEmail.Clear();
            txtDepartment.Clear();
            txtContact.Clear();
        }
            else
            {
                MessageBox.Show("Empty Failed NOT Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}
    }
}
