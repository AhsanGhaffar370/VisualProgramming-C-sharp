using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class point
    {
        protected int xval, yval;
        public point() { } 
        public point(int x, int y) 
        { 
            xval = x; 
            yval = y; 
        } 
        public void setxval(int x1) 
        {
            xval = x1; 
        } 
        public void setyvalue(int y1) 
        { 
            yval = y1; 
        } 
        public override string ToString()
        { 
            return xval+ "\t" + yval; 
        }

    }
}
