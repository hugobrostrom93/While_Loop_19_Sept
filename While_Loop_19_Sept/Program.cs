using System.Collections.Generic;

namespace Whie_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var whileloopar = new WhileLoopar();

            //whileloopar.GuessMyNumber();
            //whileloopar.GuessMyNumber(15);
            //whileloopar.AskUserForANumber(4);
            //whileloopar.AskUserForANumberTwo(4);
            //whileloopar.NestledLoops(3);
            //whileloopar.CountUpOrDown(7, 1);
            whileloopar.BreakTheLoop(222);
        }




        class WhileLoopar
        {
            public void GuessMyNumber(int max = 10)
            {
                Console.WriteLine("Övning 1");
                Console.WriteLine("+-----------+");
                Random random = new Random();
                var randNumber = random.Next(1, max + 1);
                var guess = 0;
                while (guess != randNumber)
                {
                    Console.WriteLine($"Gissa ett tal mellan 1 och {max}");
                    var input = Console.ReadLine();
                    // _ betyder att den ska strunta i returvärdet.
                    _ = int.TryParse(input, out guess);
                }
            }

            public void AskUserForANumber(int max = 100)
            {
                Console.WriteLine("Övning 2 - Mitt sätt");
                Console.WriteLine("+-----------+");
                Console.WriteLine("1 - Margarita");
                Console.WriteLine("2 - Capricciosa");
                Console.WriteLine("3 - Calzone");
                Console.WriteLine("4 - Marcus Special");
                Console.WriteLine("");
                Console.WriteLine("Ange vad du vill ha på menyn!: ");
                string svar = Console.ReadLine();
                int svarInt = Int32.Parse(svar);


                while (svarInt == 1)
                {
                    Console.WriteLine("Mumms Margarita");
                    break;
                }

                while (svarInt == 2)
                {
                    Console.WriteLine("Mumms Capricciosa");
                    break;
                }

                while (svarInt == 3)
                {
                    Console.WriteLine("Mumms Calzone");
                    break;
                }

                while (svarInt == 4)
                {
                    Console.WriteLine("Mums Marcus Spcial!");
                    break;
                }

                while (svarInt >= 5 || svarInt <= 0)
                {
                    Console.WriteLine("Ange ett nummer mellan 1 och 4 tack!");
                    break;
                }
            }

            public void AskUserForANumberTwo(int max = 100)
            {
                Console.WriteLine("Övning 2 - Facit");
                Console.WriteLine("+-----------+");
                Console.WriteLine("Skriv ett tal");
                var input = Console.ReadLine();
                if (int.TryParse(input, out int number)) // gör om input till en int och lägger den i variabeln "nummer"
                {
                    if (number > max)
                    {
                        Console.WriteLine($"Ditt tal är för högt, ange ett tal som är som mest {max}");
                    }
                    else if (number < 0)
                    {
                        Console.WriteLine("Ditt tal är för lågt, ange ett tal som är som minst 0");
                    }
                    else
                    {
                        Console.WriteLine($"Helt OK tal: {number}");
                    }
                }
            }

            public void NestledLoops(int max = 3)
            {
                Console.WriteLine("Övning 3 - Facit");
                Console.WriteLine("+-----------+");

                int loopOne = 0;
                while (loopOne++ < max)
                {
                    int loopTwo = 0;
                    while (loopTwo++ < max)
                    {
                        Console.WriteLine($"Loop värde: {loopOne}:{loopTwo}");
                    }
                }
            }


            public void CountUpOrDown(int start, int stop)
            {
                Console.WriteLine("Övning 4 - Facit");
                Console.WriteLine("+-----------+");
                int diff = 1;
                if (start > stop) diff = -1;
                int counter = start;
                Console.WriteLine($"Loop: {start} - {stop}");
                while (true)
                {
                    Console.WriteLine($"Counter = {counter}");
                    counter += diff;
                    if (diff == 1 && counter > stop) break;
                    if (diff == -1 && counter < stop) break;
                }

            }

            public void BreakTheLoop(int breaker)
            {
                int counter = 0;
                while (counter++ < 999)
                {
                    Console.WriteLine(counter);
                    if (counter == breaker) break;
                }
                Console.WriteLine($"Stoppade loopen på {breaker}");
            }



        }




    }
}