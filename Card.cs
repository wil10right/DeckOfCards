using System;

namespace DeckOfCards
{
    public class Card
    {
        public string StringVal;
        public string Suit;
        public int Value;

        public Card(string suit, string stringVal, int val){
            this.Suit = suit;
            this.StringVal = stringVal;
            this.Value = val;
        }

    }
}