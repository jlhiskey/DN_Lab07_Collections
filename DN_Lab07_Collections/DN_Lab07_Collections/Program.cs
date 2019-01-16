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

            Deal(fullDeck);

            

            Console.ReadLine();

        }

        /// <summary>
        /// Takes a created deck of cards as a param and lists the cards as a console log.
        /// </summary>
        /// <param name="cardDeck"></param>
        public static void PrintCards(Deck<Card> cardDeck)
        {
            Console.WriteLine("The cards in your deck are: ");
            foreach (Card card in cardDeck)
            {
                Console.WriteLine($"{card.Suit} {card.Denomination}");
            }

        }

        public static void Deal(Deck<Card> deck)
        {
            Console.WriteLine("Dealing Cards Now");
            Console.WriteLine();

            Deck<Card> deckForPlayerOne = new Deck<Card>();
            Deck<Card> deckForPlayerTwo = new Deck<Card>();
            Card[] avaliableCards = new Card[deck.Count()];
            int currentIndex = 0;

            foreach(Card card in deck)
            {
                avaliableCards[currentIndex] = card;
                currentIndex = currentIndex + 1;
            }


            for (int i = 0; i < deck.Count(); i++)
            {
                if (i % 2 == 0)
                {
                    deckForPlayerOne.Add(avaliableCards[i]);
                }
                else
                {
                    deckForPlayerTwo.Add(avaliableCards[i]);
                }

            }
            Console.WriteLine("Player One Cards");
            PrintCards(deckForPlayerOne);
            Console.WriteLine();
            Console.WriteLine("Player Two Cards");
            PrintCards(deckForPlayerTwo);
        }
    }
}
