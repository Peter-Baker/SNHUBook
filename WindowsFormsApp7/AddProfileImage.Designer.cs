namespace WindowsFormsApp7
{
    partial class AddProfileImage
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
            this.profileImageFour = new System.Windows.Forms.PictureBox();
            this.profileImageThree = new System.Windows.Forms.PictureBox();
            this.profileImageTwo = new System.Windows.Forms.PictureBox();
            this.profileImageOne = new System.Windows.Forms.PictureBox();
            this.CancelButtonProfilePhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profileImageFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImageThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImageTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImageOne)).BeginInit();
            this.SuspendLayout();
            // 
            // selectImageText
            // 
            this.selectImageText.AutoSize = true;
            this.selectImageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectImageText.Location = new System.Drawing.Point(294, 78);
            this.selectImageText.Name = "selectImageText";
            this.selectImageText.Size = new System.Drawing.Size(320, 31);
            this.selectImageText.TabIndex = 0;
            this.selectImageText.Text = "Select an Image Below:";
            // 
            // profileImageFour
            // 
            this.profileImageFour.Image = global::WindowsFormsApp7.Properties.Resources.FemaleAvatar2;
            this.profileImageFour.Location = new System.Drawing.Point(711, 138);
            this.profileImageFour.Name = "profileImageFour";
            this.profileImageFour.Size = new System.Drawing.Size(140, 140);
            this.profileImageFour.TabIndex = 4;
            this.profileImageFour.TabStop = false;
            this.profileImageFour.Click += new System.EventHandler(this.profileImageFour_Click);
            // 
            // profileImageThree
            // 
            this.profileImageThree.Image = global::WindowsFormsApp7.Properties.Resources.FemaleAvatar1;
            this.profileImageThree.Location = new System.Drawing.Point(488, 138);
            this.profileImageThree.Name = "profileImageThree";
            this.profileImageThree.Size = new System.Drawing.Size(140, 140);
            this.profileImageThree.TabIndex = 3;
            this.profileImageThree.TabStop = false;
            this.profileImageThree.Click += new System.EventHandler(this.profileImageThree_Click);
            // 
            // profileImageTwo
            // 
            this.profileImageTwo.Image = global::WindowsFormsApp7.Properties.Resources.MaleAvatar2;
            this.profileImageTwo.Location = new System.Drawing.Point(273, 138);
            this.profileImageTwo.Name = "profileImageTwo";
            this.profileImageTwo.Size = new System.Drawing.Size(140, 140);
            this.profileImageTwo.TabIndex = 2;
            this.profileImageTwo.TabStop = false;
            this.profileImageTwo.Click += new System.EventHandler(this.profileImageTwo_Click);
            // 
            // profileImageOne
            // 
            this.profileImageOne.Image = global::WindowsFormsApp7.Properties.Resources.MaleAvatar1;
            this.profileImageOne.Location = new System.Drawing.Point(75, 138);
            this.profileImageOne.Name = "profileImageOne";
            this.profileImageOne.Size = new System.Drawing.Size(140, 140);
            this.profileImageOne.TabIndex = 1;
            this.profileImageOne.TabStop = false;
            this.profileImageOne.Click += new System.EventHandler(this.profileImageOne_Click);
            // 
            // CancelButtonProfilePhoto
            // 
            this.CancelButtonProfilePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButtonProfilePhoto.Location = new System.Drawing.Point(385, 314);
            this.CancelButtonProfilePhoto.Name = "CancelButtonProfilePhoto";
            this.CancelButtonProfilePhoto.Size = new System.Drawing.Size(122, 49);
            this.CancelButtonProfilePhoto.TabIndex = 5;
            this.CancelButtonProfilePhoto.Text = "Cancel";
            this.CancelButtonProfilePhoto.UseVisualStyleBackColor = true;
            this.CancelButtonProfilePhoto.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddProfileImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(934, 491);
            this.Controls.Add(this.CancelButtonProfilePhoto);
            this.Controls.Add(this.profileImageFour);
            this.Controls.Add(this.profileImageThree);
            this.Controls.Add(this.profileImageTwo);
            this.Controls.Add(this.profileImageOne);
            this.Controls.Add(this.selectImageText);
            this.Name = "AddProfileImage";
            this.Text = "AddProfileImage";
            ((System.ComponentModel.ISupportInitialize)(this.profileImageFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImageThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImageTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImageOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectImageText;
        private System.Windows.Forms.PictureBox profileImageOne;
        private System.Windows.Forms.PictureBox profileImageTwo;
        private System.Windows.Forms.PictureBox profileImageThree;
        private System.Windows.Forms.PictureBox profileImageFour;
        private System.Windows.Forms.Button CancelButtonProfilePhoto;
    }
}