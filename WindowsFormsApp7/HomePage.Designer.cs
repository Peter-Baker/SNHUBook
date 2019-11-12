namespace WindowsFormsApp7
{
    partial class HomePage
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Submit_post_button = new System.Windows.Forms.Button();
            this.Create_Post_lbl = new System.Windows.Forms.Label();
            this.Check_In = new System.Windows.Forms.Button();
            this.Tag_button = new System.Windows.Forms.Button();
            this.Photo_Video = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.settings_button = new System.Windows.Forms.Button();
            this.FriendRequest_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_button = new System.Windows.Forms.Button();
            this.SNHUbook_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Groups_lbl = new System.Windows.Forms.Label();
            this.Messages_Button = new System.Windows.Forms.Button();
            this.Recent_Posts = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.post_text = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(945, 132);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.Submit_post_button);
            this.panel1.Controls.Add(this.Create_Post_lbl);
            this.panel1.Controls.Add(this.Check_In);
            this.panel1.Controls.Add(this.Tag_button);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Photo_Video);
            this.panel1.Location = new System.Drawing.Point(209, 150);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 223);
            this.panel1.TabIndex = 2;
            // 
            // Submit_post_button
            // 
            this.Submit_post_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Submit_post_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Submit_post_button.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_post_button.Location = new System.Drawing.Point(823, 174);
            this.Submit_post_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Submit_post_button.Name = "Submit_post_button";
            this.Submit_post_button.Size = new System.Drawing.Size(107, 36);
            this.Submit_post_button.TabIndex = 4;
            this.Submit_post_button.Text = "Submit";
            this.Submit_post_button.UseVisualStyleBackColor = false;
            this.Submit_post_button.Click += new System.EventHandler(this.Submit_post_button_Click);
            // 
            // Create_Post_lbl
            // 
            this.Create_Post_lbl.AutoSize = true;
            this.Create_Post_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Create_Post_lbl.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Post_lbl.ForeColor = System.Drawing.Color.Gold;
            this.Create_Post_lbl.Location = new System.Drawing.Point(15, 0);
            this.Create_Post_lbl.Name = "Create_Post_lbl";
            this.Create_Post_lbl.Size = new System.Drawing.Size(182, 36);
            this.Create_Post_lbl.TabIndex = 3;
            this.Create_Post_lbl.Text = "Create a Post";
            // 
            // Check_In
            // 
            this.Check_In.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Check_In.Cursor = System.Windows.Forms.Cursors.Default;
            this.Check_In.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_In.Location = new System.Drawing.Point(451, 174);
            this.Check_In.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Check_In.Name = "Check_In";
            this.Check_In.Size = new System.Drawing.Size(107, 36);
            this.Check_In.TabIndex = 2;
            this.Check_In.Text = "Check In";
            this.Check_In.UseVisualStyleBackColor = false;
            this.Check_In.Click += new System.EventHandler(this.Check_In_Click);
            // 
            // Tag_button
            // 
            this.Tag_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tag_button.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tag_button.Location = new System.Drawing.Point(271, 174);
            this.Tag_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tag_button.Name = "Tag_button";
            this.Tag_button.Size = new System.Drawing.Size(115, 36);
            this.Tag_button.TabIndex = 1;
            this.Tag_button.Text = "Tag Friends";
            this.Tag_button.UseVisualStyleBackColor = false;
            // 
            // Photo_Video
            // 
            this.Photo_Video.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Photo_Video.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Photo_Video.Location = new System.Drawing.Point(88, 174);
            this.Photo_Video.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Photo_Video.Name = "Photo_Video";
            this.Photo_Video.Size = new System.Drawing.Size(120, 36);
            this.Photo_Video.TabIndex = 0;
            this.Photo_Video.Text = "Photo/Video";
            this.Photo_Video.UseVisualStyleBackColor = false;
            this.Photo_Video.Click += new System.EventHandler(this.Photo_Video_Click);
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
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1228, 53);
            this.panel2.TabIndex = 3;
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
            this.settings_button.Location = new System.Drawing.Point(1156, 22);
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
            this.FriendRequest_button.Location = new System.Drawing.Point(912, 16);
            this.FriendRequest_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FriendRequest_button.Name = "FriendRequest_button";
            this.FriendRequest_button.Size = new System.Drawing.Size(175, 37);
            this.FriendRequest_button.TabIndex = 7;
            this.FriendRequest_button.Text = "Friend Requests";
            this.FriendRequest_button.UseVisualStyleBackColor = false;
            this.FriendRequest_button.Click += new System.EventHandler(this.FriendRequest_button_Click);
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
            this.home_button.Location = new System.Drawing.Point(780, 16);
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
            this.pictureBox1.Location = new System.Drawing.Point(607, 9);
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
            this.user_button.Location = new System.Drawing.Point(652, 16);
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
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Controls.Add(this.Groups_lbl);
            this.panel3.Controls.Add(this.Messages_Button);
            this.panel3.Controls.Add(this.Recent_Posts);
            this.panel3.Location = new System.Drawing.Point(1, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 564);
            this.panel3.TabIndex = 4;
            // 
            // Groups_lbl
            // 
            this.Groups_lbl.AutoSize = true;
            this.Groups_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groups_lbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Groups_lbl.Location = new System.Drawing.Point(20, 134);
            this.Groups_lbl.Name = "Groups_lbl";
            this.Groups_lbl.Size = new System.Drawing.Size(67, 24);
            this.Groups_lbl.TabIndex = 2;
            this.Groups_lbl.Text = "Groups";
            // 
            // Messages_Button
            // 
            this.Messages_Button.BackColor = System.Drawing.Color.Transparent;
            this.Messages_Button.FlatAppearance.BorderSize = 0;
            this.Messages_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Messages_Button.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messages_Button.Location = new System.Drawing.Point(25, 82);
            this.Messages_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Messages_Button.Name = "Messages_Button";
            this.Messages_Button.Size = new System.Drawing.Size(139, 31);
            this.Messages_Button.TabIndex = 1;
            this.Messages_Button.Text = "Messages";
            this.Messages_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Messages_Button.UseVisualStyleBackColor = false;
            // 
            // Recent_Posts
            // 
            this.Recent_Posts.BackColor = System.Drawing.Color.Transparent;
            this.Recent_Posts.FlatAppearance.BorderSize = 0;
            this.Recent_Posts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Recent_Posts.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recent_Posts.Location = new System.Drawing.Point(25, 30);
            this.Recent_Posts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Recent_Posts.Name = "Recent_Posts";
            this.Recent_Posts.Size = new System.Drawing.Size(139, 31);
            this.Recent_Posts.TabIndex = 0;
            this.Recent_Posts.Text = "Recent Posts";
            this.Recent_Posts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Recent_Posts.UseVisualStyleBackColor = false;
            this.Recent_Posts.Click += new System.EventHandler(this.Recent_Posts_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.post_text);
            this.panel4.Controls.Add(this.date_lbl);
            this.panel4.Location = new System.Drawing.Point(209, 411);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(973, 170);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint_1);
            // 
            // post_text
            // 
            this.post_text.AutoSize = true;
            this.post_text.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_text.ForeColor = System.Drawing.SystemColors.Window;
            this.post_text.Location = new System.Drawing.Point(39, 55);
            this.post_text.Name = "post_text";
            this.post_text.Size = new System.Drawing.Size(17, 25);
            this.post_text.TabIndex = 2;
            this.post_text.Text = "l";
            this.post_text.Click += new System.EventHandler(this.post_text_Click);
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.date_lbl.Location = new System.Drawing.Point(39, 15);
            this.date_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(57, 25);
            this.date_lbl.TabIndex = 1;
            this.date_lbl.Text = "Date:";
            this.date_lbl.Click += new System.EventHandler(this.date_lbl_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1253, 597);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomePage";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Create_Post_lbl;
        private System.Windows.Forms.Button Check_In;
        private System.Windows.Forms.Button Tag_button;
        private System.Windows.Forms.Button Photo_Video;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SNHUbook_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Recent_Posts;
        private System.Windows.Forms.Button Messages_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button user_button;
        private System.Windows.Forms.Label Groups_lbl;
        private System.Windows.Forms.Button FriendRequest_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button Submit_post_button;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label post_text;
    }
}