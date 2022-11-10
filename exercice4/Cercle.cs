using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice4
{
    class Cercle
    {
        private Point centre;                  
        private double rayon;

        public Point Centre
        {
            get { return centre; }
            set { centre = value; }
        }

        public double Rayon
        {
            get { return rayon; }
            set { rayon = value; }
        }

        public Cercle(Point p, double r)
        {
            centre = p;
            rayon = r;
        }
        public bool egalite(Cercle c1,Cercle c2)
        {
            if (c1.centre==c2.centre&&c1.rayon==c2.rayon)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool appartient(Point p)
        {
            if (p.Distance(centre) <= rayon)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

            public void intersection(Point p ,Cercle c1, Cercle c2)
        {
            if (c1.appartient(p)&&c2.appartient(p))
            {
                Console.WriteLine( p);
            }
        }

        public double calculCirconference()
        {
            return Math.PI * (2* Math.PI *rayon);
        }
        public double calculdair()
        {
            return Math.PI * rayon *rayon;
        }

  
    }
}
