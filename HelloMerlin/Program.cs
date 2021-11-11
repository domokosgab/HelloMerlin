using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Merlin!"); 

            //egész szám tÍpusú változó deklarációja (a)
            int a;
            a = 10;

            //egy második szám deklarációja direkt értékadással (b)
            int b = 7;

            //a két szám összegének tárolása egy változóban (sum)
            int sum = a + b;

            //az összeg kiíratása a konzolra
            Console.WriteLine(sum);
        }
    }
}