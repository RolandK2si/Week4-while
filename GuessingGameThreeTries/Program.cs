using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit (1 kuni 10ni);
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis ta on võitja;
            //kasutajal on kolm katset, kui kasutaja ei suuda kolme katsega numbrit ära arvata, siis mängu võidab arvuti
            //programm genereerib juhsuliku numbrit vaid ühte korda

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Palun sisesta number.");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (cpuNumber == userGuess)
                {
                    Console.WriteLine("Palju õnne, sa oled võitja!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Palun proovi uuesti. Sul on alles {3 - i} katset");
                }

                if(i == 3)
                {
                    Console.WriteLine("Sa kaotasid arvutile.");
                }
            }

        }
    }
}
