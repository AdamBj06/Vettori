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
            Console.Write("massa [Kg]: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("accelerazione x;y [m/s^2]: ");
            Vettore a = Vettore.Parse(Console.ReadLine());
            Console.WriteLine("F({0}); F = {1}N", (m * a).ToString(), Vettore.Modulo(m * a).ToString());

            Console.Write("Posizione iniziale x;y [m]: ");
            Vettore s0 = Vettore.Parse(Console.ReadLine());
            Console.Write("velocità iniziale x;y [m/s]: ");
            Vettore v0 = Vettore.Parse(Console.ReadLine());
            Console.Write("tempo [s]: ");
            double t = double.Parse(Console.ReadLine());
            Vettore s = new Vettore(s0.X + v0.X * t + 0.5d * a.X * t * t, s0.Y + v0.Y * t + 0.5d * a.Y * t * t);
            Console.WriteLine("s({0}); s = {1}m", s.ToString(), Vettore.Modulo(s).ToString());

            Console.ReadKey();
        }
    }
}
