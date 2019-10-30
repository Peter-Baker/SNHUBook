namespace WindowsFormsApp7
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.FriendRequest_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.user_button = new System.Windows.Forms.Button();
            this.SNHUbook_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.username_lbl = new System.Windows.Forms.Label();
            this.Biography = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Bio_lbl = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.settings_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CoverPicture = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.settings_button);
            this.panel2.Controls.Add(this.FriendRequest_button);
            this.panel2.Controls.Add(this.home_button);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.user_button);
            this.panel2.Controls.Add(this.SNHUbook_lbl);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1365, 53);
            this.panel2.TabIndex = 4;
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
            this.FriendRequest_button.Location = new System.Drawing.Point(1053, 16);
            this.FriendRequest_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FriendRequest_button.Name = "FriendRequest_button";
            this.FriendRequest_button.Size = new System.Drawing.Size(175, 37);
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
            this.home_button.Location = new System.Drawing.Point(908, 16);
            this.home_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(139, 37);
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
            this.user_button.Location = new System.Drawing.Point(763, 16);
            this.user_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_button.Name = "user_button";
            this.user_button.Size = new System.Drawing.Size(139, 37);
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
            this.SNHUbook_lbl.Location = new System.Drawing.Point(3, 2);
            this.SNHUbook_lbl.Name = "SNHUbook_lbl";
            this.SNHUbook_lbl.Size = new System.Drawing.Size(210, 44);
            this.SNHUbook_lbl.TabIndex = 0;
            this.SNHUbook_lbl.Text = "SNHUbook";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.Bio_lbl);
            this.panel1.Controls.Add(this.Biography);
            this.panel1.Controls.Add(this.username_lbl);
            this.panel1.Location = new System.Drawing.Point(0, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1365, 116);
            this.panel1.TabIndex = 7;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.Location = new System.Drawing.Point(459, 15);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(141, 36);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "UserName";
            // 
            // Biography
            // 
            this.Biography.AutoSize = true;
            this.Biography.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biography.Location = new System.Drawing.Point(461, 51);
            this.Biography.Name = "Biography";
            this.Biography.Size = new System.Drawing.Size(45, 25);
            this.Biography.TabIndex = 1;
            this.Biography.Text = "Bio:";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 723);
            this.panel3.TabIndex = 9;
            // 
            // Bio_lbl
            // 
            this.Bio_lbl.AutoSize = true;
            this.Bio_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bio_lbl.Location = new System.Drawing.Point(511, 53);
            this.Bio_lbl.Name = "Bio_lbl";
            this.Bio_lbl.Size = new System.Drawing.Size(89, 24);
            this.Bio_lbl.TabIndex = 2;
            this.Bio_lbl.Text = "Description";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1331, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 723);
            this.vScrollBar1.TabIndex = 8;
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.nyc;
            this.ProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePicture.Location = new System.Drawing.Point(113, 205);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(293, 293);
            this.ProfilePicture.TabIndex = 6;
            this.ProfilePicture.TabStop = false;
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
            this.settings_button.Location = new System.Drawing.Point(1305, 22);
            this.settings_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(25, 25);
            this.settings_button.TabIndex = 8;
            this.settings_button.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.nyc;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(720, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // CoverPicture
            // 
            this.CoverPicture.BackgroundImage = global::WindowsFormsApp7.Properties.Resources._10759301728_IMG_9920;
            this.CoverPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CoverPicture.Location = new System.Drawing.Point(0, 9);
            this.CoverPicture.Name = "CoverPicture";
            this.CoverPicture.Size = new System.Drawing.Size(1365, 489);
            this.CoverPicture.TabIndex = 5;
            this.CoverPicture.TabStop = false;
            // 
            // AccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 724);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CoverPicture);
            this.Name = "AccountPage";
            this.Text = "AccountPage";
            this.Load += new System.EventHandler(this.AccountPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button FriendRequest_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button user_button;
        private System.Windows.Forms.Label SNHUbook_lbl;
        private System.Windows.Forms.PictureBox CoverPicture;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Biography;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Bio_lbl;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}