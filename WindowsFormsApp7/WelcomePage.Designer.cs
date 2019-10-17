namespace WindowsFormsApp7
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
            this.username_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.username_lbl.Location = new System.Drawing.Point(37, 79);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(102, 24);
            this.username_lbl.Location = new System.Drawing.Point(75, 153);
            this.username_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(120, 42);
            this.username_lbl.TabIndex = 1;
            this.username_lbl.Text = "Email:";
            this.username_lbl.Click += new System.EventHandler(this.username_lbl_Click);
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.password_lbl.Location = new System.Drawing.Point(37, 144);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(97, 24);
            this.password_lbl.Location = new System.Drawing.Point(75, 279);
            this.password_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(193, 42);
            this.password_lbl.TabIndex = 3;
            this.password_lbl.Text = "Password:";
            // 
            // login_bn
            // 
            this.login_bn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.login_bn.Location = new System.Drawing.Point(216, 213);
            this.login_bn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_bn.Name = "login_bn";
            this.login_bn.Size = new System.Drawing.Size(79, 37);
            this.login_bn.Location = new System.Drawing.Point(432, 413);
            this.login_bn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.login_bn.Name = "login_bn";
            this.login_bn.Size = new System.Drawing.Size(157, 72);
            this.login_bn.TabIndex = 4;
            this.login_bn.Text = "Login";
            this.login_bn.UseVisualStyleBackColor = true;
            this.login_bn.Click += new System.EventHandler(this.login_bn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(91, 213);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 37);
            this.button2.Location = new System.Drawing.Point(181, 413);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 72);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sign Up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 81);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 22);
            this.textBox1.Location = new System.Drawing.Point(295, 157);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 38);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 146);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "(hint: your email is the username)";
            // 
            this.textBox2.Location = new System.Drawing.Point(295, 284);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(429, 38);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // WelcomeToSNHUBook
            // 
            this.WelcomeToSNHUBook.AutoSize = true;
            this.WelcomeToSNHUBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeToSNHUBook.Location = new System.Drawing.Point(47, 26);
            this.WelcomeToSNHUBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeToSNHUBook.Name = "WelcomeToSNHUBook";
            this.WelcomeToSNHUBook.Size = new System.Drawing.Size(303, 31);
            this.WelcomeToSNHUBook.Location = new System.Drawing.Point(93, 50);
            this.WelcomeToSNHUBook.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.WelcomeToSNHUBook.Name = "WelcomeToSNHUBook";
            this.WelcomeToSNHUBook.Size = new System.Drawing.Size(589, 61);
            this.WelcomeToSNHUBook.TabIndex = 9;
            this.WelcomeToSNHUBook.Text = "Welcome to SNHUBook";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 314);
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 608);
            this.Controls.Add(this.WelcomeToSNHUBook);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.login_bn);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_lbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
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

