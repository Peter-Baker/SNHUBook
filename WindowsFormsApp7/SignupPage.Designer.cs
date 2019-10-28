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
            this.firstname_textbox.Location = new System.Drawing.Point(1141, 266);
            this.firstname_textbox.Location = new System.Drawing.Point(364, 132);
            this.firstname_textbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.firstname_textbox.Name = "firstname_textbox";
            this.firstname_textbox.Size = new System.Drawing.Size(298, 38);
            this.firstname_textbox.TabIndex = 0;
            this.firstname_textbox.TextChanged += new System.EventHandler(this.firstname_textbox_TextChanged);
            // 
            // lastname_textbox
            // 
            this.lastname_textbox.Location = new System.Drawing.Point(1141, 372);
            this.lastname_textbox.Location = new System.Drawing.Point(364, 238);
            this.lastname_textbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lastname_textbox.Name = "lastname_textbox";
            this.lastname_textbox.Size = new System.Drawing.Size(298, 38);
            this.lastname_textbox.TabIndex = 1;
            this.lastname_textbox.TextChanged += new System.EventHandler(this.lastname_textbox_TextChanged);
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(1141, 479);
            this.email_textbox.Location = new System.Drawing.Point(364, 345);
            this.email_textbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(298, 38);
            this.email_textbox.TabIndex = 2;
            this.email_textbox.TextChanged += new System.EventHandler(this.email_textbox_TextChanged);
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(1141, 591);
            this.password_textbox.Location = new System.Drawing.Point(364, 453);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(298, 38);
            this.password_textbox.TabIndex = 3;
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            // 
            // firstname_lbl
            // 
            this.firstname_lbl.AutoSize = true;
            this.firstname_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_lbl.Location = new System.Drawing.Point(881, 245);
            this.firstname_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.firstname_lbl.Name = "firstname_lbl";
            this.firstname_lbl.Size = new System.Drawing.Size(255, 68);
            this.firstname_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firstname_lbl.Location = new System.Drawing.Point(104, 132);
            this.firstname_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.firstname_lbl.Name = "firstname_lbl";
            this.firstname_lbl.Size = new System.Drawing.Size(192, 39);
            this.firstname_lbl.TabIndex = 4;
            this.firstname_lbl.Text = "First Name:";
            // 
            // lastname_lbl
            // 
            this.lastname_lbl.AutoSize = true;
            this.lastname_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_lbl.Location = new System.Drawing.Point(884, 351);
            this.lastname_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lastname_lbl.Name = "lastname_lbl";
            this.lastname_lbl.Size = new System.Drawing.Size(252, 68);
            this.lastname_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lastname_lbl.Location = new System.Drawing.Point(104, 238);
            this.lastname_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lastname_lbl.Name = "lastname_lbl";
            this.lastname_lbl.Size = new System.Drawing.Size(190, 39);
            this.lastname_lbl.TabIndex = 5;
            this.lastname_lbl.Text = "Last Name:";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.Location = new System.Drawing.Point(982, 458);
            this.email_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(154, 68);
            this.email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.email_lbl.Location = new System.Drawing.Point(184, 345);
            this.email_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(112, 39);
            this.email_lbl.TabIndex = 6;
            this.email_lbl.Text = "Email:";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(884, 570);
            this.password_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(232, 68);
            this.password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.password_lbl.Location = new System.Drawing.Point(104, 457);
            this.password_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(176, 39);
            this.password_lbl.TabIndex = 7;
            this.password_lbl.Text = "Password:";
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.save_button.Location = new System.Drawing.Point(1248, 685);
            this.save_button.Location = new System.Drawing.Point(262, 564);
            this.save_button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(150, 68);
            this.save_button.TabIndex = 8;
            this.save_button.Text = "Create";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.login.Location = new System.Drawing.Point(1014, 685);
            this.login.Location = new System.Drawing.Point(516, 564);
            this.login.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(150, 68);
            this.login.TabIndex = 9;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(2458, 1192);
            this.Controls.Add(this.WelcomeToSNHUBook);
            this.ClientSize = new System.Drawing.Size(802, 752);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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