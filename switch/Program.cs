using System;

namespace change
{
    class Program
{
    static void Main(string[] args)
    {
        int day = 7;
        switch (day)
        {
            case 1:
                Console.WriteLine("Mon");
                break;
            case 2:
                Console.WriteLine("Tue");
                break;
            case 3:
                Console.WriteLine("Wed");
                break;
            case 4:
                Console.WriteLine("Thu");
                break;
            case 5:
                Console.WriteLine("Fri");
                break;
            case 6:
                Console.WriteLine("Sat");
                break;
            case 7:
                Console.WriteLine("Sun");
                break;
                //outputs out of range
               
        }
    }        
}
}
