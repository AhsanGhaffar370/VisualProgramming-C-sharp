using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class circle : point
    {
        private double radius;
        public circle()
        {

        }
        public circle(int x, int y, double r)
        {
            xval = x;
            yval = y;
            radius = r;
        }
        public void setradius(double r1)
        {
            radius = r1;
        }
        public virtual double Area()
        {
            return Math.PI * radius * radius;
        }
        public override string ToString()
        {
            return " The center of a circle is " + base.ToString() + " Radius is " + radius;

        }

        public void show()
        {
            Console.WriteLine("parent");
        }

    }
}


    


