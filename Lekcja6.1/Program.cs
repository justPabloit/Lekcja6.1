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

            Console.WriteLine("Zgadnij liczbę z Zakresu 1-10");
            do
            {
                
                Console.WriteLine("Podaj liczbę: ");
                mojaLiczba = int.Parse(Console.ReadLine());

                if (mojaLiczba >los)
                {
                    Console.WriteLine("Podałeś zbyt dużą liczbę!");
                }
                else if(mojaLiczba < los)
                {
                    Console.WriteLine("Podałeś zbyt małą liczbę");
                }
                else
                {
                    Console.WriteLine("Brawo odgadłeś moją liczbę");
                }

            } while (los != mojaLiczba);


            Console.ReadLine();
        }
    }
}
