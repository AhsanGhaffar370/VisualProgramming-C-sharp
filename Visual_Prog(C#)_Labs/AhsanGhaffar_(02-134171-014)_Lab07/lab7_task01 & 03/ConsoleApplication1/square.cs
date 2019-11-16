using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class square : circle
    {
         private int x, y;
        public square() { }
        public square(int x, int y) 
        { 
            this.x = x; 
            this.y = y; 
        } 
        public void setx(int x1) 
        {
            x = x1; 
        } 
        public void sety(int y1) 
        { 
            y = y1; 
        }

        public int getx()
        {
            return x;
        }

        public int gety()
        {
            return y;
        }

        public void show()
        {
            Console.WriteLine("Child");
        }


        public override string ToString()
        { 
            return getx()+ "\t" + gety(); 
        }
    }
}
