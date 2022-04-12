using System;

namespace Entidades
{
    public class Punto
    {
        private  int x;
        private  int y;


        public Punto (int x , int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

    }
}
