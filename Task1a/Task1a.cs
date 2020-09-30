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

        private void workArea_MouseDown(object sender, MouseEventArgs e)
        {
            drawingPen = new Pen(currentColorPicture.BackColor, 1);
            if (enableDrawing.Checked) //если включен режим рисования, начинаем рисование
            {
                isNowDrawing = true;
                oldMousePos = e.Location;
                drawPoint(drawingPen, e.X, e.Y);
            }
            else //иначе выполяем заливку
            {
                fill(drawingPen, e.X, e.Y);
            }
        }

        private void workArea_MouseMove(object sender, MouseEventArgs e)
        {
            //если мы не в режиме рисования, ничего не делаем
            if (!enableDrawing.Checked || !isNowDrawing)
                return;
            drawingGraphic.DrawLine(drawingPen, oldMousePos, e.Location);
            oldMousePos = e.Location;
            workArea.Invalidate(); //обновляем картинку
        }

        private void workArea_MouseUp(object sender, MouseEventArgs e)
        {
            //если мы не в режиме рисования, ничего не делаем
            if (!enableDrawing.Checked || !isNowDrawing)
                return;
            isNowDrawing = false;
            drawingPen.Dispose();
        }

        private void drawPoint(Pen pen, int x, int y)
        {
            drawingGraphic.DrawEllipse(pen, x, y, pen.Width, pen.Width);
            workArea.Invalidate(); //обновляем картинку
        }

        private void fill(Pen pen, int startX, int startY)
        {
            Bitmap workAreaImage = workArea.Image as Bitmap;
            //получаем дескриптор Graphics для быстрого получения цветов
            Color oldColor = workAreaImage.GetPixel(startX, startY);
            Color newColor = currentColorPicture.BackColor;

            //обходим массив и заливаем
            Stack<Point> points = new Stack<Point>();
            points.Push(new Point(startX, startY));

            while (points.Count > 0)
            {
                Point currentPoint = points.Pop();
                //проверяем, что не вышли за границы картинки
                if (currentPoint.X < 0 || currentPoint.Y >= workArea.Width)
                    continue;

                Color currentPointColor = workAreaImage.GetPixel(currentPoint.X, currentPoint.Y);
                if (currentPointColor == oldColor && currentPointColor != newColor)
                {
                    //определяем границы линии для заливки
                    int leftX = currentPoint.X, rightX = currentPoint.X;
                    while (true)
                    {
                        if (leftX == 0) 
                            break;
                        Color tColor = workAreaImage.GetPixel(leftX - 1, currentPoint.Y);
                        if (tColor == oldColor && tColor != newColor) 
                            leftX--;
                        else 
                            break;
                    }
                    while (true)
                    {
                        if (rightX == workArea.Width - 1) 
                            break;
                        Color tColor = workAreaImage.GetPixel(rightX + 1, currentPoint.Y);
                        if (tColor == oldColor && tColor != newColor) 
                            rightX++;
                        else 
                            break;
                    }

                    if (leftX == rightX) 
                        continue;
                    drawingGraphic.DrawLine(pen, leftX, currentPoint.Y, rightX, currentPoint.Y);

                    //добавляем в очередь пиксели выше и ниже текущей линии
                    if (currentPoint.Y > 0)
                        for (int x = leftX; x <= rightX; x++)
                        {
                            Point newPoint = new Point(x, currentPoint.Y - 1);
                            Color newPointColor = workAreaImage.GetPixel(x, newPoint.Y);
                            if (newPointColor == oldColor && newPointColor != newColor) 
                                points.Push(newPoint);
                        }
                    if (currentPoint.Y < workArea.Height - 1)
                        for (int x = leftX; x <= rightX; x++)
                        {
                            Point newPoint = new Point(x, currentPoint.Y + 1);
                            Color newPointColor = workAreaImage.GetPixel(x, newPoint.Y);
                            if (newPointColor == oldColor && newPointColor != newColor) 
                                points.Push(newPoint);
                        }
                }
            }
            workArea.Invalidate(); //обновляем картинку
        }

        private void enableFilling_CheckedChanged(object sender, EventArgs e)
        {
            isNowDrawing = false;
        }
    }
}
