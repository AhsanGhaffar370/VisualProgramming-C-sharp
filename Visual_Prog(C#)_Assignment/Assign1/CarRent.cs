using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    class CarRent
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Days { get; set; }
        public string Dvr { get; set; }
        public string Ac { get; set; }
        public string As { get; set; }

        public double rent()
        {
            int t_ac=0, t_dvr=0, t_as=0;

            if (Dvr == "YES")
                t_dvr = 800;

            if (Ac == "YES")
                t_ac = 400;

            if (As == "YES")
                t_as = 400;

            return (1000+ t_dvr+ t_ac+ t_as)*Days;
        }
    }
}
