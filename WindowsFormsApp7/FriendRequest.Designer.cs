namespace WindowsFormsApp7
{
    partial class FriendRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Background = new System.Windows.Forms.Panel();
            this.SNHUbook_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeFriendButton = new System.Windows.Forms.Button();
            this.addFriendButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.Background.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Background.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.blue_gradient_background;
            this.Background.Controls.Add(this.SNHUbook_lbl);
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(590, 50);
            this.Background.TabIndex = 0;
            // 
            // SNHUbook_lbl
            // 
            this.SNHUbook_lbl.AutoSize = true;
            this.SNHUbook_lbl.BackColor = System.Drawing.Color.Transparent;
            this.SNHUbook_lbl.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNHUbook_lbl.ForeColor = System.Drawing.Color.Gold;
            this.SNHUbook_lbl.Location = new System.Drawing.Point(10, 10);
            this.SNHUbook_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SNHUbook_lbl.Name = "SNHUbook_lbl";
            this.SNHUbook_lbl.Size = new System.Drawing.Size(121, 28);
            this.SNHUbook_lbl.TabIndex = 1;
            this.SNHUbook_lbl.Text = "SNHUbook";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.removeFriendButton);
            this.panel1.Controls.Add(this.addFriendButton);
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 375);
            this.panel1.TabIndex = 1;
            // 
            // removeFriendButton
            // 
            this.removeFriendButton.Location = new System.Drawing.Point(26, 86);
            this.removeFriendButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.removeFriendButton.Name = "removeFriendButton";
            this.removeFriendButton.Size = new System.Drawing.Size(93, 36);
            this.removeFriendButton.TabIndex = 1;
            this.removeFriendButton.Text = "Remove Friend";
            this.removeFriendButton.UseVisualStyleBackColor = true;
            this.removeFriendButton.Click += new System.EventHandler(this.removeFriendButton_Click);
            // 
            // addFriendButton
            // 
            this.addFriendButton.Location = new System.Drawing.Point(38, 21);
            this.addFriendButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addFriendButton.Name = "addFriendButton";
            this.addFriendButton.Size = new System.Drawing.Size(67, 36);
            this.addFriendButton.TabIndex = 0;
            this.addFriendButton.Text = "Add Friend";
            this.addFriendButton.UseVisualStyleBackColor = true;
            this.addFriendButton.Click += new System.EventHandler(this.addFriendButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(26, 257);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 36);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.Location = new System.Drawing.Point(146, 49);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(433, 303);
            this.friendsListBox.TabIndex = 3;
            // 
            // FriendRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 354);
            this.Controls.Add(this.friendsListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Background);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FriendRequest";
            this.Text = "FriendRequest";
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removeFriendButton;
        private System.Windows.Forms.Button addFriendButton;
        private System.Windows.Forms.Label SNHUbook_lbl;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListBox friendsListBox;
    }
}