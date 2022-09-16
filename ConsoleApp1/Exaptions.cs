using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exaptions
    {
        public static void exp1()
        {
            int[] a = { 1, 2, 3, 4 };

            for (int i = 0; i < a.Length+1; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
        public static void exp2() 
        {
            int a = 5;

            Console.WriteLine(a/0);
            Console.ReadLine();

        }

        public static void exp3() 
        {
            String s=null;
            Console.WriteLine(s.Length);
            Console.ReadLine();

        }

      
    }
}
