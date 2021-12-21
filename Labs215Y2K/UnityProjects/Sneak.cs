using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.UnityProjects
{
    internal sealed class Sneak
    {
        private readonly ConsoleColor _snakeHeadColor;
        private readonly ConsoleColor _snakeBodyColor;

        internal Sneak(int initialX, int initialY, ConsoleColor snakeHeadColor, ConsoleColor sneakBodyColor,
            int bodyLength = 3)
        {
            _snakeHeadColor = snakeHeadColor;
            _snakeBodyColor = sneakBodyColor;

            Head = new Pixel(initialX, initialY, _snakeHeadColor);
            for (var i = bodyLength; i >= 0; i--)
            {
                Body.Enqueue(new Pixel(Head.X - i - 1, initialY, _snakeBodyColor));
            }

            Draw();
        }

        public Pixel Head { get; set; }

        public Queue<Pixel> Body { get; } = new();

        public void Move(EDirection direction, bool eat = false)
        {
            Clear();

            Body.Enqueue(new Pixel(Head.X, Head.Y, _snakeBodyColor));

            if (!eat)
            {
                Body.Dequeue();
            }

            Head = direction switch
            {
                EDirection.Right => new Pixel(Head.X + 1, Head.Y, _snakeHeadColor),
                EDirection.Left => new Pixel(Head.X - 1, Head.Y, _snakeHeadColor),
                EDirection.Up => new Pixel(Head.X, Head.Y - 1, _snakeHeadColor),
                EDirection.Down => new Pixel(Head.X, Head.Y + 1, _snakeHeadColor),
                _ => Head
            };
            Draw();
        }

        private void Draw()
        {
            Head.Draw();
            foreach (var pixel in Body)
                pixel.Draw();
        }
        public void Clear()
        {
            Head.Clear();
            foreach (var pixel in Body)
                pixel.Clear();
        }
    }
}