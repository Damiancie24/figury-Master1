using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{

    /// <summary>
    /// Trojkat w wersji Immutable
    /// </summary>
     
    // Immutable znaczy ze stan tego obiektu nie ulegnie zmianie
    public class Triangle : Figure
    {
       public double A { get; private set; } // A jest read-only
       public double B { get; private set; }
       public double C { get; private set; }

        // konstuktor

        public Triangle(double a = 1, double b = 1, double c =1)
        {
            if(a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Boki powinny być dodatnie");
            }

            if(a+b <= c || a+c <= b || b+c <= a)
            {
                throw new ArgumentException("Nie spełniony warunek trojkata");
            }

            A = a;
            B = b;
            C = c;
        }

        public override string ToString()
        {
            return $"triangle( {A}, {B}, {C} )";
        }

        public double Permiter() => A + B + C; // obliczamy obwod

        public Triangle Scale(double factor)
        {
            if( factor < 0)
            {
                throw new ArgumentOutOfRangeException("wspulczynnik musi byc dodatni");
            }

            return new Triangle(A * factor, B * factor, C * factor);
        }

        public override void Draw()
        {
            Console.WriteLine("rysowanie trojkata");
        }


    }
}
