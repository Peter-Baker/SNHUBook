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
            this.settings_button = new System.Windows.Forms.Button();
            this.FriendRequest_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_button = new System.Windows.Forms.Button();
            this.SNHUbook_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bio_lbl = new System.Windows.Forms.Label();
            this.Biography = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.CoverPicture = new System.Windows.Forms.PictureBox();
            this.add_bio_pnl = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.addbio_info = new System.Windows.Forms.TextBox();
            this.open_addbio = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPicture)).BeginInit();
            this.add_bio_pnl.SuspendLayout();
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
            this.settings_button.Location = new System.Drawing.Point(1305, 22);
            this.settings_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(25, 25);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 724);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.open_addbio);
            this.panel1.Controls.Add(this.Bio_lbl);
            this.panel1.Controls.Add(this.Biography);
            this.panel1.Controls.Add(this.username_lbl);
            this.panel1.Location = new System.Drawing.Point(0, 423);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1365, 116);
            this.panel1.TabIndex = 7;
            // 
            // Bio_lbl
            // 
            this.Bio_lbl.AutoSize = true;
            this.Bio_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bio_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bio_lbl.Location = new System.Drawing.Point(511, 53);
            this.Bio_lbl.Name = "Bio_lbl";
            this.Bio_lbl.Size = new System.Drawing.Size(89, 24);
            this.Bio_lbl.TabIndex = 2;
            this.Bio_lbl.Text = "Description";
            // 
            // Biography
            // 
            this.Biography.AutoSize = true;
            this.Biography.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biography.ForeColor = System.Drawing.Color.Gold;
            this.Biography.Location = new System.Drawing.Point(461, 52);
            this.Biography.Name = "Biography";
            this.Biography.Size = new System.Drawing.Size(45, 25);
            this.Biography.TabIndex = 1;
            this.Biography.Text = "Bio:";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.BackColor = System.Drawing.Color.Transparent;
            this.username_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.ForeColor = System.Drawing.Color.Gold;
            this.username_lbl.Location = new System.Drawing.Point(459, 15);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(141, 36);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "UserName";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1331, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 724);
            this.vScrollBar1.TabIndex = 8;
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.nyc;
            this.ProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePicture.Location = new System.Drawing.Point(113, 204);
            this.ProfilePicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(293, 294);
            this.ProfilePicture.TabIndex = 6;
            this.ProfilePicture.TabStop = false;
            this.ProfilePicture.Click += new System.EventHandler(this.ProfilePicture_Click);
            // 
            // CoverPicture
            // 
            this.CoverPicture.BackgroundImage = global::WindowsFormsApp7.Properties.Resources._10759301728_IMG_9920;
            this.CoverPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CoverPicture.Location = new System.Drawing.Point(0, 9);
            this.CoverPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CoverPicture.Name = "CoverPicture";
            this.CoverPicture.Size = new System.Drawing.Size(1365, 489);
            this.CoverPicture.TabIndex = 5;
            this.CoverPicture.TabStop = false;
            // 
            // add_bio_pnl
            // 
            this.add_bio_pnl.Controls.Add(this.button2);
            this.add_bio_pnl.Controls.Add(this.add_button);
            this.add_bio_pnl.Controls.Add(this.addbio_info);
            this.add_bio_pnl.Location = new System.Drawing.Point(629, 252);
            this.add_bio_pnl.Name = "add_bio_pnl";
            this.add_bio_pnl.Size = new System.Drawing.Size(312, 248);
            this.add_bio_pnl.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(228, 208);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(76, 40);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // addbio_info
            // 
            this.addbio_info.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbio_info.Location = new System.Drawing.Point(0, 0);
            this.addbio_info.Multiline = true;
            this.addbio_info.Name = "addbio_info";
            this.addbio_info.Size = new System.Drawing.Size(311, 209);
            this.addbio_info.TabIndex = 0;
            this.addbio_info.TextChanged += new System.EventHandler(this.addbio_info_TextChanged);
            // 
            // open_addbio
            // 
            this.open_addbio.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_addbio.Location = new System.Drawing.Point(0, 0);
            this.open_addbio.Name = "open_addbio";
            this.open_addbio.Size = new System.Drawing.Size(107, 43);
            this.open_addbio.TabIndex = 10;
            this.open_addbio.Text = "Add Bio";
            this.open_addbio.UseVisualStyleBackColor = true;
            this.open_addbio.Click += new System.EventHandler(this.open_addbio_Click);
            // 
            // AccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 802);
            this.Controls.Add(this.add_bio_pnl);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CoverPicture);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AccountPage";
            this.Text = "AccountPage";
            this.Load += new System.EventHandler(this.AccountPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPicture)).EndInit();
            this.add_bio_pnl.ResumeLayout(false);
            this.add_bio_pnl.PerformLayout();
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
        private System.Windows.Forms.Panel add_bio_pnl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox addbio_info;
        private System.Windows.Forms.Button open_addbio;
    }
}