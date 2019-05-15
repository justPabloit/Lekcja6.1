using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int los = rnd.Next(1,11);
            int mojaLiczba;


            do
            {
                Console.WriteLine("Zgadnij liczbę z Zakresu 1-10");
                Console.WriteLine("Podaj liczbę: ");
                mojaLiczba = int.Parse(Console.ReadLine());

            } while (los != mojaLiczba);


            Console.ReadLine();
        }
    }
}
