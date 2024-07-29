using System;
using System.Data.SqlClient;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=VOID\\SQLEXPRESS;Initial Catalog=RegistrationForm;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string insertQuery = "INSERT INTO register VALUES (@fname, @lname, @dob, @gender, @email, @username, @password, @phone, @country)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@fname", txtfname.Text);
            cmd.Parameters.AddWithValue("@lname", txtlname.Text);
            cmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
            cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@country", txtCtry.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
