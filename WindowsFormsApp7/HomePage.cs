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
        int PanelLocation = 411;
        string post;
        public HomePage()
        {
            InitializeComponent();
        }

        private void FriendRequest_button_Click(object sender, EventArgs e)
        {

        }

        private void Recent_Posts_Click(object sender, EventArgs e)
        {

        }

        private void user_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountPage a = new AccountPage();
            a.ShowDialog();
            Close();
        }

        private void Photo_Video_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhotoPage b = new PhotoPage();
            b.ShowDialog();
            Close();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage a = new HomePage();
            a.ShowDialog();
            Close();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            panel4.Hide();
            DateTime now = DateTime.Now;
            string date = now.ToString();
            date = date.Substring(0, 9);
            date_lbl.Text = ("Date: " + date);

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
            /*Panel newPanel = new Panel();
            newPanel.Size = new System.Drawing.Size(973, 170);
            newPanel.Location = new System.Drawing.Point(209, PanelLocation);
            HomePage.Add(newPanel);
            PanelLocation += 60;*/
            post_text.Text = post;
            panel4.Show();
        }

        private void date_lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            post = textBox1.Text;
        }
    }
}
