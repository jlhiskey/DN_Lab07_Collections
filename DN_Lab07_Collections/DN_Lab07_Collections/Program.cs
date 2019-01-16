using System;
using DN_Lab07_Collections.Classes;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck<Card> fullDeck = new Deck<Card>();

            fullDeck.FullDeck();

            int howMany = fullDeck.Count();



            Console.WriteLine(howMany);

            Console.ReadLine();
        }
    }
}
