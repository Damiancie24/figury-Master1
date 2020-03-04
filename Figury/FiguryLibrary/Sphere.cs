using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
   public class Sphere : Circle
    {
        public Sphere(double r = 1) : base(r)
        {
            
        }

        public override string ToString()
        {
            return $"Sphere {R}";
            
        }

        //public override double Surface => 4 * base.Surface;


        public new double Perimeter => throw new NotSupportedException("sfera nie ma obwodu");

        // Skalowanie
        public new Sphere Scale(double factor)
        {
            if(factor <= 0)
            {
                throw new ArgumentOutOfRangeException("opis ");
            }

            return new Sphere(R * factor);
        }


    }
}
