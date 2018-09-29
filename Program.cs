using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck Bicycle = new Deck();
            Player will = new Player("William");

            foreach(object card in Bicycle.cards)
            {
                System.Console.WriteLine(card);
            }

            Bicycle.Shuffle();

            // object HitMe = Bicycle.Deal();
            
            will.Draw(Bicycle);
            will.Draw(Bicycle);
            will.Draw(Bicycle);
            will.Draw(Bicycle);
            will.Draw(Bicycle);

            will.Discard(3);

            System.Console.WriteLine(will.hand);

        }
    }
}
