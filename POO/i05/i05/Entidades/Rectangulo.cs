using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo
    {
        private float area;
        private float parimetro;
        public Punto vertice1;
        public Punto vertice2;
        public Punto vertice3;
        public Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());
        }

        public float Area()
        {
            int baseRectangulo = Math.Abs(vertice1.GetX() - vertice4.GetX()); // se calcula la base restando el x  del vertice 1 (1,y) menos el x del vertice 4  (3,y)
            int alturaRectangulo = Math.Abs(vertice3.GetY() - vertice1.GetY());// se calcula la alltura restando el y  del vertice 3 (x,3) menos el x del vertice 1  (x,2)
            float area = baseRectangulo * alturaRectangulo;
            this.area = area;

            return this.area;
        }

        public float Perimetro()
        {
            int baseRectangulo = Math.Abs(vertice1.GetX() - vertice4.GetX()); 
            int alturaRectangulo = Math.Abs(vertice3.GetY() - vertice1.GetY());
            float perimetro = (baseRectangulo + alturaRectangulo) / 2;
            this.parimetro = perimetro;
            return this.parimetro;
        }


    }
}
