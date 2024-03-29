﻿namespace WindowsFormsApp7
{
    partial class WelcomePage
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
            this.username_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.login_bn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.WelcomeToSNHUBook = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.BackColor = System.Drawing.Color.Transparent;
            this.username_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.Image = global::WindowsFormsApp7.Properties.Resources.gradient;
            this.username_lbl.Location = new System.Drawing.Point(296, 220);
            this.username_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(62, 28);
            this.username_lbl.TabIndex = 1;
            this.username_lbl.Text = "Email:";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.BackColor = System.Drawing.Color.Transparent;
            this.password_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Image = global::WindowsFormsApp7.Properties.Resources.gradient;
            this.password_lbl.Location = new System.Drawing.Point(271, 273);
            this.password_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(95, 28);
            this.password_lbl.TabIndex = 3;
            this.password_lbl.Text = "Password:";
            // 
            // login_bn
            // 
            this.login_bn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.login_bn.Location = new System.Drawing.Point(413, 336);
            this.login_bn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login_bn.Name = "login_bn";
            this.login_bn.Size = new System.Drawing.Size(59, 30);
            this.login_bn.TabIndex = 4;
            this.login_bn.Text = "Login";
            this.login_bn.UseVisualStyleBackColor = true;
            this.login_bn.Click += new System.EventHandler(this.login_bn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(319, 336);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sign Up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 229);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(361, 282);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // WelcomeToSNHUBook
            // 
            this.WelcomeToSNHUBook.AutoSize = true;
            this.WelcomeToSNHUBook.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeToSNHUBook.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeToSNHUBook.ForeColor = System.Drawing.Color.Gold;
            this.WelcomeToSNHUBook.Image = global::WindowsFormsApp7.Properties.Resources.gradient;
            this.WelcomeToSNHUBook.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.WelcomeToSNHUBook.Location = new System.Drawing.Point(217, 168);
            this.WelcomeToSNHUBook.Name = "WelcomeToSNHUBook";
            this.WelcomeToSNHUBook.Size = new System.Drawing.Size(364, 37);
            this.WelcomeToSNHUBook.TabIndex = 9;
            this.WelcomeToSNHUBook.Text = "Welcome to SNHUBook";
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.SNHU;
            this.ClientSize = new System.Drawing.Size(790, 446);
            this.Controls.Add(this.WelcomeToSNHUBook);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.login_bn);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_lbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WelcomePage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Button login_bn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label WelcomeToSNHUBook;
    }
}

