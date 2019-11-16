using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class deposit
    {
        private double bal, dw;
        public deposit() { }
        public deposit(double bal, double dw) 
        { 
            this.bal = bal; 
            this.dw = dw; 
        } 

        public double getbal()
        {
            return bal;
        }

        public double getdw()
        {
            return dw;
        }

        public double dep()
        {
            return getbal() + getdw();
        }
        public double with()
        {
            return getbal() - getdw();
        }

    }
}
