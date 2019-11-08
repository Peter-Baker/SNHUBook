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
        public AddProfileImage()
        {
            InitializeComponent();
        }

        private void profileImageOne_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage d = new HomePage();
            d.ShowDialog();
            this.Close();
        }

        private void profileImageTwo_Click(object sender, EventArgs e)
        {

        }

        private void profileImageThree_Click(object sender, EventArgs e)
        {

        }

        private void profileImageFour_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage d = new HomePage();
            d.ShowDialog();
            this.Close();
        }
    }
}
