using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, r;
            Console.Out.Write("Donner l'abscisse du centre: ");
            x = double.Parse(Console.In.ReadLine());
            Console.Out.Write("Donner l'ordonné du centre: ");
            y = double.Parse(Console.In.ReadLine());
            Console.Out.Write("Donner le rayon: ");
            r = double.Parse(Console.In.ReadLine());
            Point centre = new Point(x, y);
            Cercle C = new Cercle(centre, r);

        }
    }
}
