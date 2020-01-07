using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int testScore = 0;
            int testAvg = 0;
            int testTotal = 0;

             for (int count = 1; count < 4; count++)
            {

                Console.WriteLine("Please enter your test score. or 999 to exit");
                testScore = int.Parse(Console.ReadLine());

                testTotal = testTotal + testScore;
                testAvg = testTotal / count;
                
            }


            Console.WriteLine("Your average test score was " + testAvg);

                
        }
    }
}
