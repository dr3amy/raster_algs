using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raster_algs.Task1a
{
    public partial class Task1a : Form
    {
        private bool isNowDrawing = false; //true, если зажата мышка и идет рисование
        private Pen drawingPen;            //перо текущего рисования
        private Graphics drawingGraphic;
        private Point oldMousePos;
        public Task1a()
        {
            InitializeComponent();
            currentColorPicture.BackColor = Color.Black;                  //изначально выбран черный цвет для рисования
            workArea.Image = new Bitmap(workArea.Width, workArea.Height); //область для рисования изначально белая
            drawingGraphic = Graphics.FromImage(workArea.Image);
            drawingGraphic.FillRectangle(new SolidBrush(Color.White), 0, 0, workArea.Width, workArea.Height);
        }

        private void changeCurrentColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                currentColorPicture.BackColor = dialog.Color;
        }


    }
}
