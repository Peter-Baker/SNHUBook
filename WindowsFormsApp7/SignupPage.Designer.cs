namespace WindowsFormsApp7
{
    partial class SignUp
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
            this.firstname_textbox = new System.Windows.Forms.TextBox();
            this.lastname_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.firstname_lbl = new System.Windows.Forms.Label();
            this.lastname_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.WelcomeToSNHUBook = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstname_textbox
            // 
            this.firstname_textbox.Location = new System.Drawing.Point(182, 68);
            this.firstname_textbox.Location = new System.Drawing.Point(1133, 278);
            this.firstname_textbox.Margin = new System.Windows.Forms.Padding(6);
            this.firstname_textbox.Name = "firstname_textbox";
            this.firstname_textbox.Size = new System.Drawing.Size(151, 22);
            this.firstname_textbox.TabIndex = 0;
            this.firstname_textbox.TextChanged += new System.EventHandler(this.firstname_textbox_TextChanged);
            // 
            // lastname_textbox
            // 
            this.lastname_textbox.Location = new System.Drawing.Point(182, 123);
            this.lastname_textbox.Location = new System.Drawing.Point(1133, 384);
            this.lastname_textbox.Margin = new System.Windows.Forms.Padding(6);
            this.lastname_textbox.Name = "lastname_textbox";
            this.lastname_textbox.Size = new System.Drawing.Size(151, 22);
            this.lastname_textbox.TabIndex = 1;
            this.lastname_textbox.TextChanged += new System.EventHandler(this.lastname_textbox_TextChanged);
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(182, 178);
            this.email_textbox.Location = new System.Drawing.Point(1133, 491);
            this.email_textbox.Margin = new System.Windows.Forms.Padding(6);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(151, 22);
            this.email_textbox.TabIndex = 2;
            this.email_textbox.TextChanged += new System.EventHandler(this.email_textbox_TextChanged);
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(182, 234);
            this.password_textbox.Location = new System.Drawing.Point(1133, 599);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(6);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(151, 22);
            this.password_textbox.TabIndex = 3;
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            // 
            // firstname_lbl
            // 
            this.firstname_lbl.AutoSize = true;
            this.firstname_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firstname_lbl.Location = new System.Drawing.Point(52, 68);
            this.firstname_lbl.Location = new System.Drawing.Point(873, 278);
            this.firstname_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.firstname_lbl.Name = "firstname_lbl";
            this.firstname_lbl.Size = new System.Drawing.Size(97, 20);
            this.firstname_lbl.TabIndex = 4;
            this.firstname_lbl.Text = "First Name:";
            // 
            // lastname_lbl
            // 
            this.lastname_lbl.AutoSize = true;
            this.lastname_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lastname_lbl.Location = new System.Drawing.Point(52, 123);
            this.lastname_lbl.Location = new System.Drawing.Point(873, 384);
            this.lastname_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lastname_lbl.Name = "lastname_lbl";
            this.lastname_lbl.Size = new System.Drawing.Size(96, 20);
            this.lastname_lbl.TabIndex = 5;
            this.lastname_lbl.Text = "Last Name:";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.email_lbl.Location = new System.Drawing.Point(92, 178);
            this.email_lbl.Location = new System.Drawing.Point(953, 491);
            this.email_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(56, 20);
            this.email_lbl.TabIndex = 6;
            this.email_lbl.Text = "Email:";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.password_lbl.Location = new System.Drawing.Point(52, 236);
            this.password_lbl.Location = new System.Drawing.Point(873, 603);
            this.password_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(88, 20);
            this.password_lbl.TabIndex = 7;
            this.password_lbl.Text = "Password:";
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.save_button.Location = new System.Drawing.Point(131, 291);
            this.save_button.Location = new System.Drawing.Point(1031, 710);
            this.save_button.Margin = new System.Windows.Forms.Padding(6);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 35);
            this.save_button.TabIndex = 8;
            this.save_button.Text = "Create";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.login.Location = new System.Drawing.Point(258, 291);
            this.login.Location = new System.Drawing.Point(1285, 710);
            this.login.Margin = new System.Windows.Forms.Padding(6);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 35);
            this.login.TabIndex = 9;
            this.login.Text = "Back";
            this.login.Text = "Cancel";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // WelcomeToSNHUBook
            // 
            this.WelcomeToSNHUBook.AutoSize = true;
            this.WelcomeToSNHUBook.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeToSNHUBook.ForeColor = System.Drawing.Color.Gold;
            this.WelcomeToSNHUBook.Location = new System.Drawing.Point(811, 104);
            this.WelcomeToSNHUBook.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.WelcomeToSNHUBook.Name = "WelcomeToSNHUBook";
            this.WelcomeToSNHUBook.Size = new System.Drawing.Size(736, 101);
            this.WelcomeToSNHUBook.TabIndex = 10;
            this.WelcomeToSNHUBook.Text = "Create an Account";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 388);
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(2458, 1192);
            this.Controls.Add(this.WelcomeToSNHUBook);
            this.Controls.Add(this.login);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.lastname_lbl);
            this.Controls.Add(this.firstname_lbl);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.lastname_textbox);
            this.Controls.Add(this.firstname_textbox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstname_textbox;
        private System.Windows.Forms.TextBox lastname_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label firstname_lbl;
        private System.Windows.Forms.Label lastname_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label WelcomeToSNHUBook;
    }
}