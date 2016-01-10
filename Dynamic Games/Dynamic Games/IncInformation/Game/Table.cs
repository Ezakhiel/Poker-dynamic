using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandEvaluator;
using System.Threading;
using System.Windows.Forms;

using MyCard = Dynamic_Games.IncInformation.Cards;
using Player = Dynamic_Games.IncInformation.Player;
using System.Drawing;
using System.ComponentModel;

using HandEvaluator;
using HoldemHand;

namespace Dynamic_Games.IncInformation.Game
{
    public enum State
    {
        Preflop, Flop, Turn, River
    };

    public class Table : INotifyPropertyChanged
    {
        public IncInformationForm controls;
        public List<Player.Player> players = new List<Player.Player>(8);
        public List<uint> handvalues = new List<uint>(8);
        public ManualResetEvent mre = new ManualResetEvent(false);
        public ManualResetEvent formLockEvent = new ManualResetEvent(false);
        private int playerCount;
        public List<MyCard.Card> flop = new List<MyCard.Card>(3);
        private MyCard.Card flopH1;
        private MyCard.Card flopH2;
        private MyCard.Card flopH3; // didnt use list because individual elements cant be bassed as ref
        public MyCard.Card river;
        private MyCard.Card riverHidden;
        public MyCard.Card turn;
        private MyCard.Card turnHidden;
        private MyCard.Deck deck;
        private State GameState;
        public Deal deal;
        public int bigBlind;
        public int bigBLoc;
        public int smallBlind;
        public int smallBLoc;
        public bool folded;
        public Thread gameThread;

        // Event handler for gamestate change
        public event PropertyChangedEventHandler StateChanged;
        public State statevalue
        {
            get
            {
                return GameState;
            }

            set
            {
                GameState = value;
                OnStateChanged();
            }
        }
        public Table(MyCard.Deck d, int playerCount, IncInformationForm incForm)
        {
            folded = false;
            deal = new Deal(this);
            this.controls = incForm;
            riverHidden = new MyCard.Card("unknown", Properties.Resources.back);
            turnHidden = new MyCard.Card("unknown", Properties.Resources.back);
            flopH1 = new MyCard.Card("unknown", Properties.Resources.back);
            flopH2 = new MyCard.Card("unknown", Properties.Resources.back);
            flopH3 = new MyCard.Card("unknown", Properties.Resources.back);
            this.deck = d;
            this.bigBlind = 50;
            this.smallBlind = 25;
            this.playerCount = playerCount;

            for (int i = 0; i < playerCount; i++)
            {
                players.Add(new Player.HumanPlayer(1000, i, this));
                players.ElementAt(i).setCards(deck.getCard(), deck.getCard());
                players.ElementAt(i).setPos(Player.Position.None);
            }
            players[0].setPos(Player.Position.SmallBlind);
            smallBLoc = 0;
            controls.playerVis[0].typeLBL.Text += "SB";
            players[1].setPos(Player.Position.BigBlind);
            bigBLoc = 1;
            controls.playerVis[1].typeLBL.Text += "BB";
            //start dealing
            //playTable();
            gameThread = new Thread(new ThreadStart(playTable));
            gameThread.Name = "GameTH";
            gameThread.IsBackground = true;
            gameThread.Start();
            //formLockEvent.WaitOne();
        }

        private void swapCard(ref MyCard.Card c1, ref MyCard.Card c2)
        {
            MyCard.Card temp = c1;
            c1 = c2;
            c2 = temp;
        }

        // Event handler
        protected virtual void OnStateChanged()
        {
            switch (GameState)
            {
                case State.Preflop:
                    MyCard.Card tmpcard;
                    swapCard(ref riverHidden, ref river);

                    swapCard(ref turnHidden, ref turn);
                    tmpcard = flop[0];
                    swapCard(ref flopH1, ref tmpcard);
                    flop[0] = tmpcard;
                    tmpcard = flop[1];
                    swapCard(ref flopH2, ref tmpcard);
                    flop[1] = tmpcard;
                    tmpcard = flop[2];
                    swapCard(ref flopH3, ref tmpcard);
                    flop[2] = tmpcard;
                    break;
                case State.Flop:
                    tmpcard = flop[0];
                    swapCard(ref flopH1, ref tmpcard);
                    flop[0] = tmpcard;
                    tmpcard = flop[1];
                    swapCard(ref flopH2, ref tmpcard);
                    flop[1] = tmpcard;
                    tmpcard = flop[2];
                    swapCard(ref flopH3, ref tmpcard);
                    flop[2] = tmpcard;
                    break;
                case State.River:
                    swapCard(ref riverHidden, ref river);
                    break;
                case State.Turn:
                    swapCard(ref turnHidden, ref turn);
                    break;
            }
            // raiseState();

        }
        // Evenethander end

        private void movePos()
        {
            int tmpid;
            foreach (Player.Player p in players)
            {

                if ((p.pos == Player.Position.SmallBlind))
                {
                    p.setPos(Player.Position.None);
                    tmpid = p.id + 1;
                    controls.playerVis[p.id].typeLBL.Invoke((Action)delegate
                    {
                        controls.playerVis[p.id].typeLBL.Text = "Player " + tmpid + ":";
                    });

                    tmpid = nextActiveId(p.id);
                    smallBLoc = tmpid;
                    players[tmpid].setPos(Player.Position.SmallBlind);
                    tmpid++;
                    controls.playerVis[p.id].typeLBL.Invoke((Action)delegate
                    {
                        controls.playerVis[p.id].typeLBL.Text = "Player " + tmpid + ":SB";
                    });

                    tmpid--;
                    tmpid = nextActiveId(tmpid);
                    players[tmpid].setPos(Player.Position.BigBlind);
                    bigBLoc = tmpid;
                    tmpid++;
                    controls.playerVis[p.id].typeLBL.Invoke((Action)delegate
                    {
                        controls.playerVis[p.id].typeLBL.Text = "Player " + tmpid + ":BB";
                    });
                    break;
                }

            }
        }

