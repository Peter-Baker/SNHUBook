using System;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp7
{
    using System;
    using MySql.Data.MySqlClient;

    public class Example
    {

        static void Main()
        {
            string cs = @"server=localhost;userid=user12;
            password=34klq*;database=mydb";

            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                Console.WriteLine("MySQL version : {0}", conn.ServerVersion);

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
