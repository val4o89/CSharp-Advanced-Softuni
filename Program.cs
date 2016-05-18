using System;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8
{
    class Program
    {
        static ulong[] numbers;

        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());

            numbers = new ulong[number + 2];
            numbers[1] = 1;
            numbers[2] = 1;
            ulong result = GetFibonacci(number);

            Console.WriteLine(result);
        }
        public static ulong GetFibonacci(ulong n)
        {
            if (numbers[n] == 0)
            {
                numbers[n] = GetFibonacci(n - 1) + GetFibonacci(n - 2);
            }
            return numbers[n];
        }
    }
}
