using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class Program
    {

        static void Main(string[] args)
        {
            Program a = new Program();
            /////////////////Task 1//////////
            a.test();

            /////////////Task 2//////////
            int[,] array = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Your input: ");
                    array[i, j] = Int32.Parse(Console.ReadLine());

                }
            }

            Console.WriteLine("\n\n=========================");
            Console.WriteLine("All the elements :\n\n");



            Console.Write("\tStudent1\tStudent2\tStudent3\n\n");


            for (int i = 0; i < 3; i++)
            {
                Console.Write("Marks{0}.\t", i + 1);


                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t\t", array[i, j]);

                }
                Console.Write("\n");
            }
            Console.WriteLine("\n\n=========================");
            Console.ReadKey();

            ////////////////task 3////////////
            Program dba = new Program();
            Console.WriteLine("press 1 to decimal to binary\nPress 2 to binary to decimal");
            string am;
            am= Console.ReadLine();
            int aa = Convert.ToInt32(a);
            if (aa == 1)
            {
                dba.dtb();
            }
            else if (aa == 2)
            {
                dba.btd();
            }
            else
            {
                Console.WriteLine("invalid");
            }
            Console.ReadKey();

            /////////////////Task 4/////////////
            Program an = new Program();
            an.multiplication();
            Console.ReadKey();
        }
        void multiplication()
        {
            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];
            int[,] result = new int[3, 3];
            Console.WriteLine("Enter Elements of first array: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array1[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter Elements of second array: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array2[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                        result[i, j] += array1[i, k] *
                                     array2[k, j];
                }
            }

            Console.WriteLine("multiplied output of the input: ");
            Console.WriteLine("\n\n");


            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}.\t", i + 1);


                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", result[i, j]);

                }
                Console.Write("\n");
            }

        } void dtb()
        {
            Console.WriteLine("enter number: ");
            string number, result = "";
            int rem;
            number = Console.ReadLine();
            int num = Convert.ToInt32(number);

            while (num > 1)
            {
                rem = num % 2;
                result = Convert.ToString(rem) + result;
                num = num / 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);
        }

        void btd()
        {
            int num, binary_val, dv = 0, bv = 1, rem;
            Console.Write("Enter a Binary Number(1s and 0s) : ");
            num = int.Parse(Console.ReadLine());
            binary_val = num;
            while (num > 0)
            {
                rem = num % 10;
                dv = dv + rem * bv;
                num = num / 10;
                bv = bv * 2;
            }
            Console.Write("The Binary Number is : " + binary_val);
            Console.Write("\nIts Decimal Equivalent is : " + dv);
        }



void test()
        {
            int[] array = new int[5];
            int one = 0, two = 0, three = 0, four = 0, five = 0;
            Console.WriteLine("Enter Your Response: ");
            for (int i = 0; i < 5; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
                if (array[i] == 1)
                {
                    one++;
                }
                else if (array[i] == 2)
                {
                    two++;
                }
                else if (array[i] == 3)
                {
                    three++;
                }
                else if (array[i] == 4)
                {
                    four++;
                }
                else if (array[i] == 5)
                {
                    five++;
                }
            }

            Console.WriteLine("Response1 given by " + one);
            Console.WriteLine("Response2 given by " + two);
            Console.WriteLine("Response3 given by " + three);
            Console.WriteLine("Response4 given by " + four);
            Console.WriteLine("Response5 given by " + five);

            Console.ReadKey();
        }

    }
    }

