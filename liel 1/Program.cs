using System;

namespace liel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ss = { "liel", "ido", "itay" };
            e1(ss);  
        }
        public static void e1(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i].ToUpper());
            }
        }
        
    }
}
