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
    public partial class HomePage : Form
    {
        private static int PanelLocation = 200;
        private int postCurrentNum = 1;
        string email;

        bool isNewPage = true;
        
        public HomePage(string email) //Please use this one to transfer data.
        {
            InitializeComponent();
            this.email = email;


            //Below is checking which profile photo to load
            Image myimage = new Bitmap(MySQLFunctions.getProfileImage(email));
            pictureBox1.BackgroundImage = myimage;
            user_button.Text = MySQLFunctions.getName(email);
        }

        private void FriendRequest_button_Click(object sender, EventArgs e)
        {
            PanelLocation = 200;
            this.Hide();
            FriendRequest a = new FriendRequest(email, 0);
            a.ShowDialog();
            this.Close();
        }

        private void Recent_Posts_Click(object sender, EventArgs e)
        {

        }

        private void user_button_Click(object sender, EventArgs e)
        {
            PanelLocation = 200;
            this.Hide();
            AccountPage a = new AccountPage(email);
            a.ShowDialog();
            this.Close();
        }

        private void Photo_Video_Click(object sender, EventArgs e)
        {
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            PanelLocation = 200;
            this.Hide();
            HomePage a = new HomePage(email);
            a.ShowDialog();
            this.Close();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            panel4.Hide();
            if (MySQLFunctions.getTotalPosts(email) != "0")
            {
                int totalPosts = int.Parse(MySQLFunctions.getTotalPosts(email));
                string post = "";
                for (int i = totalPosts; i >= 0; i--)
                {
                    post = MySQLFunctions.getPost(email, i.ToString());

                    
                    AddPost a = new AddPost(i, isNewPage);
                    a.post_lbl.Text = post;
                    a.post_lbl.Size = new System.Drawing.Size(700, 25);

                    isNewPage = false;
                    postCurrentNum = i;
                    
                    this.Controls.Add(a.post_background);
                    a.post_background.Controls.Add(a.post_lbl);
                    a.post_background.Controls.Add(a.date_lbl);
                    a.post_background.Controls.Add(a.delete_lbl);

                    a.post_lbl.Show();
                    a.date_lbl.Show();
                    a.post_background.Show();
                    a.delete_lbl.Show();
                    PanelLocation += 100; //Adding an amount
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void Check_In_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void post_text_Click(object sender, EventArgs e)
        {
            
        }

        private void Submit_post_button_Click(object sender, EventArgs e)
        {
            AddPost ah = new AddPost(postCurrentNum, isNewPage);
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

            //New Post added to end
            //Delete all Posts, reload

            this.Hide();
            AddProfileImage a = new AddProfileImage(1, email);
            this.Close();
        }

        public void loadPosts(String post)
        {
            AddPost a = new AddPost(postCurrentNum, isNewPage);
            string delete_lbl_name;
            a.post_lbl.Text = post;
            a.post_lbl.Size = new System.Drawing.Size(700, 25);

            this.Controls.Add(a.post_background);
            a.post_background.Controls.Add(a.post_lbl);
            a.post_background.Controls.Add(a.date_lbl);
            a.post_background.Controls.Add(a.delete_lbl);

            a.post_lbl.Show();
            a.date_lbl.Show();
            a.delete_lbl.Show();
            a.post_background.Show();
            PanelLocation += 100;
            delete_lbl_name = a.delete_name;
        }

        private void date_lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            PanelLocation = 200;
            //Form sendform = Form.ActiveForm;
            this.Hide();
            SettingsPage a = new SettingsPage(0, email);
            a.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PanelLocation = 200;
            this.Hide();
            AddProfileImage a = new AddProfileImage(email, false);
            a.ShowDialog();
            this.Close();
        }

        private void panel4_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void homepage_scrollbar_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Tag_button_Click(object sender, EventArgs e)
        {
            TagFriend a = new TagFriend();
            a.ShowDialog();
        }
    }
}
