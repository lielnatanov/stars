using System;

namespace Array_sorting_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Mynumber = { 5, 6, 3, 2 };
            int big = 0;
            Console.WriteLine("oringal array");
            foreach (var big in Mynumber)
            {
                Console.WriteLine(big);
            }
            for (int i = 0; i < Mynumber.Length; i++)
            {
                for (int k = i + 1; k < Mynumber.Length; i++)

                    if (Mynumber[i] > Mynumber[k])
                    {
                        big = Mynumber[i];
                        Mynumber[i] = Mynumber[k];
                        Mynumber[k] = big;
                    }
            }
        }


    }


}
             
        


    


