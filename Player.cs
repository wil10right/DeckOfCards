using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        public string name;
        public List<Card> hand = new List<Card>();

        public Player(string name)
        {
            this.name = name;
        }

        public Card Draw(Deck InPlay)
        {
            Card InHand = InPlay.Deal();
            hand.Add(InHand);
            return InHand;
        }

        public Card Discard(int idx)
        {
            if(idx > this.hand.Count-1)
            {
                return null;
            }
            Card PlayHand = this.hand[idx];
            this.hand.RemoveAt(idx);
            return PlayHand;
        }
    }
}
