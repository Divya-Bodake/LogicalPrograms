using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public void CheckPerfectNumber()
        {
            int n, i, sum;
            int mn, mx;
            Console.WriteLine("Find the Perfect Number:");

            Console.WriteLine("Enter the starting number:");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending number:");
            mx = Convert.ToInt32(Console.ReadLine());
            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;

                }
                if (sum == n)
                    Console.WriteLine("{0}", n);
            }

        }
    }
}
