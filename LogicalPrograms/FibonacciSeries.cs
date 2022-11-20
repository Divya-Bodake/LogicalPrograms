using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        static int num1 = 0, num2 = 1, num3, num;
        public void CalculateFibonacciSeries()
        {
            Console.WriteLine("Enter the number of ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write(num1 + " " + num2 + " ");
            for (int i = 2; i < num; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }

        }
    }
}
