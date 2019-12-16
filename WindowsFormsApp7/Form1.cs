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

        private int postCurrentNum = 1;
        bool isNewPage = true;
        private static int PanelLocation = 666;

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

            panel4.Hide();
            if (MySQLFunctions.getTotalPosts(email) != "0")
            {
                int totalPosts = int.Parse(MySQLFunctions.getTotalPosts(email));
                string post = "";
                for (int i = totalPosts; i > 0; i--)
                {
                    post = MySQLFunctions.getPost(email, i.ToString());


                    AccountAddPost a = new AccountAddPost(i, isNewPage);
                    a.post_lbl.Text = post;
                    a.post_lbl.Size = new System.Drawing.Size(700, 25);

                    isNewPage = false;
                    postCurrentNum = i;

                    this.Controls.Add(a.post_background);
                    a.post_background.Controls.Add(a.post_lbl);
                    a.post_background.Controls.Add(a.date_lbl);
                    a.post_background.Controls.Add(a.delete_lbl);

                    a.date_lbl.Text = MySQLFunctions.getDate(email, i.ToString());

                    a.post_lbl.Show();
                    a.date_lbl.Show();
                    a.post_background.Show();
                    a.delete_lbl.Show();
                    PanelLocation += 100; //Adding an amount
                }
            }

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

        private void Submit_post_button_Click(object sender, EventArgs e)
        {

            AccountAddPost ah = new AccountAddPost(postCurrentNum, isNewPage);
            ah.post_lbl.Text = textBox1.Text;
            ah.post_lbl.Size = new System.Drawing.Size(700, 25);

            this.Controls.Add(ah.post_background);
            ah.post_background.Controls.Add(ah.post_lbl);
            ah.post_background.Controls.Add(ah.date_lbl);
            ah.post_background.Controls.Add(ah.delete_lbl);

            ah.post_lbl.Show();
            ah.date_lbl.Show();
            ah.delete_lbl.Show();
            ah.post_background.Show();

            PanelLocation += 100;

            MySQLFunctions.savePost(email, textBox1.Text, ah.date_lbl.Text);

            this.Hide();
            AddProfileImage a = new AddProfileImage(2, email);
            this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
