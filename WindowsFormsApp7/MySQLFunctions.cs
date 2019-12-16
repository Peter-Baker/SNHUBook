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
        public const string MYSQLPassword = "Sword144"; //Enter your own password here to log into your own database

        public const string pathForResources = @"C:\Users\peter\Desktop\WindowsFormsApp7\WindowsFormsApp7\Resources\"; //Enter in your path of the resource folder here

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

        public static string getProfileImage(string email) //Returns entire path
        {

            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string query = $"SELECT profImage_path FROM accounts WHERE email LIKE '{email}';";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string storedProfPath = string.Empty;


            while (dr.Read())
            {
                storedProfPath = dr.GetString(0);
                Console.WriteLine(storedProfPath);
            }

            dr.Close();
            cnn.Close();


            return pathForResources + storedProfPath;
        }

        public static string getBackgroundImage(string email) //Returns entire path
        {

            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string query = $"SELECT backgroundImage_path FROM accounts WHERE email LIKE '{email}';";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string storedProfPath = string.Empty;


            while (dr.Read())
            {
                storedProfPath = dr.GetString(0);
                Console.WriteLine(storedProfPath);
            }

            dr.Close();
            cnn.Close();


            return pathForResources + storedProfPath;
        }

        public static void changePassword(string email, string password)
        {
            SQLCommand($"UPDATE accounts set Password = '{password}' where email = '{email}';");
        }

        public static string getName(string email)
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string query = $"SELECT FirstName FROM accounts WHERE email LIKE '{email}';";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string firstName = string.Empty;


            while (dr.Read())
            {
                firstName = dr.GetString(0);
                Console.WriteLine(firstName);
            }

            dr.Close();
            cnn.Close();

            query = $"SELECT LastName FROM accounts WHERE email LIKE '{email}';";

            MySqlCommand cmdTwo = new MySqlCommand(query, cnn);

            MySqlDataReader drTwo;

            cnn.Open();
            drTwo = cmdTwo.ExecuteReader();

            string lastName = string.Empty;


            while (drTwo.Read())
            {
                lastName = drTwo.GetString(0);
                Console.WriteLine(lastName);
            }

            drTwo.Close();
            cnn.Close();

            return firstName + " " + lastName;
        }

        public static string getName(int ID)
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string query = $"SELECT FirstName FROM accounts WHERE ID LIKE '{ID}';";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string firstName = string.Empty;


            while (dr.Read())
            {
                firstName = dr.GetString(0);
                Console.WriteLine(firstName);
            }

            dr.Close();
            cnn.Close();

            query = $"SELECT LastName FROM accounts WHERE ID LIKE '{ID}';";

            MySqlCommand cmdTwo = new MySqlCommand(query, cnn);

            MySqlDataReader drTwo;

            cnn.Open();
            drTwo = cmdTwo.ExecuteReader();

            string lastName = string.Empty;


            while (drTwo.Read())
            {
                lastName = drTwo.GetString(0);
                Console.WriteLine(lastName);
            }

            drTwo.Close();
            cnn.Close();

            return firstName + " " + lastName;
        }

        public static string getBio(string email)
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string query = $"SELECT Bio FROM accounts WHERE email LIKE '{email}';";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string bio = string.Empty;


            while (dr.Read())
            {
                bio = dr.GetString(0);
                Console.WriteLine(bio);
            }

            dr.Close();
            cnn.Close();

            return bio;
        }

        public static string getHome(string email)
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string query = $"SELECT Home FROM accounts WHERE email LIKE '{email}';";
            
            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string home = string.Empty;


            while (dr.Read())
            {
                home = dr.GetString(0);
                Console.WriteLine(home);
            }

            dr.Close();
            cnn.Close();

            return home;
        }

        public static string getID(string email)
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

            string home = string.Empty;


            while (dr.Read())
            {
                home = dr.GetString(0);
                Console.WriteLine(home);
            }

            dr.Close();
            cnn.Close();

            return home;
        }

        public static string getTotalPosts(string email)
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string AccountID = getID(email);
            
            string query = $"SELECT MAX(ID) from posts where AccountID = {AccountID};";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string home = string.Empty;
            try
            {
                while (dr.Read())
                {
                    home = dr.GetString(0);
                    Console.WriteLine(home);
                }
            }
            catch (Exception)
            {
                return "0";
            }

            dr.Close();
            cnn.Close();

            return home;
        }

        public static string getPost(string email, string id)
        {
            string idNum = getID(email);

            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string query = $"SELECT value FROM posts WHERE AccountID like {idNum} and ID LIKE '{id}';";
            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string home = string.Empty;


            while (dr.Read())
            {
                home = dr.GetString(0);
                Console.WriteLine(home);
            }

            dr.Close();
            cnn.Close();

            return home;
        }

        public static string getDate(string email, string id)
        {

            string idNum = getID(email);

            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string query = $"SELECT date FROM posts WHERE AccountID like {idNum} and ID LIKE '{id}';";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string home = string.Empty;


            while (dr.Read())
            {
                home = dr.GetString(0);
                Console.WriteLine(home);
            }

            dr.Close();
            cnn.Close();

            return home;
        }

        public static void savePost(string email, string post, string date)
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string AccountID = getID(email);
            string newPostID = getTotalPosts(email);
            int tempNewPostID = int.Parse(newPostID);
            tempNewPostID++;
            newPostID = tempNewPostID.ToString();

            string dayNumber = date.Substring(3, 2);

            string query = $"INSERT INTO Posts values({AccountID}, {newPostID}, '{post}', '{date}', '{dayNumber}');";
            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string home = string.Empty;


            while (dr.Read())
            {
                home = dr.GetString(0);
                Console.WriteLine(home);
            }

            dr.Close();
            cnn.Close();
        }

        public static string getTotalAccounts()
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string query = $"SELECT COUNT(*) FROM accounts;";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string home = string.Empty;


            while (dr.Read())
            {
                home = dr.GetString(0);
                Console.WriteLine(home);
            }

            dr.Close();
            cnn.Close();

            return home;
        }

        public static string getTotalFriends(string email)
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string AccountID = getID(email);
            string query = $"SELECT COUNT(*) FROM Friends WHERE AccountID like {AccountID};";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string home = string.Empty;


            while (dr.Read())
            {
                home = dr.GetString(0);
                Console.WriteLine(home);
            }

            dr.Close();
            cnn.Close();

            return home;
        }

        public static string getFriend(string email, string name)
        {
            string idNum = getID(email);

            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string query = $"SELECT value FROM friends WHERE AccountID like {idNum} and value LIKE '{name}';";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string home = string.Empty;


            while (dr.Read())
            {
                home = dr.GetString(0);
                Console.WriteLine(home);
            }

            dr.Close();
            cnn.Close();

            return home;
        }

        public static string addFriend(string email, int ID, string listBoxText)
        {
            string idNum = getID(email);

            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);
            int newID = ID + 1;
            string userEmail = MySQLFunctions.getEmail(newID.ToString());
            string query = $"INSERT INTO friends (AccountID, ID, value, email) values ({idNum}, {ID}, '{listBoxText}', '{userEmail}');";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string home = string.Empty;


            while (dr.Read())
            {
                home = dr.GetString(0);
                Console.WriteLine(home);
            }

            dr.Close();
            cnn.Close();

            return home;
        }

        public static string removeFriend(string email, int ID, string listBoxText)
        {
            string idNum = getID(email);

            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string query = $"DELETE FROM friends WHERE value = '{listBoxText}';";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string home = string.Empty;


            while (dr.Read())
            {
                home = dr.GetString(0);
                Console.WriteLine(home);
            }

            dr.Close();
            cnn.Close();

            return home;
        }

        public static void deletePost(string email, string text)
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string AccountID = getID(email);

            string query = $"DELETE FROM posts WHERE AccountID = {AccountID} AND value = '{text}';";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string home = string.Empty;


            while (dr.Read())
            {
                home = dr.GetString(0);
                Console.WriteLine(home);
            }

            dr.Close();
            cnn.Close();
        }

        public static string getAllTotalPosts() //Gets total number of posts of all users
        {

            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string query = $"SELECT * from posts;";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string home = string.Empty;


            try
            {
                while (dr.Read())
                {
                    home = dr.GetString(0);
                    Console.WriteLine(home);
                }
            }
            catch (Exception)
            {
                return "0";
            }

            dr.Close();
            cnn.Close();

            return home;
        }

        public static string[] getFriends(string email) //returns string array that contains emails of all friends
        {
            //CheckifUserhasfriends
            if (friendExists(MySQLFunctions.getAccountIDNext(email)) != "") //Returns 1 for 1 friend
            {
                string[] returnString = new string[int.Parse(getTotalFriends(email))]; //Array of size 1
                string connectionString;
                MySqlConnection cnn;
                string query;
                MySqlCommand cmd;
                MySqlDataReader dr;
                string home;
                int ID;
                int j = 0;
                for (int i = 0; i < int.Parse(getTotalAccounts()); i++)
                {
                    ID = i + 1;
                    if (MySQLFunctions.innerFriendExists(ID.ToString()) != "")
                    {
                        connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
                        cnn = new MySqlConnection(connectionString);

                        query = $"SELECT email FROM friends WHERE ID like {ID.ToString()};";

                        cmd = new MySqlCommand(query, cnn);

                        cnn.Open();
                        dr = cmd.ExecuteReader();

                        home = string.Empty;

                        while (dr.Read())
                        {
                            home = dr.GetString(0);
                            Console.WriteLine(home);
                        }

                        dr.Close();
                        cnn.Close();
                        returnString[j] = home;

                        j++;
                    }
                }
                return returnString;
            }
            else
            {
                return new string[0];
            }

        }

        public static string friendExists(string ID) // need logged in users ID attached to email
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string query = $"SELECT * FROM Friends where AccountID LIKE {ID};";
            
            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string home = string.Empty;


            while (dr.Read())
            {
                home = dr.GetString(0);
                Console.WriteLine(home);
            }

            dr.Close();
            cnn.Close();

            return home;
        }

        public static string innerFriendExists(string ID) // need logged in users ID attached to email
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string query = $"SELECT * FROM Friends where ID LIKE {ID};";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string home = string.Empty;


            while (dr.Read())
            {
                home = dr.GetString(0);
                Console.WriteLine(home);
            }

            dr.Close();
            cnn.Close();

            return home;
        }

        public static string getAccountIDNext(string email)
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string query = $"SELECT ID FROM accounts WHERE Email like '{email}';";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string home = string.Empty;


            while (dr.Read())
            {
                home = dr.GetString(0);
                Console.WriteLine(home);
            }

            dr.Close();
            cnn.Close();

            return home;
        }

        public static string getEmail(string id)
        {

            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=SNHUBook;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string query = $"SELECT email FROM accounts WHERE ID like {id};";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string home = string.Empty;


            while (dr.Read())
            {
                home = dr.GetString(0);
                Console.WriteLine(home);
            }

            dr.Close();
            cnn.Close();

            return home;
        }
    }


}
