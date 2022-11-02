using System;
using System.Collections.Generic;
using System.Text;

namespace DemoExample2
{
    public class PerfectNumber
    {
        public void Check(int num)
        {
            int sum=0;
            for(int i = 1; i <= num / 2; i++)
            {
                if(num % i == 0)
                {
                    sum+=i;
                }
            }
            if(num==sum)
                Console.WriteLine("Number provided ia an PerfectNumber ");
            else
                Console.WriteLine("Not an PerfectNumber");
        }
    }
}
