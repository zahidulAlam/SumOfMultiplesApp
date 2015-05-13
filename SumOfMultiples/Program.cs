using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>();
            //for (int i = 3; i < 1000; i += 3)
            //{
            //    numbers.Add(i);
            //}

            //for (int j = 5; j < 1000; j += 5)
            //{
            //    numbers.Add(j);
            //}
            //numbers.ForEach(Console.WriteLine);
            //int sum = numbers.Sum();
            //Console.WriteLine(sum);

            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum = sum + i;
                }
            }

                Console.WriteLine(sum);
                Console.ReadKey();
        }
    }
}
