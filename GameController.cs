using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSave
{
    class GameController
    {

        public void GiveCardsToGamers(List<Gamer> gamers, Deck deck)
        {
            int AmountCardsToChange = 4;
            foreach (var gamer in gamers)
            {
                for (int i = 0; i < AmountCardsToChange; i++)
                {
                    gamer.GamerCards.Add(deck.deck[0]);
                    deck.deck.RemoveAt(0);
                }
            }
        }

    }
}
