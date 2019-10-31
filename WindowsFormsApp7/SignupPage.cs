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

namespace WindowsFormsApp7
{
    public partial class SignUp : Form
    {
        private int num;
        private string firstName;
        private string lastName;
        private string email;
        private string userPassword;
        private string server = "localhost";
        private string database = "SNHUBook";
        private string user = "root";
        private string password = "Sword144";
        private string port = "3306";
        private string sslM = "none";
        private MySqlConnection connection;

        public SignUp()
        {
            InitializeComponent();
        }

        private void firstname_textbox_TextChanged(object sender, EventArgs e)
        {
            //Add setting firstname string to the text inside the box.
            firstName = firstname_textbox.Text;
        }

        private void login_Click(object sender, EventArgs e)
        {
            WelcomePage a = new WelcomePage();
            a.Show();
            Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            
            signup a = new signup(email_textbox.Text, firstname_textbox.Text, lastname_textbox.Text, password_textbox.Text);
            a.firstname_check();
            a.lastname_check();
            a.Email();
            a.password_check();
            if (a.firstname_check() == true)
            {
                firstname_textbox.BackColor = Color.Green;
            }
            else if (a.firstname_check() == false)
            {
                firstname_textbox.BackColor = Color.Red;
            }

            if (a.lastname_check() == true)
            {
                lastname_textbox.BackColor = Color.Green;
            }
            else if (a.lastname_check() == false)
            {
                lastname_textbox.BackColor = Color.Red;
            }

            if (a.Email() == true)
            {
                email_textbox.BackColor = Color.Green;
            }
            else if (a.Email() == false)
            {
                email_textbox.BackColor = Color.Red;
            }
            if (a.password_check() == true)
            {
                password_textbox.BackColor = Color.Green;
            }
            else
            {
                password_textbox.BackColor = Color.Red;
            }

            //FUTURE ADD WAY TO 

                if (email_textbox.BackColor != Color.Red && firstname_textbox.BackColor != Color.Red && 
                    lastname_textbox.BackColor != Color.Red && password_textbox.BackColor != Color.Red)
                {
                    string connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode=Required", server, port, user, password, database, sslM);
                    connection = new MySqlConnection(connectionString);
                    //"INSERT INTO accounts (ID, FirstName, LastName, Email, Password) Values(1, 'Peter', 'Baker', 'pb0213@gmail.com', '1234')"
                    string tempString = "INSERT INTO accounts (FirstName, LastName, Email, Password) Values('";
                    tempString = tempString + firstName + "', '";
                    tempString = tempString + lastName + "', '";
                    tempString = tempString + email + "', '";
                    tempString = tempString + userPassword + "')";

                    //MessageBox.Show(tempString);
                    
                    MySqlCommand command = new MySqlCommand(tempString);
                    command.Connection = connection;
                    connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();

                a.save();
                    MessageBox.Show("You Successfully Signed Up! You May Now LogIn");
                    this.Hide();
                    WelcomePage o = new WelcomePage();
                    o.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Make Sure Everythings Valid and Submit again");
            }

        }

        private void lastname_textbox_TextChanged(object sender, EventArgs e)
        {
            //Add the lastname string being set to it. Like first name
            lastName = lastname_textbox.Text;
        }

        private void email_textbox_TextChanged(object sender, EventArgs e)
        {
            //set string
            email = email_textbox.Text;
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            //set string
            userPassword = password_textbox.Text;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}

