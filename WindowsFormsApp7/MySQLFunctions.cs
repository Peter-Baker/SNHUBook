using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp7
{
    class MySQLFunctions
    {
        public const string MYSQLPassword = "Caelarules1!"; //Enter your own password here to log into your own database

        public MySQLFunctions()
        {

        }

        public static void SQLCommand(string command)
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;port=3306;user id=root; password={MYSQLPassword}; database=SNHUBook;";
            cnn = new MySqlConnection(connectionString);

            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = command;
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

                MySqlErrorMessage(ex.Number);

                throw new System.ArgumentException("Error: " + ex);
            }
            cnn.Close();

        }

        public static void MySqlErrorMessage(int errorNum)
        {
            switch (errorNum)
            {
                case 1062:
                    MessageBox.Show("This email or ID is already in use");
                    break;
                default:
                    MessageBox.Show("There was an unknown error");
                    break;
            }
        }

        public static string getPass(string email)
        {

            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
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
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
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
