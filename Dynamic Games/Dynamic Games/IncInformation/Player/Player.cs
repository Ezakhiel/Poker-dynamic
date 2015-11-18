using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Games.IncInformation.Player
{
    enum Position
    {
        SmallBlind,
        BigBlind,
        None,
    };

    interface Player
    {
        public int Cash;
        public List<Card> Cards;
        public Position Pos;
        public int bet;

    }
}
