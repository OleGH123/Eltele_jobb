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
                //Fikser litt på titel
                Console.Title = "Eltele Alternative 1";
                var number_read = Int32.Parse(Console.ReadLine()); //Converter string til int.

                Check_div(number_read); //starter delt på funksjon
            } catch (Exception errors) //Ser etter feil om noe er feil under oppstart
            {
                Console.WriteLine("ERROR: {0}", errors);
                Console.ReadLine();
            }
            
        }

        public static void Fnc_keepgoing()
        {
            Console.WriteLine();
            Console.WriteLine("Type 'yes' if you wanna keep going or type 'exit' to exit.");
            Console.WriteLine();
            var str_keepgoing = Console.ReadLine(); //Henter info fra linja
            
            if (str_keepgoing == "yes") //Vis han skreiv yes så starter vi på nytt men først trenger vi et tall vi skal bruke
            {
                Console.WriteLine("Type a number you wanna devide on.");
                var new_number = Int32.Parse(Console.ReadLine()); //henter tall, convert fra str til int

                if (new_number < 1)
                {
                    Console.WriteLine("Can't be a number less then 1.");
                }
                else
                {
                    Check_div(new_number);
                }
            }
        }

        public static void Check_div(int number)
        {
            //Vi bruker try så om noe er feil så krajser ikke programet
            Console.Clear();


            //Var for og telle hvormange av de vi har
            int Amount_kakeboks = 0;
            int Amount_Kake = 0;
            int Amount_Boks = 0;

            try
            {

                //Start for loop
                for (int i = 0; i < 100; i++)
                {
                    if (i % number == 0) //Starter deltpå
                    {
                        if (i % 3 == 0 && i % 5 == 0) //Sjekke kakeboks 
                        {
                            Console.Write("Kakeboks,");
                            Amount_kakeboks = Amount_kakeboks + 1;
                        } else
                        {
                            if (i % 3 == 0) //Sjekke kake
                            {
                                Console.Write("Kake,");
                                Amount_Kake = Amount_Kake + 1;
                            } else
                            {
                                if (i % 5 == 0) //Sjekke boks
                                {
                                    Console.Write("Boks,");
                                    Amount_Boks = Amount_Boks + 1;
                                } else
                                {
                                    Console.Write("{0},", i); //Print tallet om ingen av de gikk.
                                }
                            }
                        }                        
                    }                  
                }
                Console.WriteLine();
                Console.WriteLine();

                //Print ut hvormange vi har av ver
                Console.WriteLine("Amount Kakeboks: {0}", Amount_kakeboks);
                Console.WriteLine("Amount Kake: {0}", Amount_Kake);
                Console.WriteLine("Amount Boks: {0}", Amount_Boks);

                Console.WriteLine();
                Fnc_keepgoing(); //Spør om brukeren har løst og prøve igjen
            } catch (Exception errors) //Feil meldinger
            {
                Console.WriteLine("ERROR: {0}", errors);
                Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
