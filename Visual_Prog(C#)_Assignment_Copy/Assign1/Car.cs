using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    class Car
    {
        private string CarMake;
        private string CarModel;
        private int days;
        public int driver;
        public int AC;
        public int AS;

        public Car()
        {
            driver = 800;
            AC = 400;
            AS = 400;
        }
        public string carMode
        {
            get { return CarModel; }
            set { CarModel = value; }
        }
        public string carmake
        {
            get { return CarMake; }
            set { CarMake = value; }
        }
        public int day
        {
            get { return days; }
            set { days = value; }
        }
        public int calculate(int days)
        {
            return days * 1000;
        }

    }
}
