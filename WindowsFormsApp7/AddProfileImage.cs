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
    public partial class AddProfileImage : Form
    {
        string email;

        bool isPersonalPage;

        public AddProfileImage(int num, string email)
        {
            //Using this to reload main page, i know horrible coding
            this.email = email;
            crashPage();
        }

        public AddProfileImage(String email, bool isPersonalPage) //Use this boolean to determine if the page their currently on is their own
        {
            InitializeComponent();
            this.email = email;
            this.isPersonalPage = isPersonalPage;
            Random num = new Random();
            int r = num.Next(0, 3);
            switch (r)
            {
                case 0:
                    this.BackgroundImage = Properties.Resources.Flowers1;
                    break;
                case 1:
                    this.BackgroundImage = Properties.Resources.Flower2;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.Flowers3;
                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources.Flower4;
                    break;
                default:
                    this.BackgroundImage = Properties.Resources.Flowers1;
                    break;

            }

        }

        public AddProfileImage() 
        {

            InitializeComponent();
            
            Random num = new Random();
            int r = num.Next(0,3);
            switch (r)
            {
                case 0:
                    this.BackgroundImage = Properties.Resources.Flowers1;
                    break;
                case 1:
                    this.BackgroundImage = Properties.Resources.Flower2;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.Flowers3;
                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources.Flower4;
                    break;
                default:
                    this.BackgroundImage = Properties.Resources.Flowers1;
                    break;

            }

           
        }

        public void crashPage()
        {
            this.Hide();
            HomePage a = new HomePage(email);
            a.ShowDialog();
            this.Close();
        }

        private void profileImageOne_Click(object sender, EventArgs e)
        {
            if(isPersonalPage == false)
            {
                MySQLFunctions.SQLCommand($"UPDATE accounts set profImage_path='MaleAvatar1.png' where Email='{email}';");
                this.Hide();
                HomePage d = new HomePage(email);
                d.ShowDialog();
                this.Close();
            }
            else
            {
                MySQLFunctions.SQLCommand($"UPDATE accounts set profImage_path='MaleAvatar1.png' where Email='{email}';");
                this.Hide();
                AccountPage d = new AccountPage(email);
                d.ShowDialog();
                this.Close();
            }
        }

        private void profileImageTwo_Click(object sender, EventArgs e)
        {
            if (isPersonalPage == false)
            {
                MySQLFunctions.SQLCommand($"UPDATE accounts set profImage_path='MaleAvatar2.jpg' where Email='{email}';");
                this.Hide();
                HomePage d = new HomePage(email);
                d.ShowDialog();
                this.Close();
            }
            else
            {
                MySQLFunctions.SQLCommand($"UPDATE accounts set profImage_path='MaleAvatar2.jpg' where Email='{email}';");
                this.Hide();
                AccountPage d = new AccountPage(email);
                d.ShowDialog();
                this.Close();
            }
        }

        private void profileImageThree_Click(object sender, EventArgs e)
        {
            if (isPersonalPage == false)
            {
                MySQLFunctions.SQLCommand($"UPDATE accounts set profImage_path='FemaleAvatar1.png' where Email='{email}';");
                this.Hide();
                HomePage d = new HomePage(email);
                d.ShowDialog();
                this.Close();
            }
            else
            {
                MySQLFunctions.SQLCommand($"UPDATE accounts set profImage_path='FemaleAvatar1.png' where Email='{email}';");
                this.Hide();
                AccountPage d = new AccountPage(email);
                d.ShowDialog();
                this.Close();
            }
        }

        private void profileImageFour_Click(object sender, EventArgs e)
        {
            if (isPersonalPage == false)
            {
                MySQLFunctions.SQLCommand($"UPDATE accounts set profImage_path='FemaleAvatar2.png' where Email='{email}';");
                this.Hide();
                HomePage d = new HomePage(email);
                d.ShowDialog();
                this.Close();
            }
            else
            {
                MySQLFunctions.SQLCommand($"UPDATE accounts set profImage_path='FemaleAvatar2.png' where Email='{email}';");
                this.Hide();
                AccountPage d = new AccountPage(email);
                d.ShowDialog();
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (isPersonalPage == false)
            {
                this.Hide();
                HomePage d = new HomePage(email);
                d.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                AccountPage d = new AccountPage(email);
                d.ShowDialog();
                this.Close();
            }
        }
    }
}
