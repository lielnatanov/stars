using System;

namespace LoopsHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("plese give a number");

            int myNum = int.Parse(Console.ReadLine());

            int first = 0;
            int second = 0;
            int third = 0;

            while (myNum >= 100)
            {
                first++;
                myNum -= 100;
            }
            while (myNum >= 30)
            {
                second++;
                myNum -= 30;
            }
            while (myNum >= 10)
            {
               third++;
                myNum -= 10;
            }

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine(myNum);
        }
    }
}
