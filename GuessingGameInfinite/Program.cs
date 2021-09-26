using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit (1 kuni 10ni);
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis ta on võitja;
            //katsete arv on piiramatu
            //programm genereerib juhsuliku numbrit vaid ühte korda

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Palun sisesta number.");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if(cpuNumber == userGuess)
                {
                    Console.WriteLine("Palju õnne, sa oled võitja!");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Palun proovi uuesti.");
                }
            }

        }
    }
}
