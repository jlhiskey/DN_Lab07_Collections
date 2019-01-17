using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Lab07_Collections.Classes
{
    /// <summary>
    /// Creates a new card using enums SuitType and DenominationType as inputs.
    /// </summary>
    public class Card
    {
        public enum SuitType
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }

        public enum DenominationType
        {
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }

        public SuitType Suit { get; set; }
        public DenominationType Denomination { get; set; }

        public Card(SuitType suit, DenominationType denomination)
        {
            Suit = suit;
            Denomination = denomination;
        }
    }

    
}
