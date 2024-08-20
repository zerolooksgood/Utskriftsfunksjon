using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utskriftsfunksjon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            func(); //Her kaller jeg funskjonen/metoden. Da kjører den som om den er en del av hovedprogrammet
            func();
            func();
            Console.ReadLine();
        }

        static void func() //Her definerer jeg funksjonen/metoden, denne gangen uten argumenter
        {
            //Dette fungerer som et vanlig program
            Console.WriteLine("Skriv inn navn:");
            string navn = Console.ReadLine();
            Console.WriteLine("Skriv inn et bosted");
            string bosted = Console.ReadLine();
            Console.WriteLine($"Du heter {navn} og bor på {bosted}");
        }
    }
}
