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
            ProfilePicture.BackgroundImage = myimage;
            user_button.Text = MySQLFunctions.getName(email);
            username_lbl.Text = MySQLFunctions.getName(email);
            Bio_lbl.Text = MySQLFunctions.getBio(email);
            home_lbl.Text = MySQLFunctions.getHome(email);
            Image backImage = new Bitmap(MySQLFunctions.getBackgroundImage(email));
            CoverPicture.BackgroundImage = backImage;
        }

        private void AccountPage_Load(object sender, EventArgs e)
        {
            AddBio_Text.Hide();
            Add_bn.Hide();
            Cancel_bn.Hide();

            hometown_text.Hide();
            cancel_home_bn.Hide();
            add_home_bn.Hide();
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
            this.Hide();
            AddProfileImage a = new AddProfileImage(email, true);
            a.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Bio_lbl_Click(object sender, EventArgs e)
        {

        }

        private void open_addbio_Click(object sender, EventArgs e)
        {
            AddBio_Text.Show();
            Cancel_bn.Show();
            Add_bn.Show();
        }

        private void Cancel_bn_Click(object sender, EventArgs e)
        {
            AddBio_Text.Hide();
            Add_bn.Hide();
            Cancel_bn.Hide();
        }

        private void AddBio_Text_TextChanged(object sender, EventArgs e) //Add bio textbox
        {
            add_bio = AddBio_Text.Text;
        }

        private void add_home_bn_Click(object sender, EventArgs e)
        {
            home_lbl.Text = hometown_text.Text;
            AddBio_Text.Hide();
            Add_bn.Hide();
            Cancel_bn.Hide();
            hometown_text.Hide();
            cancel_home_bn.Hide();
            add_home_bn.Hide();

            MySQLFunctions.SQLCommand($"UPDATE accounts SET Home='{hometown_text.Text}' where Email = '{email}'");
        }

        private void hometown_text_TextChanged(object sender, EventArgs e) //Add hometown textbox
        {

        }

        private void cancel_home_bn_Click(object sender, EventArgs e)
        {
            hometown_text.Hide();
            cancel_home_bn.Hide();
            add_home_bn.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hometown_text.Show();
            cancel_home_bn.Show();
            add_home_bn.Show();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Biography_Click(object sender, EventArgs e)
        {
            hometown_text.Hide();
            cancel_home_bn.Hide();
            add_home_bn.Hide();
            AddBio_Text.Show();
            Cancel_bn.Show();
            Add_bn.Show();

            AddBio_Text.BringToFront();
            Cancel_bn.BringToFront();
            Add_bn.BringToFront();
        }

        private void hometown_lbl_Click(object sender, EventArgs e)
        {
            AddBio_Text.Hide();
            Cancel_bn.Hide();
            Add_bn.Hide();
            hometown_text.Show();
            cancel_home_bn.Show();
            add_home_bn.Show();

            hometown_text.BringToFront();
            cancel_home_bn.BringToFront();
            add_home_bn.BringToFront();
        }

        private void CoverPicture_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBackground a = new AddBackground(email);
            a.ShowDialog();
            this.Close();
        }

        private void FriendRequest_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            FriendRequest a = new FriendRequest(email, 1);
            a.ShowDialog();
            this.Close();
        }

        private void Add_bn_Click(object sender, EventArgs e)
        {
            Bio_lbl.Text = add_bio;
            AddBio_Text.Hide();
            Add_bn.Hide();
            Cancel_bn.Hide();
            hometown_text.Hide();
            cancel_home_bn.Hide();
            add_home_bn.Hide();
            MySQLFunctions.SQLCommand($"UPDATE accounts SET Bio='{add_bio}' where Email = '{email}'");
        }
    }
}
