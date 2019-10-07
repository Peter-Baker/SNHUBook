using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace WindowsFormsApp7
{
    class signup
    {
        public string email;
        public string firstname;
        public string lastname;
        public string password;
        public string textboxF;
        public string textboxL;
        public string textboxE;
        public string textboxP;

        public signup(string email, string firstname, string lastname, string password)
        {
            this.textboxF = firstname;
            this.textboxL = lastname;
            this.textboxE = email;
            this.textboxP = password;
        }

        Form1 a = new Form1();

        public bool firstname_check()
        {
            Regex first = new Regex(@"^[A-z][A-z|\.]+$", RegexOptions.IgnoreCase);
            if (first.Match(textboxF).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool lastname_check()
        {
            Regex last = new Regex(@"^[A-z][A-z|\.]+$", RegexOptions.IgnoreCase);
            if (last.Match(textboxL).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Email()
        {
            if (textboxE.Contains('@') && textboxE.Contains('.'))
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public void save()
        {
            Form1 x = new Form1();
            string[] lines = { "First Name: " + textboxF, "Last Name: " + textboxL, "Email: " + textboxE, "Password: " + textboxP};
            Directory.CreateDirectory(x.path() + @"\" + textboxE);
            File.WriteAllLines(x.path() + textboxE + @"\" + textboxE + ".txt", lines);
        }

        public bool password_check()
        {
            if (textboxP == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public signup(string path)
        {

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                textboxF = lines[0].Split(' ')[2];
                textboxL = lines[1].Split(' ')[2];
                textboxE = lines[2].Split(' ')[1];
                textboxP = lines[3].Split(' ')[1];
            }
            else
            {

            }

        }
    }
}
