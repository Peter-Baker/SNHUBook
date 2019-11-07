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
        
        public SettingsPage()
        {
            InitializeComponent();
        }
       /* public SettingsPage(Form recievedform)
        {
            InitializeComponent();
            returnform = recievedform;
        }*/



        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage a = new HomePage();
            a.ShowDialog();
            this.Close();
        }
    }
}
