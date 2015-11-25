using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dynamic_Games.IncInformation.Cards;

namespace Dynamic_Games.IncInformation.Player
{
    enum Position
    {
        SmallBlind = 1,
        BigBlind = 2,
        None = 0,
    };

    public abstract class Player
    {
        public int cash;
        public List<Card> cards;
        public Position pos;
        public int bet;

        public void setBet(int b);
        public void setPos(Position p);
        public void setCards(Card c1, Card c2);
    }
}
