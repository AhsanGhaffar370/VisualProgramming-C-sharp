using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program v = new Program();
            string temp;
            //////////////////////////////////****************task 1*************//////////////////////////
            /* Console.WriteLine("hello world");
              //Console.ReadLine();
              String firstnumber, secondnumber;
              double a;
              double b;
              string operation;
              Console.WriteLine("Press \n1 for addition\n 2 for subtraction\n3 for multiplication\n4 for division");
              operation = Console.ReadLine();
              Console.WriteLine("Enter first number");
              firstnumber = Console.ReadLine();
              Console.WriteLine("Enter second number");
              secondnumber = Console.ReadLine();
              a = Double.Parse(firstnumber);
              b = Double.Parse(secondnumber);
              if (operation == "1")
              {
                 v.add(a, b);


              } 
              else if (operation == "2")
              {
                  v.sub(a,b);


              } else if (operation == "3")
              {
                  v.mul(a, b);


              } else if (operation == "4")
              {
                  v.div(a, b);


              }
              else
              {
                  Console.WriteLine("invalid");
              }
            */

            //////////////////////////////////****************task 2*************//////////////////////////
              v.square();

            //////////////////////////////////****************task 3*************//////////////////////////
            /*string centi;
            Console.WriteLine("Enter number in centigrade");
            centi=Console.ReadLine();
            double conver = Double.Parse(centi);

            v.conversion(conver);*/

            //////////////////////////////////****************task 4*************//////////////////////////
            /* string number;
             Console.WriteLine("Enter number");
             number = Console.ReadLine();
             int num;
             num = Int32.Parse(number);

             Console.WriteLine("Factorial :" + v.fact(num));*/
            //////////////////////////////////****************task 5*************//////////////////////////
            //v.check();
            //////////////////////////////////****************task 6*************//////////////////////////
            //v.avg();
            //////////////////////////////////****************task 7*************//////////////////////////
            //v.smallestnumber();
            Console.WriteLine("\nEnter temp number");
            temp = Console.ReadLine();


        }

        public void add(double a,double b)
        {
            double res=a+b;
            Console.WriteLine("Result:" +res);
           
        }
        public void sub(double a, double b)
        {
            double res = a - b;
            Console.WriteLine("Result:" + res);

        }
        public void mul(double a, double b)
        {
            double res = a * b;
            Console.WriteLine("Result:" + res);

        }
        public void div(double a, double b)
        {
            double res = a / b;
            Console.WriteLine("Result:" + res);

        }
        /////task 2//////////

        public void square()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * i);
            }
        }
        public void conversion(double fehren)
        {
            double cen = (fehren - 32) * 0.55;
            Console.WriteLine("Centigrade :"+cen);
        }
        public int fact(int n)
        {
            if (n > 1)
            {
                return n * fact(n - 1);

            }
            else
                return 1;



        }

        public void check()
        {
            int num1, rem1;
            Console.Write("\n\n");
            Console.Write("Check whether a number is even or odd :\n");
            Console.Write("Enter a number : ");
            num1 = Int32.Parse(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
                Console.WriteLine("{0} is an even integer.\n", num1);
            else
                Console.WriteLine("{0} is an odd integer.\n", num1);
        }
        //////////task 6/////////////
        public void avg()
        {
            int n, sum = 0;
            double avg;

           
            Console.Write("Input the 5 numbers of student : \n");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Number-{0} :", i);

                n = Int32.Parse(Console.ReadLine());
                sum += n;
            }
            avg = sum / 5;
            Console.Write("The Average is : {0}", sum);
        }
        public void smallestnumber()
        {
            int num1, num2, num3;
            Console.Write("\n\n");
            Console.Write("Find the smallest of three numbers:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    Console.Write("The 1st Number is the smallest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the smallest among three. \n\n");
                }
            }
            else if (num2 < num3)
                Console.Write("The 2nd Number is the smallest among three \n\n");
            else
                Console.Write("The 3rd Number is the smallest among three \n\n");
        }
    }


    
}
