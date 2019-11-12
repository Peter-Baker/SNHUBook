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

        public AddProfileImage(String email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void profileImageOne_Click(object sender, EventArgs e)
        {
            MySQLFunctions.SQLCommand($"UPDATE accounts set profImage_path='MaleAvatar1.png' where Email='{email}';");
            this.Hide();
            HomePage d = new HomePage(email);
            d.ShowDialog();
            this.Close();
        }

        private void profileImageTwo_Click(object sender, EventArgs e)
        {
            MySQLFunctions.SQLCommand($"UPDATE accounts set profImage_path='MaleAvatar2.jpg' where Email='{email}';");
            this.Hide();
            HomePage d = new HomePage(email);
            d.ShowDialog();
            this.Close();
        }

        private void profileImageThree_Click(object sender, EventArgs e)
        {
            MySQLFunctions.SQLCommand($"UPDATE accounts set profImage_path='FemaleAvatar1.png' where Email='{email}';");
            this.Hide();
            HomePage d = new HomePage(email);
            d.ShowDialog();
            this.Close();
        }

        private void profileImageFour_Click(object sender, EventArgs e)
        {
            MySQLFunctions.SQLCommand($"UPDATE accounts set profImage_path='FemaleAvatar2.png' where Email='{email}';");
            this.Hide();
            HomePage d = new HomePage(email);
            d.ShowDialog();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage d = new HomePage(email);
            d.ShowDialog();
            this.Close();
        }
    }
}