        private int nextActiveId(int startPoss)
        {
            while (true)
            {
                startPoss++;
                if (startPoss == players.Count)
                    startPoss = 0;
                if (players[startPoss].cash >= bigBlind)
                {
                    return startPoss;
                }
            }
        }

        public void resetTable()
        {
            deck.initDeck();
            riverHidden = new MyCard.Card("unknown", Properties.Resources.back);
            turnHidden = new MyCard.Card("unknown", Properties.Resources.back);
            flopH1 = new MyCard.Card("unknown", Properties.Resources.back);
            flopH2 = new MyCard.Card("unknown", Properties.Resources.back);
            flopH3 = new MyCard.Card("unknown", Properties.Resources.back);
            flop = new List<MyCard.Card>(3);
            foreach (Player.Player p in players)
            {
                if (p.cash != 0)
                {
                    p.setCards(deck.getCard(), deck.getCard());

                    p.folded = false;
                    p.playerBet = 0;
                }
                else
                {
                    p.folded = true;
                }
            }

            // movePos();
            flop.Add(deck.getCard());
            flop.Add(deck.getCard());
            flop.Add(deck.getCard());
            river = deck.getCard();
            turn = deck.getCard();

        }

        public void nextState()
        {
            this.statevalue = getNextState(statevalue);
        }
        private State getNextState(State s)
        {
            Boolean ok = false;
            foreach (State next in Enum.GetValues(typeof(State)))
            {
                if (ok)
                    return next;
                if (next == s)
                    ok = true;
            }
            return State.Preflop;
        }

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        public int activePlayerCount()
        {
            int i = 0;
            foreach (Player.Player p in players)
            {
                if (p.cash >= bigBlind)
                    i++;
            }
            return i;
        }

        public void playTable()
        {
            foreach (Player.Player p in players)
            {
                p.bet = 0;
            }
            while (activePlayerCount() > 1)
            {
                deal.play();
                //  MessageBox.Show("Kor vege!\n " + getHandValue(0) +"\n"+ getHandValue(1));
                deal.pay();
                removePlayers();
                nextState();
                movePos();
                controls.vizualize();
                // deal.redeal();

                //deal = new Deal(this);

            }
            int tmpid = nextActiveId(0) + 1;
            MessageBox.Show("Winner is Player " + tmpid);
            controls.Invoke((Action)delegate
                {
                   controls.newTable();
                });

        }

        private void removePlayers()
        {
            if (deal.markedForRemove.Count > 0)
                foreach (int i in deal.markedForRemove)
                {
                    players[i].cards[0].CardImage = Properties.Resources.black;
                    players[i].cards[1].CardImage = Properties.Resources.black;
                    players[i].folded = true;
                }
        }

        public bool isValidBet(int aBet, int playernum)
        {
            if (aBet < 0)
                return false;
            if ((aBet + players[playernum].bet < deal.dealCall) &&
                (aBet != players[playernum].cash))
                return false;

            return true;
        }

        public uint getHandValue(int playerid)
        {
            Hand retHand = new Hand();
            string pocket = cardToString(players[playerid].cards[0]) + " " + cardToString(players[playerid].cards[1]);
            string board = toBoard();
            try
            {
                retHand = new Hand(pocket, board);
            }
            catch (Exception e)
            {
                //NOTHING!!!!
            }
            MessageBox.Show(playerid + " playerhand: " + retHand.Description);
            return retHand.HandValue;
        }
        private string toBoard()
        {
            string board = "error";
            switch (statevalue)
            {
                case State.Preflop:
                    board = " ";
                    break;

                case State.Flop:
                    board = cardToString(flop[0]) + " " +
                        cardToString(flop[1]) + " " +
                        cardToString(flop[2]);
                    break;

                case State.Turn:
                    board = cardToString(flop[0]) + " " +
                        cardToString(flop[1]) + " " +
                        cardToString(flop[2]) + " " +
                        cardToString(turn);
                    break;

                case State.River:
                    board = cardToString(flop[0]) + " " +
                        cardToString(flop[1]) + " " +
                        cardToString(flop[2]) + " " +
                        cardToString(turn) + " " +
                        cardToString(river);
                    break;
            }


            return board;
        }

        private string cardToString(MyCard.Card card)
        {
            string cardname = "error";
            if (card.CardName[1] == '0')
            {
                if (card.CardName[2] == '1')
                    cardname = "a" + card.CardName[0].ToString();
                else
                    cardname = card.CardName[2].ToString() + card.CardName[0].ToString();
            }
            else
            {
                if (card.CardName[2] == '0')
                    cardname = "10" + card.CardName[0].ToString();
                if (card.CardName[2] == '1')
                    cardname = "j" + card.CardName[0].ToString();
                if (card.CardName[2] == '2')
                    cardname = "q" + card.CardName[0].ToString();
                if (card.CardName[2] == '3')
                    cardname = "k" + card.CardName[0].ToString();
            }

            return cardname;
        }
    }
}
