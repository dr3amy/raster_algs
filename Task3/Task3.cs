using System.Windows.Forms;

namespace raster_algs
{
    public partial class Task3 : Form
    {

        private const string Bresenham = "Брезенхейм";
        private const string Wu = "ВУ";

        private MouseEventArgs _previousClick;
        public Task3()
        {
            InitializeComponent();
        }

        //this.canvas.MouseClick += this.OnClick;
        private void OnClick(object o, MouseEventArgs args)
        {
            System.Diagnostics.Debug.WriteLine("X={0}, Y={1}", args.X, args.Y);
            if (_previousClick == null)
            {
                _previousClick = args;
            }
            else
            {
                DrawLine(o as PictureBox, args);
                _previousClick = null;
            }
        }

        private void DrawLine(PictureBox pictureBox, MouseEventArgs mouseEventArgs)
        {
            var lineDrawer = new LineDrawer(pictureBox.Width, pictureBox.Height);
            var selectedAlgorithm = algorithmList.SelectedText;
            if (selectedAlgorithm == Bresenham)
            {
                pictureBox.Image = lineDrawer.DrawLineBresenham(_previousClick.X, _previousClick.Y, mouseEventArgs.X, mouseEventArgs.Y);
            }
            else
            {
                pictureBox.Image = lineDrawer.DrawLineWu(_previousClick.X, _previousClick.Y, mouseEventArgs.X, mouseEventArgs.Y);
            }
        }
    }
}