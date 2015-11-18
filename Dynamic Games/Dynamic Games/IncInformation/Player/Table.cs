using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Games.IncInformation.Player
{
    enum State
    {
        PreFlop,
        Flop,
        River,
        turn,
    };
    class Table
    {
        public List<Card> river;
        public Card flop;
        public Card turn;
        public int AllBet;
        public State GameState;
    }
}
