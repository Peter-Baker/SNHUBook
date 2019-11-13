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

        WelcomePage a = new WelcomePage();

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
    }
}
