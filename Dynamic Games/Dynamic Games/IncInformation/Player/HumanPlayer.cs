using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dynamic_Games.IncInformation.Cards;

namespace Dynamic_Games.IncInformation.Player
{
    class HumanPlayer : Player
    {
        public HumanPlayer(int cash)
        {
            this.cash = cash;
        }

        public void setCards(Card c1, Card c2)
        {
            cards.Add(c1);
            cards.Add(c2);
        }

        public void setPos(Position p)
        {
            this.pos = p;
        }

        public void setBet(int b)
        {
            bet = b;
        }


    }
}
