using System;

namespace SpaceInvaderso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 80);
            Console.SetWindowSize(80, 32);
            Console.CursorVisible = false;
            Enemies.StartTimer();
            Tank.MyTank.Draw();

            Console.ReadKey();

            while (Enemies.invaders.Count < 40)
            {
                var c = Console.ReadKey(true).Key;
                Tank.MyTank.GetInput(c);
                // Console.SetCursorPosition(50, 30);
                // Console.Write("*****{0}*****", Invader.count);
            }

            Enemies.StopTimer();
            Console.Clear();
            Console.Clear();
            Console.WriteLine("Game Over");
            Console.ReadLine();
        }
    }
}