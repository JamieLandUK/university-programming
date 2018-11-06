using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerical_func
{
    class NumericalFunc
    {
        public Boolean PrimeTest(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int Power(int a, int b)
        {
            int answer = a;
            for (int i = 1; i < b; i++)
            {
                answer *= a;
            }
            return answer;
        }

        public long Fibonacci(long n)
        {
            if (n == 1 || n == 2) {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NumericalFunc nf = new NumericalFunc();
            Console.WriteLine(nf.PrimeTest(619));
            Console.WriteLine(nf.Power(16, 3));
            Console.WriteLine(nf.Fibonacci(50));
            Console.ReadKey();
        }
    }
}
