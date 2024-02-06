using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peli
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pekka Pelaaja herää tuntemattomassa huoneessa ilman tietoisuutta.");
            Console.WriteLine("Hän tutkii huonetta ja löytää vihjeitä ja muita arvoituksia");
            Console.WriteLine("Pekka löytää avaimen.");

            Console.WriteLine("1 = Avataan lukittu laatikko.");
            Console.WriteLine("2 = Etsitään lisää vihjeitä.");
            int valinta1 = Convert.ToInt32(Console.ReadLine());
            if (valinta1 == 1)
            {
                Console.WriteLine("Avataan laatikko.");
                Console.WriteLine("Laatikossa on kirje");
                Console.WriteLine("Kirjeessä on salakoodi.");
                Console.WriteLine("Sen ratkaisu näyttää koodin salaoveen.");
                Console.WriteLine("Pekka ratkaisee sen ja menee ovesta sisään.");
                Console.WriteLine("Löytyy toinen huone, se on täynnä ystävällisiä hahmoja.");
                Console.WriteLine("Valitse, että haluatko keskustella hahmojen kanssa.");
                Console.WriteLine("1 = Kyllä");
                Console.WriteLine("2 = Ei");
                int keskustele1 = Convert.ToInt32(Console.ReadLine());
                if (keskustele1 == 1)
                {
                    Console.WriteLine("Keskustellessa, hahmot kertovat talon murhaajaomistajasta.");
                    Console.WriteLine("He jakavat tarinallisia palasia Pekalle.");
                    Console.WriteLine("Pekka tarinoiden ja oman mietinnänsä vuoksi keksii miten päsee pois talosta ja selviytyy!");
                    Console.WriteLine("PELI VOITETTU! WOOO (oli kyl tosi vaikee) ;D");
                    Console.ReadKey();

                }

                else if (keskustele1 == 2)
                {
                    Console.WriteLine("Kun päätit olla juttelematta hahmoille...");
                    Console.WriteLine("Luulet selviäväsi yksin, mutta niin ei käy, kuolet");
                    Console.WriteLine("GAME OVER.");
                    Console.ReadKey();
                }

            }
            //int valinta2 = Convert.ToInt32(Console.ReadLine());
            if (valinta1 == 2)
            {
                Console.WriteLine("Vihjeitä ei löydy.");
                Console.WriteLine("Valitse, että huudatko apua?");
                Console.WriteLine("1 = Kyllä");
                Console.WriteLine("2 = Ei");
                int apua1 = Convert.ToInt32(Console.ReadLine());
                if (apua1 == 1)
                {
                    Console.WriteLine("Apua ei tule.");
                    Console.WriteLine("Kuolet nälkään");
                    Console.WriteLine("kuolit. GAME OVER, noob. :(");
                    Console.ReadKey();
                }

                else if (apua1 == 2)
                {
                    Console.WriteLine("Yritä paeta.");
                    Console.WriteLine("Jäät kiinni talonomistajalle ja hän tappaa sinut.");
                    Console.WriteLine("GAME OVER");
                    Console.ReadKey();
                }
               
            }
        }
    }
} 


