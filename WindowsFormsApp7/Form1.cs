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
        string email, add_bio;
        public AccountPage(String email)
        {
            InitializeComponent();
            this.email = email;
            Image myimage = new Bitmap(MySQLFunctions.getProfileImage(email));
            pictureBox1.BackgroundImage = myimage;
            ProfilePicture.BackgroundImage = myimage;
            user_button.Text = MySQLFunctions.getName(email);
            username_lbl.Text = MySQLFunctions.getName(email);
        }

        private void AccountPage_Load(object sender, EventArgs e)
        {
            add_bio_pnl.Hide();
        }

        private void user_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountPage a = new AccountPage(email);
            a.ShowDialog();
            Close();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage a = new HomePage(email);
            a.ShowDialog();
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsPage o = new SettingsPage(1, email);
            o.ShowDialog();
        }

        private void ProfilePicture_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProfileImage a = new AddProfileImage(email, true);
            a.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bio_lbl.Text = add_bio;
            this.add_bio_pnl.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.add_bio_pnl.Hide();
        }

        private void open_addbio_Click(object sender, EventArgs e)
        {
            add_bio_pnl.Show();
        }

        private void username_lbl_Click(object sender, EventArgs e)
        {

        }

        private void addbio_info_TextChanged(object sender, EventArgs e)
        {
            addbio_info.Text = add_bio;
        }
    }
}
