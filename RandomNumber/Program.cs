using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit 1 kuni 10ni
            //kui genereeritud number on 5, programm lõpetab oma töö ja soovib kasutajale "Kena päeva"
            //kui genereeritud number on miski muus, siis programm jätkab oma tööd

            Random rnd = new Random();
            int i = 0;
            
            while(i != 5)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on {myRandomNumber}");
                
                if(myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }
            }

            Console.WriteLine("Kena päeva!");
            
        }
    }
}
