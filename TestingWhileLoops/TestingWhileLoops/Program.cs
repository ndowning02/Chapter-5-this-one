using System;

namespace TestWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            displayForLoops();
        }
        public static void displayForLoops()
        {
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(i);
            }
            for (int j = 10;j >=0; --j)
            {
                Console.WriteLine(j);
            }
            

        }
  
        
        public static void displayDoWhile()
        {
            int count = 0;

            string response;

            do
            {
                do
                {

                    Console.WriteLine(count);
                    count++;
                } while (count < 10);

                do
                {
                    Console.WriteLine(count);
                    count--;
                } while (count > 0);
                Console.WriteLine("Would you like to count again? Y or N");
                response = Console.ReadLine();

            } while ("Y" != response);



        }
        public static void displayWhile()
        {
            int num = 100;
            int num2 = 0;
            int num3 = 0;
            bool again = true;

            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
                num = num - 5;
            }
            while (again)
            {

            }
        }
    }
}


