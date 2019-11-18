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
    public partial class AddBackground : Form
    {
        string email;

        public AddBackground(String email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void BackgroundImage1_Click(object sender, EventArgs e)
        {
            MySQLFunctions.SQLCommand($"UPDATE accounts set backgroundImage_path='10759301728_IMG_9920.jpg' where Email='{email}';");
            this.Hide();
            AccountPage d = new AccountPage(email);
            d.ShowDialog();
            this.Close();
        }

        private void BackgroundImage2_Click(object sender, EventArgs e)
        {
            MySQLFunctions.SQLCommand($"UPDATE accounts set backgroundImage_path='Background2.jpg' where Email='{email}';");
            this.Hide();
            AccountPage d = new AccountPage(email);
            d.ShowDialog();
            this.Close();
        }

        private void BackgroundImage3_Click(object sender, EventArgs e)
        {
            MySQLFunctions.SQLCommand($"UPDATE accounts set backgroundImage_path='Background3.jpg' where Email='{email}';");
            this.Hide();
            AccountPage d = new AccountPage(email);
            d.ShowDialog();
            this.Close();
        }

        private void BackgroundImage4_Click(object sender, EventArgs e)
        {
            MySQLFunctions.SQLCommand($"UPDATE accounts set backgroundImage_path='Background4.jpg' where Email='{email}';");
            this.Hide();
            AccountPage d = new AccountPage(email);
            d.ShowDialog();
            this.Close();
        }

        private void CancelButtonProfilePhoto_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountPage d = new AccountPage(email);
            d.ShowDialog();
            this.Close();
        }
    }
}
