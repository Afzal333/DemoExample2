using System;
using System.Collections.Generic;
using System.Text;

namespace DemoExample2
{
    public class PrimeNumber
    {
        public void CheckPrime(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                    count++;
            }
            if (count == 2)
                Console.WriteLine("Number is a Prime Number");
            else
                Console.WriteLine("Num is not a prime number");

        }
    }
        
}
