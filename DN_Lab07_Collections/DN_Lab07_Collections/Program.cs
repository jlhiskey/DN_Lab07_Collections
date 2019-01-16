using System;
using DN_Lab07_Collections.Classes;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck<Card> fullDeck = new Deck<Card>();

            fullDeck = fullDeck.FullDeck();

            int howMany = fullDeck.Count();

            PrintCards(fullDeck);

            Console.WriteLine(howMany);

            Console.ReadLine();
        }

        public static void PrintCards(Deck<Card> cardDeck)
        {
            Console.WriteLine("The cards in your deck are: ");
            foreach (Card card in cardDeck)
            {
                Console.WriteLine($"{card.Suit} {card.Denomination}");
            }

        }
    }
}
