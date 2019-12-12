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
        string email;
        
        public HomePage(string email) //Please use this one to transfer data.
        {
            InitializeComponent();
            this.email = email;

            //Below is checking which profile photo to load
            Image myimage = new Bitmap(MySQLFunctions.getProfileImage(email));
            pictureBox1.BackgroundImage = myimage;
            user_button.Text = MySQLFunctions.getName(email);

            //Below will be pulling previous posts
            

            if (MySQLFunctions.getTotalPosts(email) != "0")
            {
                int totalPosts = int.Parse(MySQLFunctions.getTotalPosts(email));
                string post = "";
                string date = "";
                for (int i = 1; i <= totalPosts; i++)
                {
                    post = MySQLFunctions.getPost(email, i.ToString());
                    date = MySQLFunctions.getDate(email, i.ToString());
                    AddPost a = new AddPost();

                    a.post_lbl.Text = post;
                    a.post_lbl.Size = new System.Drawing.Size(700, 25);
                    a.date_lbl.Text = date;
                    this.Controls.Add(a.post_background);
                    a.post_background.Controls.Add(a.post_lbl);
                    a.post_background.Controls.Add(a.date_lbl);

                    a.post_lbl.Show();
                    a.date_lbl.Show();
                    a.post_background.Show();
                    PanelLocation += 100;
                }
            }
        }

        private void FriendRequest_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            FriendRequest a = new FriendRequest(email);
            a.ShowDialog();
            this.Close();
        }

        private void Recent_Posts_Click(object sender, EventArgs e)
        {

        }

        private void user_button_Click(object sender, EventArgs e)
        {
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
                for (int i = 1; i <= totalPosts; i++)
                {
                    post = MySQLFunctions.getPost(email, i.ToString());

                    AddPost a = new AddPost();

                    a.post_lbl.Text = post;
                    a.post_lbl.Size = new System.Drawing.Size(700, 25);

                    this.Controls.Add(a.post_background);
                    a.post_background.Controls.Add(a.post_lbl);
                    a.post_background.Controls.Add(a.date_lbl);
                    a.post_background.Controls.Add(a.delete_lbl);

                    a.post_lbl.Show();
                    a.date_lbl.Show();
                    a.post_background.Show();
                    a.delete_lbl.Show();
                    PanelLocation += 100;
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
            AddPost a = new AddPost();
            a.post_lbl.Text = textBox1.Text;
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

            MySQLFunctions.savePost(email, textBox1.Text, a.date_lbl.Text);
        }

        public void loadPosts(String post)
        {
            AddPost a = new AddPost();
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
            //Form sendform = Form.ActiveForm;
            this.Hide();
            SettingsPage a = new SettingsPage(0, email);
            a.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
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
