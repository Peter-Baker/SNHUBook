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
    public partial class FriendRequest : Form
    {

        string email;

        public FriendRequest(string email)
        {
            InitializeComponent();

            this.email = email;

            string totalString = MySQLFunctions.getTotalAccounts();
            int totalAccounts = int.Parse(totalString);

            //Adds in all accounts
            for (int i = 1; i <= totalAccounts; i++)
            {
                friendsListBox.Items.Add(MySQLFunctions.getName(i));
            }
        }

        private void addFriendButton_Click(object sender, EventArgs e)
        {
            if (friendsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item first!");
            }
            else
            {
                int totalFriends = int.Parse(MySQLFunctions.getTotalFriends(email));
                if(totalFriends == 0) //if user has no friends, just add the friend.
                {
                    MessageBox.Show("Friend added!");
                    MySQLFunctions.addFriend(email, friendsListBox.SelectedIndex, friendsListBox.Items[friendsListBox.SelectedIndex].ToString());
                }
                
                //Search friends table to see if friend is already added.
                string friend = "";
                friend = MySQLFunctions.getFriend(email, friendsListBox.Items[friendsListBox.SelectedIndex].ToString());
                if (friend == "")
                {
                    MessageBox.Show("Friend added!");
                    MySQLFunctions.addFriend(email, friendsListBox.SelectedIndex, friendsListBox.Items[friendsListBox.SelectedIndex].ToString());
                }
                
                else if (friend == MySQLFunctions.getFriend(email, MySQLFunctions.getName(email)))
                {
                    MessageBox.Show("You cannot add yourself as a friend!");
                }
                else
                {
                    MessageBox.Show("Friend is already added!");
                }
            }
        }

        private void removeFriendButton_Click(object sender, EventArgs e)
        {
            string friend = "";
            friend = MySQLFunctions.getFriend(email, friendsListBox.Items[friendsListBox.SelectedIndex].ToString());
            if (friendsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item first!");
            }
            else
            {
                int totalFriends = int.Parse(MySQLFunctions.getTotalFriends(email));
                if (totalFriends == 0) //if user has no friends, just add the friend.
                {
                    MessageBox.Show("User is not your friend!");
                }
                //Search friends table to see if friend is already added.
                else if (friend == "")
                {
                    MessageBox.Show("User is not your friend!");
                    //MySQLFunctions.addFriend(email, friendsListBox.SelectedIndex, friendsListBox.Items[friendsListBox.SelectedIndex].ToString());
                }

                else if (friend == MySQLFunctions.getFriend(email, MySQLFunctions.getName(email)))
                {
                    MessageBox.Show("You cannot remove yourself as a friend!");
                }
                else
                {
                    MessageBox.Show("Friend removed.");
                    MySQLFunctions.removeFriend(email, friendsListBox.SelectedIndex, friendsListBox.Items[friendsListBox.SelectedIndex].ToString());
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage d = new HomePage(email);
            d.ShowDialog();
            this.Close();
        }

        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
