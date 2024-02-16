using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vettori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("massa in Kg: ");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("accelerazione (x;y) in m/s^2: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Vettore a = new Vettore(x, y);
            Console.WriteLine("F = " +  (m * a).ToString());

            Console.Write("Posizione iniziale x in m (metri): ");
            double s0x = double.Parse(Console.ReadLine());
            Console.Write("Posizione iniziale y in m (metri): ");
            double s0y = double.Parse(Console.ReadLine());
            Console.WriteLine("velocità iniziale (x;y) in m/s: ");
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            Vettore v0 = new Vettore(x, y);
            Console.WriteLine("tempo in s (secondi): ");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("s = " + Math.Sqrt(Math.Pow(s0x + v0.X * t + 0.5f * a.X * t * t, 2) + Math.Pow(s0y + v0.Y * t + 0.5f * a.Y * t * t, 2)).ToString());


            Console.ReadKey();
        }
    }
}
