using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    public class Circle : Figure, IMeasurable2D
    {
       public double R { get; private set; }

        public Circle (double r = 1)
        {
            if(r <= 0)
            {
                throw new ArgumentOutOfRangeException("Promien musi byc dodatni");
            }

            R = r;

        }

        public virtual double Perimeter => 2 * Math.PI * R; // obliczamy obwod


        public virtual double Surface => Math.PI * (R * R);

        public override string ToString()
        {
            return $"Koło o  promieniu( {R} )";
        }



        public Circle Scale(double factor)
        {
            if (factor < 0)
            {
                throw new ArgumentOutOfRangeException("wspulczynnik musi byc dodatni");
            }

            return new Circle(R * factor);
        }

        public override void Draw()
        {
            Console.WriteLine("Rysowanie Koła");
        }
    }
}
