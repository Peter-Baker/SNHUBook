﻿using System;
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
        public SignUp()
        {
            InitializeComponent();
        }

        private void firstname_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
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
                if (email_textbox.BackColor != Color.Red && firstname_textbox.BackColor != Color.Red && lastname_textbox.BackColor != Color.Red && password_textbox.BackColor != Color.Red)
                {
                    a.save();
                    MessageBox.Show("You Successfully Signed Up! You May Now LogIn");
                    this.Hide();
                    Form1 o = new Form1();
                    o.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Make Sure Everythings Valid and Submit again");
                }
      
        }
            //else
              //  MessageBox.Show("Make Sure Everythings Valid and Submit again");
             
    }
    }
