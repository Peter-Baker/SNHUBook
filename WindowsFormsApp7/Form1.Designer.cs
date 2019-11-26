﻿namespace WindowsFormsApp7
{
    partial class AccountPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_home_bn = new System.Windows.Forms.Button();
            this.home_lbl = new System.Windows.Forms.Label();
            this.cancel_home_bn = new System.Windows.Forms.Button();
            this.hometown_text = new System.Windows.Forms.TextBox();
            this.AddBio_Text = new System.Windows.Forms.TextBox();
            this.hometown_lbl = new System.Windows.Forms.Label();
            this.Add_bn = new System.Windows.Forms.Button();
            this.Cancel_bn = new System.Windows.Forms.Button();
            this.Bio_lbl = new System.Windows.Forms.Label();
            this.Biography = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.settings_button = new System.Windows.Forms.Button();
            this.FriendRequest_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.user_button = new System.Windows.Forms.Button();
            this.SNHUbook_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CoverPicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.blue_gradient_background;
            this.panel1.Controls.Add(this.add_home_bn);
            this.panel1.Controls.Add(this.home_lbl);
            this.panel1.Controls.Add(this.cancel_home_bn);
            this.panel1.Controls.Add(this.hometown_text);
            this.panel1.Controls.Add(this.AddBio_Text);
            this.panel1.Controls.Add(this.hometown_lbl);
            this.panel1.Controls.Add(this.Add_bn);
            this.panel1.Controls.Add(this.Cancel_bn);
            this.panel1.Controls.Add(this.Bio_lbl);
            this.panel1.Controls.Add(this.Biography);
            this.panel1.Controls.Add(this.username_lbl);
            this.panel1.Location = new System.Drawing.Point(0, 820);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2731, 281);
            this.panel1.TabIndex = 7;
            // 
            // add_home_bn
            // 
            this.add_home_bn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_home_bn.Location = new System.Drawing.Point(429, 215);
            this.add_home_bn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.add_home_bn.Name = "add_home_bn";
            this.add_home_bn.Size = new System.Drawing.Size(157, 67);
            this.add_home_bn.TabIndex = 15;
            this.add_home_bn.Text = "Add";
            this.add_home_bn.UseVisualStyleBackColor = true;
            this.add_home_bn.Click += new System.EventHandler(this.add_home_bn_Click);
            // 
            // home_lbl
            // 
            this.home_lbl.AutoSize = true;
            this.home_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.home_lbl.Location = new System.Drawing.Point(155, 165);
            this.home_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.home_lbl.Name = "home_lbl";
            this.home_lbl.Size = new System.Drawing.Size(0, 43);
            this.home_lbl.TabIndex = 15;
            // 
            // cancel_home_bn
            // 
            this.cancel_home_bn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_home_bn.Location = new System.Drawing.Point(144, 215);
            this.cancel_home_bn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cancel_home_bn.Name = "cancel_home_bn";
            this.cancel_home_bn.Size = new System.Drawing.Size(173, 67);
            this.cancel_home_bn.TabIndex = 15;
            this.cancel_home_bn.Text = "Cancel";
            this.cancel_home_bn.UseVisualStyleBackColor = true;
            this.cancel_home_bn.Click += new System.EventHandler(this.cancel_home_bn_Click);
            // 
            // hometown_text
            // 
            this.hometown_text.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hometown_text.Location = new System.Drawing.Point(147, 162);
            this.hometown_text.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.hometown_text.Multiline = true;
            this.hometown_text.Name = "hometown_text";
            this.hometown_text.Size = new System.Drawing.Size(439, 54);
            this.hometown_text.TabIndex = 10;
            this.hometown_text.TextChanged += new System.EventHandler(this.hometown_text_TextChanged);
            // 
            // AddBio_Text
            // 
            this.AddBio_Text.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBio_Text.Location = new System.Drawing.Point(144, 110);
            this.AddBio_Text.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AddBio_Text.Multiline = true;
            this.AddBio_Text.Name = "AddBio_Text";
            this.AddBio_Text.Size = new System.Drawing.Size(441, 47);
            this.AddBio_Text.TabIndex = 9;
            this.AddBio_Text.TextChanged += new System.EventHandler(this.AddBio_Text_TextChanged);
            // 
            // hometown_lbl
            // 
            this.hometown_lbl.AutoSize = true;
            this.hometown_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hometown_lbl.ForeColor = System.Drawing.Color.Gold;
            this.hometown_lbl.Location = new System.Drawing.Point(13, 162);
            this.hometown_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.hometown_lbl.Name = "hometown_lbl";
            this.hometown_lbl.Size = new System.Drawing.Size(119, 47);
            this.hometown_lbl.TabIndex = 13;
            this.hometown_lbl.Text = "From:";
            this.hometown_lbl.Click += new System.EventHandler(this.hometown_lbl_Click);
            // 
            // Add_bn
            // 
            this.Add_bn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_bn.Location = new System.Drawing.Point(400, 167);
            this.Add_bn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Add_bn.Name = "Add_bn";
            this.Add_bn.Size = new System.Drawing.Size(179, 60);
            this.Add_bn.TabIndex = 12;
            this.Add_bn.Text = "Add";
            this.Add_bn.UseVisualStyleBackColor = true;
            this.Add_bn.Click += new System.EventHandler(this.Add_bn_Click);
            // 
            // Cancel_bn
            // 
            this.Cancel_bn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_bn.Location = new System.Drawing.Point(149, 167);
            this.Cancel_bn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Cancel_bn.Name = "Cancel_bn";
            this.Cancel_bn.Size = new System.Drawing.Size(179, 60);
            this.Cancel_bn.TabIndex = 11;
            this.Cancel_bn.Text = "Cancel";
            this.Cancel_bn.UseVisualStyleBackColor = true;
            this.Cancel_bn.Click += new System.EventHandler(this.Cancel_bn_Click);
            // 
            // Bio_lbl
            // 
            this.Bio_lbl.AutoSize = true;
            this.Bio_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bio_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bio_lbl.Location = new System.Drawing.Point(109, 110);
            this.Bio_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Bio_lbl.Name = "Bio_lbl";
            this.Bio_lbl.Size = new System.Drawing.Size(90, 43);
            this.Bio_lbl.TabIndex = 2;
            this.Bio_lbl.Text = "None";
            this.Bio_lbl.Click += new System.EventHandler(this.Bio_lbl_Click);
            // 
            // Biography
            // 
            this.Biography.AutoSize = true;
            this.Biography.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biography.ForeColor = System.Drawing.Color.Gold;
            this.Biography.Location = new System.Drawing.Point(13, 105);
            this.Biography.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Biography.Name = "Biography";
            this.Biography.Size = new System.Drawing.Size(85, 47);
            this.Biography.TabIndex = 1;
            this.Biography.Text = "Bio:";
            this.Biography.Click += new System.EventHandler(this.Biography_Click);
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.BackColor = System.Drawing.Color.Transparent;
            this.username_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.ForeColor = System.Drawing.Color.Gold;
            this.username_lbl.Location = new System.Drawing.Point(5, 36);
            this.username_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(278, 69);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "UserName";
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.nyc;
            this.ProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePicture.Location = new System.Drawing.Point(21, 114);
            this.ProfilePicture.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(322, 312);
            this.ProfilePicture.TabIndex = 6;
            this.ProfilePicture.TabStop = false;
            this.ProfilePicture.Click += new System.EventHandler(this.ProfilePicture_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.blue_gradient_background;
            this.panel2.Controls.Add(this.settings_button);
            this.panel2.Controls.Add(this.FriendRequest_button);
            this.panel2.Controls.Add(this.home_button);
            this.panel2.Controls.Add(this.user_button);
            this.panel2.Controls.Add(this.SNHUbook_lbl);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2731, 103);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // settings_button
            // 
            this.settings_button.BackColor = System.Drawing.Color.Transparent;
            this.settings_button.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.setting_icon;
            this.settings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings_button.FlatAppearance.BorderSize = 0;
            this.settings_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.settings_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_button.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settings_button.Location = new System.Drawing.Point(2605, 48);
            this.settings_button.Margin = new System.Windows.Forms.Padding(5);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(51, 48);
            this.settings_button.TabIndex = 8;
            this.settings_button.UseVisualStyleBackColor = false;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // FriendRequest_button
            // 
            this.FriendRequest_button.BackColor = System.Drawing.Color.Transparent;
            this.FriendRequest_button.FlatAppearance.BorderSize = 0;
            this.FriendRequest_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.FriendRequest_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.FriendRequest_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FriendRequest_button.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendRequest_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FriendRequest_button.Location = new System.Drawing.Point(2107, 31);
            this.FriendRequest_button.Margin = new System.Windows.Forms.Padding(5);
            this.FriendRequest_button.Name = "FriendRequest_button";
            this.FriendRequest_button.Size = new System.Drawing.Size(349, 72);
            this.FriendRequest_button.TabIndex = 7;
            this.FriendRequest_button.Text = "Friend Requests";
            this.FriendRequest_button.UseVisualStyleBackColor = false;
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.Color.Transparent;
            this.home_button.FlatAppearance.BorderSize = 0;
            this.home_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.home_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.home_button.Location = new System.Drawing.Point(1816, 31);
            this.home_button.Margin = new System.Windows.Forms.Padding(5);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(277, 72);
            this.home_button.TabIndex = 6;
            this.home_button.Text = "Home";
            this.home_button.UseVisualStyleBackColor = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // user_button
            // 
            this.user_button.BackColor = System.Drawing.Color.Transparent;
            this.user_button.FlatAppearance.BorderSize = 0;
            this.user_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.user_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.user_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_button.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.user_button.Location = new System.Drawing.Point(1525, 31);
            this.user_button.Margin = new System.Windows.Forms.Padding(5);
            this.user_button.Name = "user_button";
            this.user_button.Size = new System.Drawing.Size(277, 72);
            this.user_button.TabIndex = 1;
            this.user_button.Text = "UserName";
            this.user_button.UseVisualStyleBackColor = false;
            this.user_button.Click += new System.EventHandler(this.user_button_Click);
            // 
            // SNHUbook_lbl
            // 
            this.SNHUbook_lbl.AutoSize = true;
            this.SNHUbook_lbl.BackColor = System.Drawing.Color.Transparent;
            this.SNHUbook_lbl.Font = new System.Drawing.Font("Franklin Gothic Heavy", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNHUbook_lbl.ForeColor = System.Drawing.Color.Gold;
            this.SNHUbook_lbl.Location = new System.Drawing.Point(5, 5);
            this.SNHUbook_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SNHUbook_lbl.Name = "SNHUbook_lbl";
            this.SNHUbook_lbl.Size = new System.Drawing.Size(414, 94);
            this.SNHUbook_lbl.TabIndex = 0;
            this.SNHUbook_lbl.Text = "SNHUbook";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 1402);
            this.panel3.TabIndex = 9;
            // 
            // CoverPicture
            // 
            this.CoverPicture.BackgroundImage = global::WindowsFormsApp7.Properties.Resources._10759301728_IMG_9920;
            this.CoverPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CoverPicture.Location = new System.Drawing.Point(0, 17);
            this.CoverPicture.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.CoverPicture.Name = "CoverPicture";
            this.CoverPicture.Size = new System.Drawing.Size(2731, 947);
            this.CoverPicture.TabIndex = 5;
            this.CoverPicture.TabStop = false;
            this.CoverPicture.Click += new System.EventHandler(this.CoverPicture_Click);
            // 
            // AccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2715, 1209);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CoverPicture);
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "AccountPage";
            this.Text = "AccountPage";
            this.Load += new System.EventHandler(this.AccountPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button FriendRequest_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button user_button;
        private System.Windows.Forms.Label SNHUbook_lbl;
        private System.Windows.Forms.PictureBox CoverPicture;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Biography;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Bio_lbl;
        private System.Windows.Forms.TextBox AddBio_Text;
        private System.Windows.Forms.Button Add_bn;
        private System.Windows.Forms.Button Cancel_bn;
        private System.Windows.Forms.Button add_home_bn;
        private System.Windows.Forms.TextBox hometown_text;
        private System.Windows.Forms.Label hometown_lbl;
        private System.Windows.Forms.Button cancel_home_bn;
        private System.Windows.Forms.Label home_lbl;
    }
}