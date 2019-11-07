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
            if (password != "" && username != "")
            {
                if (password == MySQLFunctions.getPass(username))
                {
                    this.Hide();
                    HomePage d = new HomePage();
                    d.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Account does not exist / Password is not correct");
                }
            }
        }
    }
}