using System;
using Xunit;
using DN_Lab07_Collections.Classes;

namespace Lab07TestSuite
{
    public class UnitTest1
    {
        [Fact]
        public void TestingAddingCardToDeck()
        {
            Deck<Card> testDeck = new Deck<Card>("Test Deck");
            int beforeAdd = testDeck.Count();
            Card test = new Card(Card.SuitType.Clubs, Card.DenominationType.Two);
            testDeck.Add(test);
            int afterAdd = testDeck.Count();

            Assert.NotEqual(afterAdd, beforeAdd);
        }

        [Fact]
        public void TestingGettersSettersInCardClass()
        {
            Card test = new Card(Card.SuitType.Clubs, Card.DenominationType.Two);

            test.Denomination = Card.DenominationType.Ace;

            Assert.Equal(Card.DenominationType.Ace, test.Denomination);
        }

        [Fact]
        public void RemoveCardFromDeck()
        {
            Deck<Card> testDeck = new Deck<Card>("Test Deck");
            Card test = new Card(Card.SuitType.Clubs, Card.DenominationType.Two);
            testDeck.Add(test);

            Assert.True(testDeck.Remove(test));

        }

        [Fact]
        public void RemoveCardFromDeckThatDoesntExistInDeck()
        {
            Deck<Card> testDeck = new Deck<Card>("Test Deck");
            Card test = new Card(Card.SuitType.Clubs, Card.DenominationType.Two);
            

            Assert.False(testDeck.Remove(test));
        }
    }
}
