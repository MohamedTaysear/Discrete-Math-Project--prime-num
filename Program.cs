using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mohamedtaysear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, start, end, i, m;

            Console.Write("Enter the starting number of range (n1): ");
            start = int.Parse(Console.ReadLine());
            Console.Write("Enter the ending number of range (n2) : ");
            end = int.Parse(Console.ReadLine());
            Console.Write("Prime numbers between {0} and {1} are: ", start, end);

            for (num = start; num <= end; num++)
            {
                m = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        m++;
                        break;
                    }
                }

                if (m == 0 && num != 1)
                    Console.Write("{0} ", num);

            }
            Console.Write("\n");
        }
    }
}
