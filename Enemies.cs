using System;
using System.Collections.Generic;
using System.Threading;

namespace SpaceInvaderso
{
    /// <summary>
    /// Konténerosztály az ellenségek listáját tartalmazza
    /// </summary>
    internal static class Enemies
    {
        private static readonly Caracter[] invaderSkin;
        public static List<Invader> invaders;
        private static int stepCount;
        private static Timer timer;

        static Enemies()
        {
            stepCount = 1;
            invaders = new List<Invader>();

            invaderSkin = new Caracter[6]
            {
                new Caracter(0,0,'(',ConsoleColor.Red),
                new Caracter(1,0,'o',ConsoleColor.Red),
                new Caracter(3,0,'o',ConsoleColor.Red),
                new Caracter(4,0,')',ConsoleColor.Red),
                new Caracter(1,1,'/',ConsoleColor.Red),
                new Caracter(3,1,'\\',ConsoleColor.Red)
            };

            SpawnInvaders();
        }

        public static void StartTimer()
        {
            timer = new Timer(Move, null, 1000, 2000);
        }

        public static void StopTimer()
        {
            timer.Dispose();
        }

        private static void SpawnInvaders(int n = 10)
        {
            for (int i = 0; i < n; i++)
            {
                invaders.Add(new Invader(invaderSkin, i * 8, 2));
            }
        }

        private static void Move(object o)
        {
            if (stepCount > 4)
            {
                Console.SetCursorPosition(0, 0);
                Console.Clear();
                Tank.MyTank.Draw();
                SpawnInvaders();
                stepCount -= 4;
            }

            stepCount++;

            foreach (Invader i in invaders)
            {
                i.Move();
            }
        }
    }
}