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
    public partial class SettingsPage : Form
    {
        int returnform;

        public SettingsPage(int recievedform)
        {
            InitializeComponent();
            int returnform = recievedform;
        }
        public SettingsPage()
        {
            InitializeComponent();
        }


        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();

            switch (returnform)
            {
                case 0:
                    {
                    HomePage a = new HomePage();
                    a.ShowDialog();
                    this.Close();
                    break;
                    }
                /*case 1:
                    {
                    Form1 = new Form1();
                    a.ShowDialog();
                    this.Close();
                    break;
                    }
                    */
                default:
                    { 
                    HomePage a = new HomePage();
                    a.ShowDialog();
                    this.Close();
                    break;
                    }
            }
        }
    }
}
