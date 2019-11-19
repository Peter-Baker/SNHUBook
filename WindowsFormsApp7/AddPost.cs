using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    class AddPost
    {
        public static int number = 0;
        public static int PanelLocation = 320;
        public static int LabelLocation = 55;
        public static int DateLocation = 15;
        public Label post_lbl = new Label();
        public Label date_lbl = new Label();
        public Panel post_background = new Panel();

        public AddPost()
        {
            number++;

            post_background.Name = ("post_background" + number.ToString()); //panel that holds all of the info
            post_background.Location = new System.Drawing.Point(157, PanelLocation);
            post_background.BackColor = System.Drawing.SystemColors.HotTrack;
            post_background.Size = new System.Drawing.Size(730, 100);
            PanelLocation = 120 + PanelLocation;

            DateTime date = DateTime.Now;   //adding the date
            date_lbl.Name = ("date_lbl" + number.ToString());
            date_lbl.Location = new System.Drawing.Point(39, DateLocation);
            date_lbl.ForeColor = System.Drawing.SystemColors.Window;
            date_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_lbl.Text = date.ToString().Substring(0, 10);

            post_lbl.Location = new System.Drawing.Point(39, LabelLocation);
            post_lbl.Name = ("post_lbl" + number.ToString());
            post_lbl.ForeColor = System.Drawing.SystemColors.Window;
            post_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}
