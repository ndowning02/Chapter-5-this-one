using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFourInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEntry;
            int total =0;
            int i = 0;

            while(i < 4)
            {
                Console.WriteLine("Enter a number please");
                numEntry = Convert.ToInt32(Console.ReadLine());
                total = total + numEntry;
                i++;
            }
            Console.WriteLine(total);

        }

    }
}
