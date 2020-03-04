using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
   abstract public class Figure
    {
        public string Color { get;  set;} //read - write


       public Figure(string color = "Black")
        {
            Color = color;
        }


        public void Print()
        {
            Console.WriteLine($"Fifura {this}, color {Color}");
        }

        abstract public void Draw(); // Rysowanie figury za pomoca plotera
        
    }
}
