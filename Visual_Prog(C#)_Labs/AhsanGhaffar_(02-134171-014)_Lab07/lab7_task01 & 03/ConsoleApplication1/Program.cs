using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            square sq1 = new square(2, 3);

            circle cr = new circle(2, 3, 4);

            cr.show();
            sq1.show();

            //Task_01
            Console.Write("***********\nTASK_01\n***********\n");
            square sq = new square(2, 3);
            Console.WriteLine(sq.ToString());

            Console.Write("\n\n***********\nTASK_02\n***********\n");
            Console.Write("\nEnter value 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("\nEnter value 2: ");
            double b = double.Parse(Console.ReadLine());

            //circle c=new circle(2,3,4); 

            calculator cal = new calculator(a, b);

            int i=1;
            while(i==1)
            {
                Console.WriteLine("\nChoose any one operation:\n");
                Console.WriteLine("1: ADD\n");
                Console.WriteLine("2: SUBSTRACT\n");
                Console.WriteLine("3: MULTIPLY\n");
                Console.WriteLine("4: DIVIDE\n");
                Console.WriteLine("0: EXIT\n");

                int opt = int.Parse(Console.ReadLine());
                if (opt == 1)
                    Console.WriteLine("\n"+a+"+"+b+"= "+cal.add());
                else if (opt == 2)
                    Console.WriteLine("\n" + a + "-" + b + "= " + cal.sub());
                else if (opt == 3)
                    Console.WriteLine("\n" + a + "*" + b + "= " + cal.mul());
                else if (opt == 4)
                    Console.WriteLine("\n" + a + "/" + b + "= " + cal.div());
                else if(opt==0)
                    i=0;
            }

            //Console.WriteLine(c.ToString());
               
            Console.ReadKey();
            

            
        }
    }
}
