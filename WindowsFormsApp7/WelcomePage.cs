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
using MySql.Data.MySqlClient;

namespace WindowsFormsApp7
{

    public partial class WelcomePage : Form
    {
        private string username;
        private string password;

        public WelcomePage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp a = new SignUp();
            a.ShowDialog();
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            password = textBox2.Text;
            textBox2.PasswordChar = '*';
        }

        private void login_bn_Click(object sender, EventArgs e)
        {
            HomePage d = new HomePage();
            d.Show();
        }

        public static string GenerateHash(string value, string salt)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(salt + value);
            data = System.Security.Cryptography.MD5.Create().ComputeHash(data);
            return Convert.ToBase64String(data);
        }

        public static string GetPass(string email)
        {

            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd=Sword144;";
            cnn = new MySqlConnection(connectionString);

            string query = $"SELECT password FROM accounts WHERE email LIKE '{email}';";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string storedPass = string.Empty;


            while (dr.Read()) {}
            else
            {
                MessageBox.Show("Username or Password is empty!");
            }
        }
    }
}