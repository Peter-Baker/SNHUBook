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
    public partial class AccountPage : Form
    {
        public AccountPage()
        {
            InitializeComponent();
        }

        private void AccountPage_Load(object sender, EventArgs e)
        {

        }

        private void user_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountPage a = new AccountPage();
            a.ShowDialog();
            Close();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage a = new HomePage();
            a.ShowDialog();
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsPage o = new SettingsPage(1);
            o.ShowDialog();
        }
    }
}
