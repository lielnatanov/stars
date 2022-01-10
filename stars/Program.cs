using System;

namespace stars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("plese give a number");

            int myNum = int.Parse(Console.ReadLine());

            bool isEven = myNum % 2 == 0;
            int counter;
            if (isEven)
            {
                counter = 2;
            }
            else
            {
                counter = 1;
            }
            while (counter <= myNum)
            {
                for (int i = 0; i < counter; i++)
                {
                    Console.Write("*");
                }
                counter += 2;
                Console.WriteLine();
            }



        }
    }
}
