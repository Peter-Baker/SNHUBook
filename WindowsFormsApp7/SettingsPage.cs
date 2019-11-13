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
    public partial class SettingsPage : Form
    {
        int returnform;
        public SettingsPage(int recievedform)
        {
            InitializeComponent();
            LogoutConfirmPanel.Visible = false;
            ChangePasswordPanel.Visible = false;
            returnform = recievedform;
        }
        public SettingsPage()
        {
            InitializeComponent();
            LogoutConfirmPanel.Visible = false;
            ChangePasswordPanel.Visible = false;
        }


        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();

            switch (returnform)
            {
                case 0:
                    HomePage a = new HomePage();
                    a.ShowDialog();
                    this.Close();
                    break;
                case 1:
                    AccountPage b = new AccountPage();
                    b.ShowDialog();
                    this.Close();
                    break;
                default:
                    HomePage c = new HomePage();
                    c.ShowDialog();
                    this.Close();
                    break;
                    
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LogoutConfirmPanel.Visible = true;
        }

        private void ChangePasswordCancel_Click(object sender, EventArgs e)
        {
            ChangePasswordPanel.Visible = false;
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordPanel.Visible = true;
        } 
        
        private void ChangePasswordlabel_Click(object sender, EventArgs e)
        {

        }

        private void CancelLogout_Click(object sender, EventArgs e)
        {
            LogoutConfirmPanel.Visible = false;
        }

        private void ChangePasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            ChangePasswordTextbox.PasswordChar = '*';
            signup a = new signup(ChangePasswordTextbox.Text);
            a.password_check();
            if (a.password_check() == true)
            {
                ChangePasswordTextbox.BackColor = Color.Green;
            }
            else
            {
                ChangePasswordTextbox.BackColor = Color.Red;
            }

        }

        private void ChangePasswordConfirm_Click(object sender, EventArgs e)
        {
            if ( ChangePasswordTextbox.BackColor != Color.Red)
            {
              /*  string username = email_textbox.Text;
                if (password == MySQLFunctions.getPass(username))
                {
                    MessageBox.Show("Account Already exists");
                }
                else
                {

                    string tempString = "INSERT INTO accounts (FirstName, LastName, Email, Password, profImage_path, backgroundImage_path) Values('";
                    tempString = tempString + firstName + "', '";
                    tempString = tempString + lastName + "', '";
                    tempString = tempString + email + "', '";
                    tempString = tempString + password + "','NULL','NULL')";

                    MySQLFunctions.SQLCommand(tempString);

                    MessageBox.Show("You Successfully Signed Up! You May Now LogIn");
                    this.Hide();
                    WelcomePage o = new WelcomePage();
                    o.ShowDialog();*/
                }
            }
    }
}
