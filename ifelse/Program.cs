using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int  age;
            int hour ;

            age = int.Parse (Console.ReadLine());
            hour = int.Parse (Console.ReadLine());

            if (age<18 && hour>21)
            {
                Console.WriteLine("not allowed to watch TV");
            }
            else
            {
                Console.WriteLine("allowed to watch TV");
            }
          
            
        }
    }
}
