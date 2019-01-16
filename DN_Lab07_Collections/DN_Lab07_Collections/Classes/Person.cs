using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Lab07_Collections.Classes
{
    public class Person
    {
        public string Name { get; set; }
        public bool Dealer { get; set; }
        public Deck<Card> Hand { get; set; }
    }
}
