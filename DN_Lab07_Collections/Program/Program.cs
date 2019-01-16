using System;
using DN_Lab07_Collections.Classes;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck<Card> fullDeck = new Deck<Card>();

            Card c1 = new Card(Card.SuitType.Clubs, Card.DenominationType.Two);
            Card c2 = new Card(Card.SuitType.Clubs, Card.DenominationType.Three);
            Card c3 = new Card(Card.SuitType.Clubs, Card.DenominationType.Four);
            Card c4 = new Card(Card.SuitType.Clubs, Card.DenominationType.Five);
            Card c5 = new Card(Card.SuitType.Clubs, Card.DenominationType.Six);
            Card c6 = new Card(Card.SuitType.Clubs, Card.DenominationType.Seven);
            Card c7 = new Card(Card.SuitType.Clubs, Card.DenominationType.Eight);
            Card c8 = new Card(Card.SuitType.Clubs, Card.DenominationType.Nine);
            Card c9 = new Card(Card.SuitType.Clubs, Card.DenominationType.Ten);
            Card c10 = new Card(Card.SuitType.Clubs, Card.DenominationType.Jack);
            Card c11 = new Card(Card.SuitType.Clubs, Card.DenominationType.Queen);
            Card c12 = new Card(Card.SuitType.Clubs, Card.DenominationType.King);
            Card c13 = new Card(Card.SuitType.Clubs, Card.DenominationType.Ace);

            Card[] allCards = { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13 };
            for (int i = 0; i < 13; i++)
            {
                fullDeck.Add(allCards[i]);
            }

            int howMany = fullDeck.Count();



            Console.WriteLine(c1);

            Console.ReadLine();
        }
    }
}
