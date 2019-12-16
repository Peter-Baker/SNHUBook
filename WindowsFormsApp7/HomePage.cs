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
        private int postCurrentNum = 1;

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
            if (MySQLFunctions.getAllTotalPosts() != "0")
            {
                
                
                int totalPosts = int.Parse(MySQLFunctions.getTotalPosts(email));
                string post = "";
                string name = "";
                for (int i = totalPosts; i > 0; i--) //will post all posts for your own email
                {
                    post = MySQLFunctions.getPost(email, i.ToString());
                    if (post.Length != 0)
                    {
                        AddPost a = new AddPost(i, isNewPage);

                        a.post_lbl.Text = post;
                        a.post_lbl.Size = new System.Drawing.Size(700, 25);

                        isNewPage = false;
                        postCurrentNum = i;

                        this.Controls.Add(a.post_background);
                        a.post_background.Controls.Add(a.post_lbl);
                        a.post_background.Controls.Add(a.date_lbl);

                        name = MySQLFunctions.getName(email);
                        a.date_lbl.Text = MySQLFunctions.getDate(email, i.ToString()) + " - " + name;
                        a.date_lbl.Width = 500;

                        a.post_lbl.Show();
                        a.date_lbl.Show();
                        a.post_background.Show();
                        PanelLocation += 100; //Adding an amount
                    }
                    else
                    {
                        i--;
                    }
                }
                string[] friendsList = MySQLFunctions.getFriends(email); //Returns string array will all friends emails
                for (int i = 0; i < int.Parse(MySQLFunctions.getTotalFriends(email)); i++)
                {
                    int tPosts = friendsList.Length;

                    string p = "";
                    string n = "";
                    for (int j = tPosts; j > 0; j--)
                    {
                        p = MySQLFunctions.getPost(friendsList[j - 1], j.ToString());
                        if (p.Length != 0)
                        {
                            AddPost a = new AddPost(j, isNewPage);

                            a.post_lbl.Text = p;
                            a.post_lbl.Size = new System.Drawing.Size(700, 25);

                            isNewPage = false;
                            postCurrentNum = j;

                            this.Controls.Add(a.post_background);
                            a.post_background.Controls.Add(a.post_lbl);
                            a.post_background.Controls.Add(a.date_lbl);

                            n = MySQLFunctions.getName(friendsList[j - 1]);
                            a.date_lbl.Text = MySQLFunctions.getDate(friendsList[j-1], j.ToString()) + " - " + n;
                            a.date_lbl.Width = 500;

                            a.post_lbl.Show();
                            a.date_lbl.Show();
                            a.post_background.Show();
                            PanelLocation += 100; //Adding an amount
                        }
                        else
                        {
                            j--;
                        }
                    }
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

            ah.post_lbl.Show();
            ah.date_lbl.Show();
            ah.post_background.Show();
            
            PanelLocation += 100;

            MySQLFunctions.savePost(email, textBox1.Text, ah.date_lbl.Text);

            this.Hide();
            AddProfileImage a = new AddProfileImage(1, email);
            this.Close();
        }

        public void loadPosts(String post)
        {
            AddPost a = new AddPost(postCurrentNum, isNewPage);
            a.post_lbl.Text = post;
            a.post_lbl.Size = new System.Drawing.Size(700, 25);

            this.Controls.Add(a.post_background);
            a.post_background.Controls.Add(a.post_lbl);
            a.post_background.Controls.Add(a.date_lbl);

            a.post_lbl.Show();
            a.date_lbl.Show();
            a.post_background.Show();
            PanelLocation += 100;
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
