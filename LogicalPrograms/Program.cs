namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select:- \n 1.FibonacciSeries \n 2.PerfectNumber \n 3.PrimeNumber");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FibonacciSeries fibonacciSeries = new FibonacciSeries();
                        fibonacciSeries.CalculateFibonacciSeries();
                        break;
                        case 2:
                        PerfectNumber perfectNum = new PerfectNumber();
                        perfectNum.CheckPerfectNumber();
                        break;
                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.CheckprimeNumber();
                        break;

                }
                
            }
                




               
        }
    }
}