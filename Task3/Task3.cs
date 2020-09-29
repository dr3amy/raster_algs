using System;
using System.Windows.Forms;

namespace raster_algs
{
    public partial class Task3 : Form
    {

        private MouseEventArgs previousClick;
        public Task3()
        {
            InitializeComponent();
        }

        //this.canvas.MouseClick += this.OnClick;
        private void OnClick(object o, MouseEventArgs args)
        {
            System.Diagnostics.Debug.WriteLine("X={0}, Y={1}", args.X, args.Y);
            if (previousClick == null)
            {
                previousClick = args;
            }
            else
            {
                var pictureBox = o as PictureBox;
                var bitmap = new LineDrawer(pictureBox.Width, pictureBox.Height).DrawLineBresenham(previousClick.X, previousClick.Y,
                    args.X, args.Y);
                pictureBox.Image = bitmap;
                previousClick = null;
            }
        }
    }
}