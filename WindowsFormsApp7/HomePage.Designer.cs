﻿



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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.settings_button = new System.Windows.Forms.Button();
            this.FriendRequest_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.user_button = new System.Windows.Forms.Button();
            this.SNHUbook_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(10, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(710, 108);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.blue_gradient_background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.Submit_post_button);
            this.panel1.Controls.Add(this.Create_Post_lbl);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(157, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 181);
            this.panel1.TabIndex = 2;
            // 
            // Submit_post_button
            // 
            this.Submit_post_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Submit_post_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Submit_post_button.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_post_button.Location = new System.Drawing.Point(617, 141);
            this.Submit_post_button.Margin = new System.Windows.Forms.Padding(2);
            this.Submit_post_button.Name = "Submit_post_button";
            this.Submit_post_button.Size = new System.Drawing.Size(80, 29);
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
            this.Create_Post_lbl.Location = new System.Drawing.Point(11, 0);
            this.Create_Post_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Create_Post_lbl.Name = "Create_Post_lbl";
            this.Create_Post_lbl.Size = new System.Drawing.Size(145, 28);
            this.Create_Post_lbl.TabIndex = 3;
            this.Create_Post_lbl.Text = "Create a Post";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.blue_gradient_background;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.settings_button);
            this.panel2.Controls.Add(this.FriendRequest_button);
            this.panel2.Controls.Add(this.home_button);
            this.panel2.Controls.Add(this.user_button);
            this.panel2.Controls.Add(this.SNHUbook_lbl);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 43);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.FemaleAvatar1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(465, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // settings_button
            // 
            this.settings_button.BackColor = System.Drawing.Color.Transparent;
            this.settings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings_button.FlatAppearance.BorderSize = 0;
            this.settings_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.settings_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_button.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settings_button.Image = global::WindowsFormsApp7.Properties.Resources.setting_icon;
            this.settings_button.Location = new System.Drawing.Point(867, 18);
            this.settings_button.Margin = new System.Windows.Forms.Padding(2);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(19, 20);
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
            this.FriendRequest_button.Location = new System.Drawing.Point(684, 13);
            this.FriendRequest_button.Margin = new System.Windows.Forms.Padding(2);
            this.FriendRequest_button.Name = "FriendRequest_button";
            this.FriendRequest_button.Size = new System.Drawing.Size(131, 30);
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
            this.home_button.Location = new System.Drawing.Point(585, 13);
            this.home_button.Margin = new System.Windows.Forms.Padding(2);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(104, 30);
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
            this.user_button.Location = new System.Drawing.Point(489, 13);
            this.user_button.Margin = new System.Windows.Forms.Padding(2);
            this.user_button.Name = "user_button";
            this.user_button.Size = new System.Drawing.Size(104, 30);
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
            this.SNHUbook_lbl.Location = new System.Drawing.Point(2, 2);
            this.SNHUbook_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SNHUbook_lbl.Name = "SNHUbook_lbl";
            this.SNHUbook_lbl.Size = new System.Drawing.Size(167, 38);
            this.SNHUbook_lbl.TabIndex = 0;
            this.SNHUbook_lbl.Text = "SNHUbook";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Location = new System.Drawing.Point(1, 41);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 734);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.blue_gradient_background;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(157, 317);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(730, 109);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "I want to see how this works";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 690);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Create_Post_lbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SNHUbook_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button user_button;
        private System.Windows.Forms.Button FriendRequest_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button Submit_post_button;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}