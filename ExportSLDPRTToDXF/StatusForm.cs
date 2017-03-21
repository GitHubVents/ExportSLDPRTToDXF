using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExportSLDPRTToDXF
{
    public partial class StatusForm : Form
    {
        Timer timer;
        public StatusForm( )
        {
            InitializeComponent( );
            timer = new Timer( );
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            timer.Start( );
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            //Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //pictureBox1.DrawToBitmap(bmp, new Rectangle(Point.Empty, pictureBox1.Size));
            //bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);

            //PictureBox pbox = new PictureBox( );
            //pbox.Location = pictureBox1.Location;
            //pbox.SizeMode = PictureBoxSizeMode.AutoSize;
            //pbox.Image = bmp;
            //Controls.Remove(pictureBox1);
            //Controls.Add(pbox);
        }
    }
}
