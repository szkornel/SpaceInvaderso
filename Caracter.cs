using System;

namespace SpaceInvaderso
{
    public class Caracter
    {
        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor Color { get; set; }
        public char MyCaracter { get; set; }

        public Caracter(int x, int y, char myCaracter, ConsoleColor color)
        {
            X = x;
            Y = y;
            Color = color;
            MyCaracter = myCaracter;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = Color;
            Console.Write(MyCaracter);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Draw(int x, int y)
        {
            Console.SetCursorPosition(X + x, Y + y);
            Console.ForegroundColor = Color;
            Console.Write(MyCaracter);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Cclear(int x, int y)
        {
            Console.SetCursorPosition(X + x, Y + y);
            Console.Write(' ');
        }
    }
}