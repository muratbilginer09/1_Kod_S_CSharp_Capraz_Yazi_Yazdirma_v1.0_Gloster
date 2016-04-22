using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Çapraz_Yazı_Yazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Industryolog";

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0," + (i + s.Length-1) + "}", s);
            }
            Console.ReadKey();
        }
    }
}
