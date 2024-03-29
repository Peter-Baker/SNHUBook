﻿using MySql.Data.MySqlClient;
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
        private string firstName;
        private string lastName;
        private string email;
        private string password;

        public SignUp()
        {
            InitializeComponent();
        }

        private void firstname_textbox_TextChanged(object sender, EventArgs e)
        {
            firstName = firstname_textbox.Text;
            if(firstname_textbox.Text.Length == 0)
            {
                firstNameErrorText.Visible = true;
            }
            else
            {
                firstNameErrorText.Visible = false;
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage a = new WelcomePage();
            a.ShowDialog();
            this.Close();
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

                if (email_textbox.BackColor != Color.Red && firstname_textbox.BackColor != Color.Red && 
                    lastname_textbox.BackColor != Color.Red && password_textbox.BackColor != Color.Red)
                {
                string username = email_textbox.Text;
                    if (password == MySQLFunctions.getPass(username))
                    {
                        MessageBox.Show("Account Already exists");
                    }
                    else
                    {

                    string tempString = "INSERT INTO accounts (FirstName, LastName, Email, Password, profImage_path, backgroundImage_path, Bio, Home) Values('";
                    tempString = tempString + firstName + "', '";
                    tempString = tempString + lastName + "', '";
                    tempString = tempString + email + "', '";
                    tempString = tempString + password + "','nyc.jpg','10759301728_IMG_9920.jpg', 'NULL', 'NULL')";

                    MySQLFunctions.SQLCommand(tempString);

                    MessageBox.Show("You Successfully Signed Up! You May Now LogIn");
                    this.Hide();
                    WelcomePage o = new WelcomePage();
                    o.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Make Sure Everythings Valid and Submit again");
            }

        }

        private void lastname_textbox_TextChanged(object sender, EventArgs e)
        {
            lastName = lastname_textbox.Text;
            if(lastname_textbox.Text.Length == 0)
            {
                LastNameErrorText.Visible = true;
            }
            else
            {
                LastNameErrorText.Visible = false;
            }
        }

        private void email_textbox_TextChanged(object sender, EventArgs e)
        {
            email = email_textbox.Text;
            if (email_textbox.Text.Length == 0)
            {
                EmailCantBeEmpty.Visible = true;
            }else if(email_textbox.Text.Contains("@snhu.edu") == false)
            {
                MustBeASNHUEmailAddress.Visible = true;
            }
            else
            {
                EmailCantBeEmpty.Visible = false;
                MustBeASNHUEmailAddress.Visible = false;
            }
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            password = password_textbox.Text;
            password_textbox.PasswordChar = '*';
            if(password_textbox.Text.Length == 0)
            {
                PasswordCantBeEmpty.Visible = true;
            }
            else
            {
                PasswordCantBeEmpty.Visible = false;
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void LastNameErrorText_Click(object sender, EventArgs e)
        {

        }

        private void firstNameErrorText_Click(object sender, EventArgs e)
        {

        }
    }
}

