using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!"
            //kui siestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN, proovi uuesti!"
            //kasutajal on kolm katset. i < 3

            int i = 0; //i - iteration

            while(i < 3) //while-loop >> i = 1, i < 3 --> true, 2 < 3 --> true, 3 < 3 --> false;
            {
                Console.WriteLine("Sisesta PIN!");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    //(i = i + 1) == i++
                    i++;
                    Console.WriteLine($"Vale PIN, {3 - i} katset on jäänud.");
                }

            }
            
            Console.WriteLine("Kena päeva!");
        }
    }
}
