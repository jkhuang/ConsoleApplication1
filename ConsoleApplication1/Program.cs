using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int[] a = new int[100];
        static void Main(string[] args)
        {
       
            for (int i = 0; i < 100; i++)
            {
                a[i] = fn(i);
                Console.WriteLine(a[i]);
            }

      
        }

        static int fn(int n)
        {
            if (n == 0 || n == 1) return 1;
            return a[fn(n - 1)] + a[fn(n - 2)];
        }

    }
}
