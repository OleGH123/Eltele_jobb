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
                Console.Title = "Eltele Alternative 1";
                Program div = new Program();
                var number_read = Int32.Parse(Console.ReadLine());

                div.check_div(number_read);
                Console.ReadLine();
            } catch (Exception errors)
            {
                Console.WriteLine("ERROR: {0}", errors);
                Console.ReadLine();
            }
            
        }

        public static class Globals
        {
            public static int global_candivon = 1;
        }

        public void check_div(int number)
        { 
            try
            {
                int number_candivon = Globals.global_candivon;

                if (number_candivon % number == 0)
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

                Globals.global_candivon = Globals.global_candivon + 1;

                if (Globals.global_candivon > 100)
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
                        check_div(new_number);
                    }

                }
                else
                {

                    check_div(number);
                }
            } catch (Exception errors)
            {
                Console.WriteLine("ERROR: {0}", errors);
                Console.ReadLine();
            }          
        }
    }
}
