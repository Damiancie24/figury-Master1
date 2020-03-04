using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguryLibrary;

namespace ConsoleAppFigury
{
    class Program
    {

        static void Main()
        {
            var t = new Triangle();
            Console.WriteLine(t);
            Console.WriteLine(t.Color);
            t.Print();

            var c = new Circle(); // Pilimorfizm 
            c.Print();

            var s = new Sphere(10);
            Console.WriteLine(s);

            

        }

        static void Main2()
        {
            Triangle t = new Triangle();
            Console.WriteLine(t);

            var t1 = new Triangle(1.5, 1, 1);
            Console.WriteLine(t1);


            //var t2 = new Triangle(3); //Pozostale boki = 1

            var t3 = t1.Scale(2);
            Console.WriteLine(t3);

            Console.WriteLine("=== Circle===");

            Circle c = new Circle();
            Console.WriteLine(c);

            var c1 = new Circle(2);
            Console.WriteLine(c1);

            var c2 = c1.Scale(2);
            Console.WriteLine(c2);

            var c3 = c1.Perimiter();
            Console.WriteLine($"Perimiter {c3}");



        }


        static void Main1(string[] args)
        {
            Trojkat t1; //deklaracja zmiennej typu Trojkat
            t1 = new Trojkat();

            Console.WriteLine(t1);
            Console.WriteLine(t1.GetObwod());
            Console.WriteLine(t1.Obwod);
            Console.WriteLine($"pole = {t1.GetPole()}");
            Console.WriteLine($"pole = {t1.Pole}");
            try
            {
                t1.A = -1;
                t1.B = -2;
                t1.C = -3;
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("nie wolno bokom przypiswać wartości ujemnych");
            }
            Console.WriteLine(t1); 
            Console.WriteLine(t1.Pole);

            Console.WriteLine("=====================");
            var t2 = new Trojkat(3, 4, 5);
            Console.WriteLine(t2);
            Console.WriteLine(t2.A);
            t2.B = 100;
            Console.WriteLine(t2);
        }
    }
}
