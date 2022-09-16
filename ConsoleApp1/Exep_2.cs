using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exep_2
    {
        public static void exeption()
        {
            bool flag = true;
            if (flag == false)
            {
                int num1 = 5;
                int num2 = 0;

                int res = num1 / num2;
                Console.WriteLine(res);

                //Array Out of bound exception
                int[] num = new int[5];
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(num[i]);
                }

                //File format exception
                string s = "sanket";
                int a = int.Parse(s);

                //Null reference exception
                string s1 = null;
                Console.WriteLine();
            }
            else 
            {
                int a = 5;
                int b = 5;
                Console.WriteLine(a+b);
                Console.WriteLine("Compiled sucessfuly");
                Console.ReadLine();
            }
        }

    } 
}
