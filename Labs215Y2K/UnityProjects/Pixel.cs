using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.UnityProjects
{
    public struct Pixel
    {
        private const char PixelChar = '█';
        public int pixelSize { get; }

        public Pixel(int x, int y, ConsoleColor color, int PixelSize = 3)
        {
            X = x;
            Y = y;
            Color = color;
            pixelSize = PixelSize;
        }
        public int X { get; }

        public int Y { get; }


        public ConsoleColor Color { get; }

        public void Draw()
        {
            Console.ForegroundColor = Color;

            for (int x = 0; x < pixelSize; x++)
            {
                for (int y = 0; y < pixelSize; y++)
                {
                    Console.SetCursorPosition(X * pixelSize + x, Y * pixelSize + y);
                    Console.Write(PixelChar);
                }
            }
        }
        public void Clear()
        {
            for (int x = 0; x < pixelSize; x++)
            {
                for (int y = 0; y < pixelSize; y++)
                {
                    Console.SetCursorPosition(X * pixelSize + x, Y * pixelSize + y);
                    Console.Write(' ');
                }
            }
        }

    }
}