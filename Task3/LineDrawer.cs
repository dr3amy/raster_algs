using System;
using System.Drawing;

namespace raster_algs
{
    public class LineDrawer
    {
        private readonly int _width;
        private readonly int _height;
        private Bitmap _bitmap;

        public LineDrawer(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public Bitmap DrawLineBresenham(int x0, int y0, int x1, int y1)
        {
            var bitmap = new Bitmap(_width, _height);
            
            var steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
            if (steep)
            {
                Swap(ref x0, ref y0);
                Swap(ref x1, ref y1);
            }
            if (x0 > x1)
            {
                Swap(ref x0, ref x1);
                Swap(ref y0, ref y1);
            }
            var dx = x1 - x0;
            var dy = Math.Abs(y1 - y0);
            var error = dx / 2;
            var yStep = (y0 < y1) ? 1 : -1;
            var y = y0;
            for (var x = x0; x <= x1; x++)
            {
                if (steep)
                {
                    bitmap.SetPixel(y, x, Color.Black);
                }
                else
                {
                    bitmap.SetPixel(x, y, Color.Black);
                }
                error -= dy;
                if (error < 0)
                {
                    y += yStep;
                    error += dx;
                }
            }

            return bitmap;
        }

        private static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        public Bitmap DrawLineWu(int x0, int y0, int x1, int y1)
        {
            _bitmap = new Bitmap(_width, _height);
            
            var steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
            if (steep)
            {
                Swap(ref x0, ref y0);
                Swap(ref x1, ref y1);
            }
            if (x0 > x1)
            {
                Swap(ref x0, ref x1);
                Swap(ref y0, ref y1);
            }

            DrawPoint(steep, x0, y0, 1);
            DrawPoint(steep, x1, y1, 1);
            float dx = x1 - x0;
            float dy = y1 - y0;
            var gradient = dy / dx;
            var y = y0 + gradient;
            for (var x = x0 + 1; x <= x1 - 1; x++)
            {
                DrawPoint(steep, x, (int)y, 1 - (y - (int)y));
                DrawPoint(steep, x, (int)y + 1, y - (int)y);
                y += gradient;
            }
            
            return _bitmap;
        }

        private void DrawPoint(bool steep, int x, int y, float a)
        {
            var color = Color.FromArgb((int)(a * 255), Color.Black);
            if (steep)
            {
                _bitmap.SetPixel(y, x, color);
            }
            else
            {
                _bitmap.SetPixel(x, y, color);
            }
        }
    }
}