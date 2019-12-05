namespace WindowsFormsApp7
{
    partial class AddBackground
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
            this.selectImageText = new System.Windows.Forms.Label();
            this.CancelButtonProfilePhoto = new System.Windows.Forms.Button();
            this.BackgroundImage4 = new System.Windows.Forms.PictureBox();
            this.BackgroundImage3 = new System.Windows.Forms.PictureBox();
            this.BackgroundImage2 = new System.Windows.Forms.PictureBox();
            this.BackgroundImage1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectImageText
            // 
            this.selectImageText.AutoSize = true;
            this.selectImageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectImageText.Location = new System.Drawing.Point(627, 141);
            this.selectImageText.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.selectImageText.Name = "selectImageText";
            this.selectImageText.Size = new System.Drawing.Size(766, 78);
            this.selectImageText.TabIndex = 1;
            this.selectImageText.Text = "Select an Image Below:";
            // 
            // CancelButtonProfilePhoto
            // 
            this.CancelButtonProfilePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButtonProfilePhoto.Location = new System.Drawing.Point(883, 723);
            this.CancelButtonProfilePhoto.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CancelButtonProfilePhoto.Name = "CancelButtonProfilePhoto";
            this.CancelButtonProfilePhoto.Size = new System.Drawing.Size(325, 117);
            this.CancelButtonProfilePhoto.TabIndex = 6;
            this.CancelButtonProfilePhoto.Text = "Cancel";
            this.CancelButtonProfilePhoto.UseVisualStyleBackColor = true;
            this.CancelButtonProfilePhoto.Click += new System.EventHandler(this.CancelButtonProfilePhoto_Click);
            // 
            // BackgroundImage4
            // 
            this.BackgroundImage4.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage4.Image = global::WindowsFormsApp7.Properties.Resources.Background4;
            this.BackgroundImage4.Location = new System.Drawing.Point(1627, 343);
            this.BackgroundImage4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BackgroundImage4.Name = "BackgroundImage4";
            this.BackgroundImage4.Size = new System.Drawing.Size(435, 267);
            this.BackgroundImage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundImage4.TabIndex = 5;
            this.BackgroundImage4.TabStop = false;
            this.BackgroundImage4.Click += new System.EventHandler(this.BackgroundImage4_Click);
            // 
            // BackgroundImage3
            // 
            this.BackgroundImage3.Image = global::WindowsFormsApp7.Properties.Resources.Background3;
            this.BackgroundImage3.Location = new System.Drawing.Point(1104, 343);
            this.BackgroundImage3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BackgroundImage3.Name = "BackgroundImage3";
            this.BackgroundImage3.Size = new System.Drawing.Size(435, 267);
            this.BackgroundImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundImage3.TabIndex = 4;
            this.BackgroundImage3.TabStop = false;
            this.BackgroundImage3.Click += new System.EventHandler(this.BackgroundImage3_Click);
            // 
            // BackgroundImage2
            // 
            this.BackgroundImage2.Image = global::WindowsFormsApp7.Properties.Resources.Background2;
            this.BackgroundImage2.Location = new System.Drawing.Point(584, 343);
            this.BackgroundImage2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BackgroundImage2.Name = "BackgroundImage2";
            this.BackgroundImage2.Size = new System.Drawing.Size(435, 267);
            this.BackgroundImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundImage2.TabIndex = 3;
            this.BackgroundImage2.TabStop = false;
            this.BackgroundImage2.Click += new System.EventHandler(this.BackgroundImage2_Click);
            // 
            // BackgroundImage1
            // 
            this.BackgroundImage1.Image = global::WindowsFormsApp7.Properties.Resources._10759301728_IMG_9920;
            this.BackgroundImage1.Location = new System.Drawing.Point(61, 343);
            this.BackgroundImage1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BackgroundImage1.Name = "BackgroundImage1";
            this.BackgroundImage1.Size = new System.Drawing.Size(435, 267);
            this.BackgroundImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundImage1.TabIndex = 2;
            this.BackgroundImage1.TabStop = false;
            this.BackgroundImage1.Click += new System.EventHandler(this.BackgroundImage1_Click);
            // 
            // AddBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.blue_gradient_background;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.CancelButtonProfilePhoto);
            this.Controls.Add(this.BackgroundImage4);
            this.Controls.Add(this.BackgroundImage3);
            this.Controls.Add(this.BackgroundImage2);
            this.Controls.Add(this.BackgroundImage1);
            this.Controls.Add(this.selectImageText);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AddBackground";
            this.Text = "AddBackground";
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectImageText;
        private System.Windows.Forms.PictureBox BackgroundImage1;
        private System.Windows.Forms.PictureBox BackgroundImage2;
        private System.Windows.Forms.PictureBox BackgroundImage3;
        private System.Windows.Forms.PictureBox BackgroundImage4;
        private System.Windows.Forms.Button CancelButtonProfilePhoto;
    }
}