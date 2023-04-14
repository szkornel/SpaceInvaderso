using System;

namespace SpaceInvaderso
{
    public class Invader : IDisposable
    {
        Caracter[] caracter;
        public int X { get; set; }
        public int Y { get; set; }
        public static int count;
        private bool disposedValue;

        public Invader(Caracter[] caracter, int x, int y)
        {
            this.caracter = caracter;
            X = x;
            Y = y;
            //count++;
        }

        ~Invader()
        {
            caracter = null;
            count++;
        }

        public void Draw()
        {
            foreach (var item in caracter)
            {
                item.Draw(X, Y);
            }
        }

        public void CClear()
        {
            foreach (var item in caracter)
            {
                item.Cclear(X, Y);
            }
        }

        public static void Move(object o)
        {
            (o as Invader).CClear();
            (o as Invader).Y++;
            (o as Invader).Draw();
        }

        public void Move()
        {
            CClear();
            Y++;
            Draw();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    count++;
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}