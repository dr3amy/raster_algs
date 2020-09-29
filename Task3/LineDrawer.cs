using System;
using System.Drawing;

namespace raster_algs
{
    public class LineDrawer
    {
        private readonly int _width;
        private readonly int _height;

        public LineDrawer(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public Bitmap DrawLineBresenham(int x0, int y0, int x1, int y1)
        {
            Bitmap bitmap = new Bitmap(_width, _height);
            
            var steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0); // Проверяем рост отрезка по оси икс и по оси игрек
            // Отражаем линию по диагонали, если угол наклона слишком большой
            if (steep)
            {
                Swap(ref x0, ref y0); // Перетасовка координат вынесена в отдельную функцию для красоты
                Swap(ref x1, ref y1);
            }
            // Если линия растёт не слева направо, то меняем начало и конец отрезка местами
            if (x0 > x1)
            {
                Swap(ref x0, ref x1);
                Swap(ref y0, ref y1);
            }
            int dx = x1 - x0;
            int dy = Math.Abs(y1 - y0);
            int error = dx / 2; // Здесь используется оптимизация с умножением на dx, чтобы избавиться от лишних дробей
            int ystep = (y0 < y1) ? 1 : -1; // Выбираем направление роста координаты y
            int y = y0;
            for (int x = x0; x <= x1; x++)
            {
                DrawPoint(bitmap, steep ? y : x, steep ? x : y); // Не забываем вернуть координаты на место
                error -= dy;
                if (error < 0)
                {
                    y += ystep;
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

        private void DrawPoint(Bitmap bitmap, int x, int y)
        {
            bitmap.SetPixel(x, y, Color.Black);
        }

        public void DrawLineBy()
        {
            
        }
    }
}