using System;

namespace PINInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!"
            //kui siestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN, proovi uuesti!"
            //katsete arv on piiramatu

            bool loopActive = true; //boolean - true/false
            int i = 0;

            while(loopActive)
            {
                Console.WriteLine("Sisesta PIN!");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale PIN, proovi uuesti.");
                    Console.WriteLine($"Oled vale PIN koodi {i} korda sisestanud");
                }
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
