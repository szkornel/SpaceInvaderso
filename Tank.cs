using System;

namespace SpaceInvaderso
{
    internal class Tank : Invader
    {
        public static Tank MyTank { get; }
        private static readonly Caracter[] tankSkin;

        static Tank()
        {
            tankSkin = new Caracter[6]
            {
                new Caracter(0,1,'|',ConsoleColor.White),
                new Caracter(1,0,'_',ConsoleColor.White),
                new Caracter(2,0,'|',ConsoleColor.Yellow),
                new Caracter(3,0,'|',ConsoleColor.Yellow),
                new Caracter(4,0,'_',ConsoleColor.White),
                new Caracter(5,1,'|',ConsoleColor.White)
            };

            MyTank = new Tank();
        }

        public Tank() : base(tankSkin, 20, 26)
        {
            //
        }

        public void GetInput(ConsoleKey c)
        {
            switch (c)
            {
                case ConsoleKey.LeftArrow:
                    Move(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    Move(1, 0);
                    break;
                case ConsoleKey.Spacebar:
                    new Bullet(X, Y);
                    break;
            }
        }

        public void Move(int dx, int dy)
        {
            CClear();
            X += dx;
            Y += dy;
            Draw();
        }
    }
}