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
            AccountPage a = new AccountPage();
            a.Show();
            Close();
        }

        private void Photo_Video_Click(object sender, EventArgs e)
        {
            PhotoPage b = new PhotoPage();
            b.Show();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            HomePage a = new HomePage();
            a.Show();
            Close();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Just saw a roach in the bathroom. I let him live cuz I thought: how would I like it if a giant bug stepped on me? (Mood: Hungry 🤤)";
            }
        }

        private void Check_In_Click(object sender, EventArgs e)
        {

        }
    }
}
