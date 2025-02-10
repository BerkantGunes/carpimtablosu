using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpimtablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 den baslayarak 10 a kadar giden carpim tablosunu olustur.
            for(int i = 1; i < 11 i++)
            {
                for(int j = 1; j<11; j++)
                {
                    Console.Write(i + "X" + j + "=" + i*j + "\t"); // \t tab tusuna denk geliyor o da yanyana yazdirmamizi saglar.
                }
            }
        }
    }
}
