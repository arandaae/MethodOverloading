using System;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Add(2, 4);
           Add(3.5, 5.3);
           Console.WriteLine(Add(2, 2, true));
        }

        public static int Add(int x, int y)
        {
           Console.WriteLine(x + y);
           return x + y;          
        }

        public static double Add(double x, double y)
        {
            Console.WriteLine(x + y);
            return x + y;
        }

        public static string Add(int x, int y, bool verify)
        {
            int sum = x + y;

            if (verify == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if(verify == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (verify == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }

    }
}
