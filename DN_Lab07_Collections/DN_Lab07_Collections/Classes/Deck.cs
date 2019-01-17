using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DN_Lab07_Collections.Classes;

namespace DN_Lab07_Collections.Classes
{
    /// <summary>
    /// Deck class allows user to .Add, .Remove and .Count cards into the deck using the IEnumerable interface.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Deck<T> : IEnumerable<T>
    {
        public string Name { get; set; }


        public Deck(String name)
        {
            Name = name;
        }


        //Creates inital memory with enough space to hold 10 cards
        T[] cardsInDeck = new T[10];
        //instantiates current index
        int currentIndex = 0;
        
        /// <summary>
        /// Add method within Deck Class that will take a card and add it to memory. Also has ability to resize memory in more cards are added than current memory allows.
        /// </summary>
        /// <param name="card"></param>
        /// <returns>T card</returns>
        public T Add(T card)
        {
            
            //Compares current index to the size of the cardsInDeck and will resize if cardInDeck if memory is full.
            if (currentIndex > cardsInDeck.Length -1)
            {
                Array.Resize(ref cardsInDeck, cardsInDeck.Length + 10);
            }

            //Adds new card to the deck
            cardsInDeck[currentIndex] = card;
            //Increases current index.
            currentIndex = currentIndex + 1;

            //Collects the added card from the deck and returns it.
            
            return cardsInDeck[currentIndex - 1];
        }

        /// <summary>
        /// Checks deck for card and removes and resizes deck. Returns string value of card if found or "Card Not In Deck" if not found.
        /// </summary>
        /// <param name="card"></param>
        /// <returns>T card</returns>
        public T Remove(T card)
        {
            T response = default(T);
            for (int i = 0; i < currentIndex; i++)
            {
                if (card.Equals(cardsInDeck[i]))
                {
                    response = cardsInDeck[i];
                    for (int j = 0; j < currentIndex - i - 1; j++)
                    {
                        cardsInDeck[j] = cardsInDeck[j + 1];
                    }
                    currentIndex = currentIndex - 1;
                    if (currentIndex < cardsInDeck.Length - 11)
                    {
                        Array.Resize(ref cardsInDeck, cardsInDeck.Length - 10);
                    }
                }
            }
            if (response != null)
            {
                return response;
            }
            else
            {
                return response;
            }
        }

        /// <summary>
        /// Returns current number of cards in the deck.
        /// </summary>
        /// <returns>Integer</returns>
        public int Count()
        {
            return currentIndex;
        }

        /// <summary>
        /// Loads up the deck with cards and sends them.
        /// </summary>
        /// <returns>cards</returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return cardsInDeck[i];
            }
        }

        /// <summary>
        /// Builds a standard 52 card deck of cards.
        /// </summary>
        /// <returns>Full 52 card deck of cards.</returns>
        public Deck<Card> FullDeck()
        {
            Deck<Card> fullDeck = new Deck<Card>("Full Deck");

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

            Card c14 = new Card(Card.SuitType.Diamonds, Card.DenominationType.Two);
            Card c15 = new Card(Card.SuitType.Diamonds, Card.DenominationType.Three);
            Card c16 = new Card(Card.SuitType.Diamonds, Card.DenominationType.Four);
            Card c17 = new Card(Card.SuitType.Diamonds, Card.DenominationType.Five);
            Card c18 = new Card(Card.SuitType.Diamonds, Card.DenominationType.Six);
            Card c19 = new Card(Card.SuitType.Diamonds, Card.DenominationType.Seven);
            Card c20 = new Card(Card.SuitType.Diamonds, Card.DenominationType.Eight);
            Card c21 = new Card(Card.SuitType.Diamonds, Card.DenominationType.Nine);
            Card c22 = new Card(Card.SuitType.Diamonds, Card.DenominationType.Ten);
            Card c23 = new Card(Card.SuitType.Diamonds, Card.DenominationType.Jack);
            Card c24 = new Card(Card.SuitType.Diamonds, Card.DenominationType.Queen);
            Card c25 = new Card(Card.SuitType.Diamonds, Card.DenominationType.King);
            Card c26 = new Card(Card.SuitType.Diamonds, Card.DenominationType.Ace);

            Card c27 = new Card(Card.SuitType.Hearts, Card.DenominationType.Two);
            Card c28 = new Card(Card.SuitType.Hearts, Card.DenominationType.Three);
            Card c29 = new Card(Card.SuitType.Hearts, Card.DenominationType.Four);
            Card c30 = new Card(Card.SuitType.Hearts, Card.DenominationType.Five);
            Card c31 = new Card(Card.SuitType.Hearts, Card.DenominationType.Six);
            Card c32 = new Card(Card.SuitType.Hearts, Card.DenominationType.Seven);
            Card c33 = new Card(Card.SuitType.Hearts, Card.DenominationType.Eight);
            Card c34 = new Card(Card.SuitType.Hearts, Card.DenominationType.Nine);
            Card c35 = new Card(Card.SuitType.Hearts, Card.DenominationType.Ten);
            Card c36 = new Card(Card.SuitType.Hearts, Card.DenominationType.Jack);
            Card c37 = new Card(Card.SuitType.Hearts, Card.DenominationType.Queen);
            Card c38 = new Card(Card.SuitType.Hearts, Card.DenominationType.King);
            Card c39 = new Card(Card.SuitType.Hearts, Card.DenominationType.Ace);

            Card c40 = new Card(Card.SuitType.Spades, Card.DenominationType.Two);
            Card c41 = new Card(Card.SuitType.Spades, Card.DenominationType.Three);
            Card c42 = new Card(Card.SuitType.Spades, Card.DenominationType.Four);
            Card c43 = new Card(Card.SuitType.Spades, Card.DenominationType.Five);
            Card c44 = new Card(Card.SuitType.Spades, Card.DenominationType.Six);
            Card c45 = new Card(Card.SuitType.Spades, Card.DenominationType.Seven);
            Card c46 = new Card(Card.SuitType.Spades, Card.DenominationType.Eight);
            Card c47 = new Card(Card.SuitType.Spades, Card.DenominationType.Nine);
            Card c48 = new Card(Card.SuitType.Spades, Card.DenominationType.Ten);
            Card c49 = new Card(Card.SuitType.Spades, Card.DenominationType.Jack);
            Card c50 = new Card(Card.SuitType.Spades, Card.DenominationType.Queen);
            Card c51 = new Card(Card.SuitType.Spades, Card.DenominationType.King);
            Card c52 = new Card(Card.SuitType.Spades, Card.DenominationType.Ace);

            Card[] allCards = { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, c21, c22, c23, c24, c25, c26, c27, c28, c29, c30, c31, c32, c33, c34, c35, c36, c37, c38, c39, c40, c41, c42, c43, c44, c45, c46, c47, c48, c49, c50, c51, c52 };
            for (int i = 0; i < allCards.Length; i++)
            {
                fullDeck.Add(allCards[i]);
            }
            return fullDeck;
        }

        

        /// <summary>
        /// Because Vinicio said so...
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
