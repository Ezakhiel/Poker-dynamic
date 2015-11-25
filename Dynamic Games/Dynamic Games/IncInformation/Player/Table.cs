using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dynamic_Games.IncInformation.Cards;

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
        public List<Player> players;
        private int playerCount;
        private int bigAt;
        public List<Card> river;
        public Card flop;
        public Card turn;
        private Deck deck;
        public int AllBet;
        public State GameState;

        public Table(Deck deck, int playerCount)
        {
            this.deck = deck;
            this.playerCount = playerCount;
            for (int i = 0; i < playerCount; i++)
            {
                players.Add(new HumanPlayer(1000));
                players.ElementAt(i).setCards(deck.getCard(), deck.getCard());
                players.ElementAt(i).setPos(Position.None);
                players.ElementAt(i).setBet(0);
            }
            initTable();
        }

        private void movePos()
        {
            int i = 0;
            foreach (Player p in players)
            {
                if (p.pos == Position.BigBlind)
                {
                    p.setPos(Position.SmallBlind);
                    break;
                }
                i++;
            }
            if (i == players.Count)
                players.ElementAt(0).setPos(Position.BigBlind);
            else
                players.ElementAt(i + 1).setPos(Position.BigBlind);
        }

        public void initTable()
        {
            foreach(Player p in players)
            {
                p.setCards(deck.getCard(), deck.getCard());  
            }
            movePos();
            river.Add(deck.getCard());
            river.Add(deck.getCard());
            river.Add(deck.getCard());
            flop = deck.getCard();
            turn = deck.getCard();
        }

    }
}
