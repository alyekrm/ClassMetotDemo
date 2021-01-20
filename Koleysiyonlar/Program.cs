using System;
using System.Collections.Generic;

namespace Koleysiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            isimler[4] = "İlker";

            List<string> isimler2 = new List<string> { "Engin","Murat","Kerem","Halil"};
        }
    }
}
