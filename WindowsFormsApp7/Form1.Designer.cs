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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Submit_post_button = new System.Windows.Forms.Button();
            this.Create_Post_lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deletePostPanel = new System.Windows.Forms.Panel();
            this.deletePostSubmitButton = new System.Windows.Forms.Button();
            this.selectToDeleteText = new System.Windows.Forms.Label();
            this.postsTooDelete = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPicture)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.deletePostPanel.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 344);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 118);
            this.panel1.TabIndex = 7;
            // 
            // add_home_bn
            // 
            this.add_home_bn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_home_bn.Location = new System.Drawing.Point(161, 90);
            this.add_home_bn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_home_bn.Name = "add_home_bn";
            this.add_home_bn.Size = new System.Drawing.Size(59, 28);
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
            this.home_lbl.Location = new System.Drawing.Point(58, 69);
            this.home_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.home_lbl.Name = "home_lbl";
            this.home_lbl.Size = new System.Drawing.Size(0, 20);
            this.home_lbl.TabIndex = 15;
            // 
            // cancel_home_bn
            // 
            this.cancel_home_bn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_home_bn.Location = new System.Drawing.Point(54, 90);
            this.cancel_home_bn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel_home_bn.Name = "cancel_home_bn";
            this.cancel_home_bn.Size = new System.Drawing.Size(65, 28);
            this.cancel_home_bn.TabIndex = 15;
            this.cancel_home_bn.Text = "Cancel";
            this.cancel_home_bn.UseVisualStyleBackColor = true;
            this.cancel_home_bn.Click += new System.EventHandler(this.cancel_home_bn_Click);
            // 
            // hometown_text
            // 
            this.hometown_text.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hometown_text.Location = new System.Drawing.Point(55, 68);
            this.hometown_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hometown_text.Multiline = true;
            this.hometown_text.Name = "hometown_text";
            this.hometown_text.Size = new System.Drawing.Size(167, 25);
            this.hometown_text.TabIndex = 10;
            this.hometown_text.TextChanged += new System.EventHandler(this.hometown_text_TextChanged);
            // 
            // AddBio_Text
            // 
            this.AddBio_Text.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBio_Text.Location = new System.Drawing.Point(54, 46);
            this.AddBio_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddBio_Text.Multiline = true;
            this.AddBio_Text.Name = "AddBio_Text";
            this.AddBio_Text.Size = new System.Drawing.Size(168, 22);
            this.AddBio_Text.TabIndex = 9;
            this.AddBio_Text.TextChanged += new System.EventHandler(this.AddBio_Text_TextChanged);
            // 
            // hometown_lbl
            // 
            this.hometown_lbl.AutoSize = true;
            this.hometown_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hometown_lbl.ForeColor = System.Drawing.Color.Gold;
            this.hometown_lbl.Location = new System.Drawing.Point(5, 68);
            this.hometown_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hometown_lbl.Name = "hometown_lbl";
            this.hometown_lbl.Size = new System.Drawing.Size(49, 21);
            this.hometown_lbl.TabIndex = 13;
            this.hometown_lbl.Text = "From:";
            this.hometown_lbl.Click += new System.EventHandler(this.hometown_lbl_Click);
            // 
            // Add_bn
            // 
            this.Add_bn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_bn.Location = new System.Drawing.Point(150, 70);
            this.Add_bn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add_bn.Name = "Add_bn";
            this.Add_bn.Size = new System.Drawing.Size(67, 25);
            this.Add_bn.TabIndex = 12;
            this.Add_bn.Text = "Add";
            this.Add_bn.UseVisualStyleBackColor = true;
            this.Add_bn.Click += new System.EventHandler(this.Add_bn_Click);
            // 
            // Cancel_bn
            // 
            this.Cancel_bn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_bn.Location = new System.Drawing.Point(56, 70);
            this.Cancel_bn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancel_bn.Name = "Cancel_bn";
            this.Cancel_bn.Size = new System.Drawing.Size(67, 25);
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
            this.Bio_lbl.Location = new System.Drawing.Point(41, 46);
            this.Bio_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bio_lbl.Name = "Bio_lbl";
            this.Bio_lbl.Size = new System.Drawing.Size(38, 20);
            this.Bio_lbl.TabIndex = 2;
            this.Bio_lbl.Text = "None";
            this.Bio_lbl.Click += new System.EventHandler(this.Bio_lbl_Click);
            // 
            // Biography
            // 
            this.Biography.AutoSize = true;
            this.Biography.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biography.ForeColor = System.Drawing.Color.Gold;
            this.Biography.Location = new System.Drawing.Point(5, 44);
            this.Biography.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Biography.Name = "Biography";
            this.Biography.Size = new System.Drawing.Size(36, 21);
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
            this.username_lbl.Location = new System.Drawing.Point(2, 15);
            this.username_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(111, 28);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "UserName";
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.nyc;
            this.ProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePicture.Location = new System.Drawing.Point(8, 48);
            this.ProfilePicture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(122, 132);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 43);
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
            this.settings_button.Location = new System.Drawing.Point(977, 20);
            this.settings_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.FriendRequest_button.Location = new System.Drawing.Point(790, 13);
            this.FriendRequest_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.home_button.Location = new System.Drawing.Point(681, 13);
            this.home_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.user_button.Location = new System.Drawing.Point(572, 13);
            this.user_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 588);
            this.panel3.TabIndex = 9;
            // 
            // CoverPicture
            // 
            this.CoverPicture.BackgroundImage = global::WindowsFormsApp7.Properties.Resources._10759301728_IMG_9920;
            this.CoverPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CoverPicture.Location = new System.Drawing.Point(0, 7);
            this.CoverPicture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CoverPicture.Name = "CoverPicture";
            this.CoverPicture.Size = new System.Drawing.Size(1024, 397);
            this.CoverPicture.TabIndex = 5;
            this.CoverPicture.TabStop = false;
            this.CoverPicture.Click += new System.EventHandler(this.CoverPicture_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.blue_gradient_background;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(248, 666);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(730, 109);
            this.panel4.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(674, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delete";
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.blue_gradient_background;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.Controls.Add(this.Submit_post_button);
            this.panel5.Controls.Add(this.Create_Post_lbl);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Location = new System.Drawing.Point(248, 471);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(730, 181);
            this.panel5.TabIndex = 10;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // Submit_post_button
            // 
            this.Submit_post_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Submit_post_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Submit_post_button.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_post_button.Location = new System.Drawing.Point(617, 141);
            this.Submit_post_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(10, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(710, 108);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // deletePostPanel
            // 
            this.deletePostPanel.BackColor = System.Drawing.Color.Transparent;
            this.deletePostPanel.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.blue_gradient_background;
            this.deletePostPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletePostPanel.Controls.Add(this.postsTooDelete);
            this.deletePostPanel.Controls.Add(this.deletePostSubmitButton);
            this.deletePostPanel.Controls.Add(this.selectToDeleteText);
            this.deletePostPanel.Location = new System.Drawing.Point(4, 471);
            this.deletePostPanel.Margin = new System.Windows.Forms.Padding(2);
            this.deletePostPanel.Name = "deletePostPanel";
            this.deletePostPanel.Size = new System.Drawing.Size(233, 170);
            this.deletePostPanel.TabIndex = 11;
            // 
            // deletePostSubmitButton
            // 
            this.deletePostSubmitButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletePostSubmitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.deletePostSubmitButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePostSubmitButton.Location = new System.Drawing.Point(139, 135);
            this.deletePostSubmitButton.Margin = new System.Windows.Forms.Padding(2);
            this.deletePostSubmitButton.Name = "deletePostSubmitButton";
            this.deletePostSubmitButton.Size = new System.Drawing.Size(80, 29);
            this.deletePostSubmitButton.TabIndex = 4;
            this.deletePostSubmitButton.Text = "Submit";
            this.deletePostSubmitButton.UseVisualStyleBackColor = false;
            this.deletePostSubmitButton.Click += new System.EventHandler(this.deletePostSubmitButton_Click);
            // 
            // selectToDeleteText
            // 
            this.selectToDeleteText.AutoSize = true;
            this.selectToDeleteText.BackColor = System.Drawing.Color.Transparent;
            this.selectToDeleteText.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectToDeleteText.ForeColor = System.Drawing.Color.Gold;
            this.selectToDeleteText.Location = new System.Drawing.Point(11, 0);
            this.selectToDeleteText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectToDeleteText.Name = "selectToDeleteText";
            this.selectToDeleteText.Size = new System.Drawing.Size(225, 28);
            this.selectToDeleteText.TabIndex = 3;
            this.selectToDeleteText.Text = "Select Post to Delete ";
            // 
            // postsTooDelete
            // 
            this.postsTooDelete.FormattingEnabled = true;
            this.postsTooDelete.Location = new System.Drawing.Point(15, 24);
            this.postsTooDelete.Name = "postsTooDelete";
            this.postsTooDelete.Size = new System.Drawing.Size(204, 108);
            this.postsTooDelete.TabIndex = 5;
            // 
            // AccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1005, 687);
            this.Controls.Add(this.deletePostPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CoverPicture);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AccountPage";
            this.Text = "AccountPage";
            this.Load += new System.EventHandler(this.AccountPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPicture)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.deletePostPanel.ResumeLayout(false);
            this.deletePostPanel.PerformLayout();
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Submit_post_button;
        private System.Windows.Forms.Label Create_Post_lbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel deletePostPanel;
        private System.Windows.Forms.ListBox postsTooDelete;
        private System.Windows.Forms.Button deletePostSubmitButton;
        private System.Windows.Forms.Label selectToDeleteText;
    }
}