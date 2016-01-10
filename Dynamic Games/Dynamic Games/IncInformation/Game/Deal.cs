using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

using MyCard = Dynamic_Games.IncInformation.Cards;
using Dynamic_Games.IncInformation.Player;

using HoldemHand;

namespace Dynamic_Games.IncInformation.Game
{
    public class Deal
    {
        public List<Player.Player> activePlayers = new List<Player.Player>(8);
        public List<int> markedForRemove = new List<int>(7);
        public Table table;
        public int dealCall;
        private TurnThread tt;

        public Deal(Table t)
        {
            this.table = t;
        }

        public void play()
        {
            table.resetTable();
            table.statevalue = State.Preflop;
            activePlayers = new List<Player.Player>(8);
            foreach (Player.Player p in table.players)
            {
                activePlayers.Add(p);
            }
            //table.formLockEvent.Set();
            this.table.controls.Invoke((Action)delegate
            {
                table.controls.vizualize();
            });
            setSmallBig();
            tt = new TurnThread(this);
            //preflop
            tt.doTurn(table.bigBlind, table.bigBLoc + 1);
            table.nextState();
            this.table.controls.Invoke((Action)delegate
            {
                table.controls.vizualize();
            });
            // MessageBox.Show("Kor vege!\n " + table.getHandValue(0) + "\n" + table.getHandValue(1));
            //flop
            nextTurn();
            //turn
            nextTurn();
            //river
            nextTurn();
        }

        private void nextTurn()
        {
            tt.doTurn(0, table.bigBLoc + 1);
            if (table.statevalue != State.River)
                table.nextState();
            this.table.controls.Invoke((Action)delegate
            {
                table.controls.vizualize();
            });
        }

        private void setSmallBig()
        {
            table.players[table.bigBLoc].bet = table.bigBlind;
            table.players[table.smallBLoc].bet = table.smallBlind;
        }

        public void pay()
        {
            int maxid = 0;
            uint maxvalue = 0;
            uint tmpval;
            foreach (Player.Player p in table.players)
            {
                //determine winner transfer players.bet to winner 
                if (!p.folded)
                {
                    tmpval = table.getHandValue(p.id);

                    if (tmpval > maxvalue)
                    {
                        maxvalue = tmpval;
                        maxid = p.id;
                    }
                }
            }
            payPlayer(maxid);
            if (wasAllIn())
                pay();

        }

        private bool wasAllIn()
        {
            bool was = false;
            foreach (Player.Player p in table.players)
            {
                if (p.bet != 0)
                    was = true;
            }
            return was;
        }

        private void payPlayer(int id)
        {
            table.players[id].cash += table.players[id].bet;
            
            table.players[id].folded = true;
            int win = 0;
            foreach (Player.Player p in table.players)
            {
                if (p.id != id)
                {
                    if (p.bet == table.players[id].bet)
                        win = p.bet;
                    else
                        win = p.bet % table.players[id].bet;
                    table.players[id].cash += win;
                    p.bet = -win;
                    if (p.cash == 0)
                        markedForRemove.Add(p.id);
                }
            }
            table.players[id].bet = -table.players[id].bet; 
        }
    }
}
