using System;

namespace DemoExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Example 2"+ "\n\n");
            Console.WriteLine( "Enter the option");
            Console.WriteLine("1.FibonacciSeries"+ "\n" +
                                "2.PerfectNumber"+"\n");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    FibonacciSeries series = new FibonacciSeries();
                    Console.WriteLine("\n\n"+"Enter the FibonacciSeries Value"+"\n");
                    int range = Convert.ToInt32(Console.ReadLine());
                    series.Print(range);
                    break;
                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    Console.WriteLine("\n\n" + "Check the Number Perfect or Not" + "\n");
                    Console.WriteLine("Enter the Value"+"\n\n");
                    int value = Convert.ToInt32(Console.ReadLine());
                    perfectNumber.Check(value);
                    break;
            }
        }
    }
}
