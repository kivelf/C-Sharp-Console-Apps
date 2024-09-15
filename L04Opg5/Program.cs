using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04Opg5
{
    internal class Program
    {
        static public bool FilterBySpades(Card card) 
        { 
            return card.Suit == Suit.Spades;
        }

        static void Main(string[] args)
        {
            CardGame game = new CardGame();
            game.AddCard(Suit.Hearts, CardNumber.Jack);
            game.AddCard(Suit.Hearts, CardNumber.Two);
            game.AddCard(Suit.Hearts, CardNumber.Nine);
            game.AddCard(Suit.Spades, CardNumber.Five);
            game.AddCard(Suit.Spades, CardNumber.Ace);
            game.AddCard(Suit.Spades, CardNumber.Queen);
            game.AddCard(Suit.Clubs, CardNumber.Six);
            game.AddCard(Suit.Clubs, CardNumber.Three);
            game.AddCard(Suit.Clubs, CardNumber.King);
            game.AddCard(Suit.Diamonds, CardNumber.Four);
            game.AddCard(Suit.Diamonds, CardNumber.Seven);
            game.AddCard(Suit.Diamonds, CardNumber.Ten);

            List<Card> cards = game.filterCardGame(FilterBySpades);
            foreach (Card card in cards) 
            {
                Console.WriteLine(card);
            }
            Console.WriteLine("------------------------------");

            // using lambda expressions
            cards = game.filterCardGame(card => card.Number > CardNumber.Ten || card.Number == CardNumber.Ace);
            foreach (Card card in cards) 
            { 
                Console.WriteLine(card);
            }
            Console.ReadLine();
        }
    }
}
