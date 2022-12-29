using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read the input numbers start number and end numbers

            Console.WriteLine("Enter The Start Prime Number: "); ;
            int StartNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The End Prime Number: "); ;
            int EndNumber = int.Parse(Console.ReadLine());

            // find the prime numbers between start number and rnd number
            for (int i = StartNumber; i <= EndNumber; i++)
            {
                int sum = 0;
                // check if i is prime number 
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        sum++;
                        break;
                    }
                }

                if (sum == 0 && i != 1)
                {
                    Console.Write("{0} " , i);
                }
            }
            Console.ReadKey();
        }
    }
}
