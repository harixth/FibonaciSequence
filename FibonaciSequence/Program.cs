using System;

namespace FibonaciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0, x = 1, y = 2, sum=2;
            Console.WriteLine(x);
            Console.WriteLine(y);
            while (num < 4000000)
            {
                num = x + y;
                if (num%2==0)
                {
                    sum = sum + num;
                }
                x = y;
                y = num;
                Console.WriteLine(num);
            }

            Console.WriteLine($"Sum of the even number is {sum}");
        }
    }
}
