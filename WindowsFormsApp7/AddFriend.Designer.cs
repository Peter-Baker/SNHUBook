namespace WindowsFormsApp7
{
    partial class TagFriend
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
            this.ListOfFriends = new System.Windows.Forms.ListBox();
            this.Select_bn = new System.Windows.Forms.Button();
            this.select_friend_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListOfFriends
            // 
            this.ListOfFriends.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfFriends.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ListOfFriends.FormattingEnabled = true;
            this.ListOfFriends.ItemHeight = 23;
            this.ListOfFriends.Location = new System.Drawing.Point(148, 2);
            this.ListOfFriends.Name = "ListOfFriends";
            this.ListOfFriends.Size = new System.Drawing.Size(452, 418);
            this.ListOfFriends.TabIndex = 0;
            // 
            // Select_bn
            // 
            this.Select_bn.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_bn.Location = new System.Drawing.Point(25, 79);
            this.Select_bn.Name = "Select_bn";
            this.Select_bn.Size = new System.Drawing.Size(97, 37);
            this.Select_bn.TabIndex = 1;
            this.Select_bn.Text = "Select";
            this.Select_bn.UseVisualStyleBackColor = true;
            this.Select_bn.Click += new System.EventHandler(this.Select_bn_Click);
            // 
            // select_friend_lbl
            // 
            this.select_friend_lbl.AutoSize = true;
            this.select_friend_lbl.BackColor = System.Drawing.Color.Transparent;
            this.select_friend_lbl.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_friend_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.select_friend_lbl.Location = new System.Drawing.Point(5, 9);
            this.select_friend_lbl.Name = "select_friend_lbl";
            this.select_friend_lbl.Size = new System.Drawing.Size(137, 25);
            this.select_friend_lbl.TabIndex = 2;
            this.select_friend_lbl.Text = "Select Friend";
            this.select_friend_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // TagFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.blue_gradient_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 430);
            this.Controls.Add(this.select_friend_lbl);
            this.Controls.Add(this.Select_bn);
            this.Controls.Add(this.ListOfFriends);
            this.Name = "TagFriend";
            this.Text = "TagFriend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListOfFriends;
        private System.Windows.Forms.Button Select_bn;
        private System.Windows.Forms.Label select_friend_lbl;
    }
}