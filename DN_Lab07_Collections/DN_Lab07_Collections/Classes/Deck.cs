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
        //Creates inital memory with enough space to hold 10 cards
        T[] cardsInDeck = new T[10];
        //instantiates current index
        int currentIndex = 0;

        /// <summary>
        /// Add method within Deck Class that will take a card and add it to memory. Also has ability to resize memory in more cards are added than current memory allows.
        /// </summary>
        /// <param name="card"></param>
        public T Add(T card)
        {
            //Compares current index to the size of the cardsInDeck and will resize if cardInDeck if memory is full.
            if (currentIndex > cardsInDeck.Length -1)
            {
                Array.Resize(ref cardsInDeck, cardsInDeck.Length + 1);
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
        /// <returns>String</returns>
        public string Remove(T card)
        {
            string response = null;
            for (int i = 0; i < currentIndex; i++)
            {
                if (card.Equals(cardsInDeck[i]))
                {
                    response = cardsInDeck[i].ToString();
                    for (int j = 0; j < currentIndex - i - 1; j++)
                    {
                        cardsInDeck[j] = cardsInDeck[j + 1];
                    }
                    currentIndex = currentIndex - 1;
                    Array.Resize(ref cardsInDeck, cardsInDeck.Length - 1);
                }
            }
            if (response != null)
            {
                return response;
            }
            else
            {
                response = "Card Not In Deck";
                return response;
            }
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
        /// Because Vinicio said so...
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
