using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eltele_oppgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Fikser litt på titel å må bruke program div = new... pga vi er i Main.
                Console.Title = "Eltele Alternative 1";
                Program div = new Program();
                var number_read = Int32.Parse(Console.ReadLine()); //Converter string til int.

                div.check_div(number_read); //starter delt på funksjon
                Console.ReadLine();
            } catch (Exception errors) //Ser etter feil om noe er feil under oppstart
            {
                Console.WriteLine("ERROR: {0}", errors);
                Console.ReadLine();
            }
            
        }

        public static class Globals
        {
            public static int global_candivon = 1; //global variables
        }

        public void check_div(int number)
        { 
            //Vi bruker try så om noe er feil så krajser ikke programet
            try
            {
                int number_candivon = Globals.global_candivon; //Henter global variables og bruker valuen til en local var

                if (number_candivon % number == 0) //Starter deltpå
                {
                    if (number_candivon == 3)
                    {
                        Console.Write("Kake");
                    }
                    else
                    {
                        if (number_candivon == 5)
                        {
                            Console.Write("Boks");
                        }
                    }

                }

                Globals.global_candivon = Globals.global_candivon + 1; //Siden vi skal telle fra 1-100 så bruker jeg dette 

                if (Globals.global_candivon > 100) //Når den blir 100 så stopper vi
                {
                    Console.WriteLine();
                    Console.WriteLine("{0}", number);
                    Globals.global_candivon = 1;
                    var new_number = Int32.Parse(Console.ReadLine());

                    if (new_number < 1)
                    {
                        Console.WriteLine("Can't be a number less then 1.");
                    }
                    else
                    {
                        check_div(new_number); //Om vi er høyre en 0 så jobber vi videre med nytt tall
                    }

                }
                else
                {

                    check_div(number); //Om vi ikke er 100 så teller vi videre.
                }
            } catch (Exception errors) //Feil meldinger
            {
                Console.WriteLine("ERROR: {0}", errors);
                Console.ReadLine();
            }          
        }
    }
}
