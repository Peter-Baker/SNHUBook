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
            if (username != "" && password != "")
            {
                if (password == MySQLFunctions.getPass(username))
                {
                    userInfo.setCurrentUser(MySQLFunctions.getUserIDFromEmail(username));
                    userInfo.setCurrentEmail(username);

                    this.Hide();
                    HomePage hPage = new HomePage();
                    hPage.Show();
                    MessageBox.Show("Should open page, without closing");
                }
                else
                {
                    MessageBox.Show("Email and password do not match");
                }
            }
            else
            {
                MessageBox.Show("Username or Password is empty!");
            }
        }
    }
}