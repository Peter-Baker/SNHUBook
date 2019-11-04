namespace WindowsFormsApp7
{
    partial class PhotoPage
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SNHUbook = new System.Windows.Forms.Panel();
            this.SNHUbook_lbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Read_File_bn = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.SNHUbook.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SNHUbook
            // 
            this.SNHUbook.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SNHUbook.Controls.Add(this.SNHUbook_lbl);
            this.SNHUbook.Location = new System.Drawing.Point(0, 0);
            this.SNHUbook.Name = "SNHUbook";
            this.SNHUbook.Size = new System.Drawing.Size(584, 54);
            this.SNHUbook.TabIndex = 0;
            // 
            // SNHUbook_lbl
            // 
            this.SNHUbook_lbl.AutoSize = true;
            this.SNHUbook_lbl.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNHUbook_lbl.ForeColor = System.Drawing.Color.Gold;
            this.SNHUbook_lbl.Location = new System.Drawing.Point(13, 13);
            this.SNHUbook_lbl.Name = "SNHUbook_lbl";
            this.SNHUbook_lbl.Size = new System.Drawing.Size(154, 36);
            this.SNHUbook_lbl.TabIndex = 0;
            this.SNHUbook_lbl.Text = "SNHUbook";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(581, 317);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Read_File_bn
            // 
            this.Read_File_bn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Read_File_bn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Read_File_bn.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Read_File_bn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Read_File_bn.Location = new System.Drawing.Point(45, 391);
            this.Read_File_bn.Name = "Read_File_bn";
            this.Read_File_bn.Size = new System.Drawing.Size(90, 33);
            this.Read_File_bn.TabIndex = 2;
            this.Read_File_bn.Text = "Browse...";
            this.Read_File_bn.UseVisualStyleBackColor = false;
            this.Read_File_bn.Click += new System.EventHandler(this.Read_File_bn_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Add.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Add.Location = new System.Drawing.Point(448, 391);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(90, 33);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // PhotoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(582, 436);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Read_File_bn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SNHUbook);
            this.Name = "PhotoPage";
            this.Text = "PhotoPage";
            this.SNHUbook.ResumeLayout(false);
            this.SNHUbook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel SNHUbook;
        private System.Windows.Forms.Label SNHUbook_lbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Read_File_bn;
        private System.Windows.Forms.Button Add;
    }
}