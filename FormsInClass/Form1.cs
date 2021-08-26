using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FormsInClass
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VaccineRegisterDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("INSERT INTO UserData(Surname, Firstname, Gender, Province) VALUES(@surname, @firstname, @gender, @province)", db);
            cmd.Parameters.AddWithValue("@surname", textBox2.Text);
            cmd.Parameters.AddWithValue("@firstname", textBox3.Text);
            cmd.Parameters.AddWithValue("@gender", textBox4.Text);
            cmd.Parameters.AddWithValue("@province", textBox5.Text);
            db.Open();
            cmd.ExecuteNonQuery();
            db.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
