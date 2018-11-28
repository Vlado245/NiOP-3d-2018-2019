using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomljenovicVladoDateTimeKO
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Nova = new DateTime(2019, 1, 1, 0, 0, 0);
            DateTime Sada = DateTime.Now;
            int dan, sat, min, sec;
            dan = Nova.Day - Sada.Day;
            sat = Nova.Hour - Sada.Hour;
            min = Nova.Minute - Sada.Minute;
            sec = Nova.Second - Sada.Second;
            Console.WriteLine("Do Nove Godine ostalo je : ");
            Console.WriteLine("dana " + dan);
            Console.WriteLine("sati " + sat);
            Console.WriteLine("minuta " + min);
            Console.WriteLine("sekundi " + sec);
            Console.ReadKey();
                

        }
    }
}
