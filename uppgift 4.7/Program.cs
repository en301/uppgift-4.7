using System;

namespace uppgift_4_7
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett meddelande");
            string meddelande = Console.ReadLine();

            Console.WriteLine("Skriv in hur många steg meddelandet ska ligga");
            int steg = int.Parse(Console.ReadLine());

            for (int i = 0; i < meddelande.Length; i++)
            {
                for (int j = 0; j < steg; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(meddelande[i]);
            }
            Console.ReadKey();
        }
    }
}