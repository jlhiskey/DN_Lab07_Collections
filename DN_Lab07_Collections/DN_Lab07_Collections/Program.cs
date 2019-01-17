﻿using System;
using DN_Lab07_Collections.Classes;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck<Card> fullDeck = new Deck<Card>("Full Deck");

            fullDeck = fullDeck.FullDeck();

            Deal(fullDeck);

            Card c53 = new Card(Card.SuitType.Spades, Card.DenominationType.Ace);
            UIAddCard(c53, fullDeck);

            

            Console.ReadLine();

        }

        /// <summary>
        /// Adds a new card to an existing deck of cards.
        /// </summary>
        /// <param name="newCard"></param>
        /// <param name="existingDeck"></param>
        public static void UIAddCard(Card newCard, Deck<Card> existingDeck)
        {
            existingDeck.Add(newCard);
            Console.WriteLine($"You added a {newCard.Denomination} of {newCard.Suit} to Card Deck: {existingDeck.Name}.");
            Console.WriteLine($"Your deck now has {existingDeck.Count()} cards in it.");
        }

        /// <summary>
        /// Takes a created deck of cards as a param and lists the cards as a console log.
        /// </summary>
        /// <param name="cardDeck"></param>
        public static void PrintCards(Deck<Card> cardDeck)
        {
            Console.WriteLine($"Card Deck: {cardDeck.Name}");
            Console.WriteLine($"Contains {cardDeck.Count()} cards.");
            Console.WriteLine();
            foreach (Card card in cardDeck)
            {
                Console.WriteLine($"{card.Denomination} of {card.Suit}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Deals a premade deck of cards to two players and returns the cards that were dealt.
        /// </summary>
        /// <param name="deck"></param>
        public static void Deal(Deck<Card> deck)
        {
            Console.WriteLine("Dealing Cards Now");
            Console.WriteLine();

            Deck<Card> deckForPlayerOne = new Deck<Card>("Player One's Deck");
            Deck<Card> deckForPlayerTwo = new Deck<Card>("Player Two's Deck");
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
            PrintCards(deckForPlayerOne);
            Console.WriteLine();
            PrintCards(deckForPlayerTwo);
        }
    }
}
