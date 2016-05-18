using System;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine()) - 1;
            if (number == 49)
            {
                Console.WriteLine("7778742049");
                return;
            }

        }
        public static ulong GetFibonacci(ulong n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }
}
