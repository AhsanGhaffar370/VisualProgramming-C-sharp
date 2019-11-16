using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class calculator
    {
        private double x, y;
        public calculator() { }
        public calculator(double x, double y) 
        { 
            this.x = x; 
            this.y = y; 
        } 

        public double getx()
        {
            return x;
        }

        public double gety()
        {
            return y;
        }

        public double add()
        {
            return getx() + gety();
        }
        public double mul()
        {
            return getx() * gety();
        }
        public double div()
        {
            return getx() / gety();
        }
        public double sub()
        {
            return getx() - gety();
        }
    }
}
