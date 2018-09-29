using System;
using System.Collections.Generic;

namespace DeckOfCards {
    public class Deck
    {
        public List<Card> cards = new List<Card>();
        public string[] suits = {"Hearts","Diamonds","Clubs","Spades"};
        public string[] stringVals = {"Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Jack","Queen","King","Ace"};
        public int[] values = {1,2,3,4,5,6,7,8,9,10,11,12,13};
        
        public Deck()
        {
            // foreach(string suit in suits)
            // {
            //     for(int i = 0; i < stringVals.Length; i ++)
            //     {
            //         Card single = new Card(suit,stringVals[i],i+2); 
            //         cards.Add(single);
            //     }
            // }
            this.Reset();
        }
        public Card Deal()
        {
            Card dealt = cards[cards.Count-1];
            cards.Remove(dealt);
            return dealt;
        }
        public void Reset()
        {
            cards.Clear();
            foreach(string suit in suits)
            {
                for(int i = 0; i < stringVals.Length; i ++)
                {
                    Card single = new Card(suit,stringVals[i],i+2); 
                    cards.Add(single);
                }
            }
        }

        public void Shuffle()
        {
            Random randy = new Random();
            for(int i = 51; i>=0; i--)
            {
                int rdx = randy.Next(0,51);
                Card shuff = this.cards[rdx];
                this.cards[rdx] = this.cards[i];
                this.cards[i] = shuff;
            }
        }
    }
}