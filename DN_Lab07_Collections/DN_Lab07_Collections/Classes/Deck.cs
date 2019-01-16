using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DN_Lab07_Collections.Classes;

namespace DN_Lab07_Collections.Classes
{
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
        public void Add(T card)
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
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
