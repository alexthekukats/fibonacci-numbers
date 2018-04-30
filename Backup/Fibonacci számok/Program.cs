using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static int n = 0;
        static void Main(string[] args)
        {
                while (n < 1000000000)
                {

                    double F = 0;
                    double prev = 1;
                    double next;
                    for (int i = 0; i < n; ++i)
                    {
                        next = F + prev;
                        prev = F;
                        F = next;
                    }
                    Console.WriteLine(Convert.ToDouble(F));
                    n += 1;

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter("fibonacci.txt", true))
                    {
                        file.WriteLine(F);
                        file.Close();
                    }

                    //System.Threading.Thread.Sleep(1000);
                }
                Console.ReadKey();
        }

        /*static int fibonacci( int n)
        {
            if ((0 == n) || (1 == n))
            {
                return n;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }

        public int fibonacciline(int n)
        {
            int F = 0;
            int prev = 1;
            int next;
            for (int i = 0; i < n; ++i)
            {
                next = F + prev;
                prev = F;
                F = next;
            }
            return F;
        }*/


    }
}
