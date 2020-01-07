using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int r = rnd.Next(1, 100);
            int userEntry;
            int tries = 0;
            bool again = true;
            while (again)
            {


                {
                    Console.WriteLine("Please enter a number between 1 and 100.");
                    userEntry = Convert.ToInt32(Console.ReadLine());
                    if (userEntry > r)
                    {
                        Console.WriteLine("That number is too high");
                    }
                    else if (userEntry < r)
                    {
                        Console.WriteLine("That number is too low");
                    }
                    else if (userEntry == r)
                    {
                        Console.WriteLine("That is correct!");
                    }
                    if (tries == 6)
                    {
                        Console.WriteLine("To many attempts");
                        again = false;
                    }
                }


            }
        }
    }
}
