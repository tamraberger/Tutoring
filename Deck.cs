using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarClasses
{
    public class Deck
    {
      
        public string[] _suits = new string[] { "Spades", "Diamonds", "Hearts", "Clubs" };
        public Random rnd = new Random();
        List<Card> Cards = new List<Card>();
        int i = 0;
       


        public Deck()
        {
            int i = 0; //how we know we will get 52 cards
          

            foreach (var suit in _suits)
            {
                for (int value = 0; value < 13; value++)
                {
                    var card = new Card();
                    Cards.Add(card);
                    Cards[i].Value = value + 1;
                    Cards[i].Suit = suit;  
                    card = Cards[i];
                    i++;
                }
            }
                      

        }

        public Card Drawcard(string playerType)
        {

            Random rnd = new Random();
            Cards = Cards.OrderBy(item => rnd.Next()).ToList();
            i = 51 - i; //start backwards so you can use every card
            return Cards[i];

        }
    }
}
    

    

    

