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
        private string pw;

        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string connectionString;
        private string port;
        private string sslM;

        public WelcomePage()
        {
            InitializeComponent();

            server = "localhost";
            database = "SNHUBook";
            user = "root";
            password = "Sword144";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode=Required", server, port, user, password, database, sslM);
        }

        private void conexion()
        {
            try
            {
                connection.Open();

                connection.Close();
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + connectionString);
            }
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
                if (password == getPass(username))
                {
                    userInfo.setCurrentUser(getUserIDFromEmail(username));
                    userInfo.setCurrentEmail(username);

                    this.Hide();
                    HomePage hPage = new HomePage();
                    hPage.Show();
                }
                else
                {
                    MessageBox.Show("Email and password do not match");
                }
            }
        }

        public static string getPass(string email)
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


            while (dr.Read())
            {
                storedPass = dr.GetString(0);
                Console.WriteLine(storedPass);
            }

            dr.Close();
            cnn.Close();


            return storedPass;
        }


        public static int getUserIDFromEmail(string email)
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd=Sword144;";
            cnn = new MySqlConnection(connectionString);

            string query = $"SELECT ID FROM accounts WHERE email LIKE '{email}';";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string userID = string.Empty;


            while (dr.Read())
            {
                userID = dr.GetString(0);
                Console.WriteLine(userID);
            }

            dr.Close();
            cnn.Close();


            return Convert.ToInt32(userID);
        }
    }
}