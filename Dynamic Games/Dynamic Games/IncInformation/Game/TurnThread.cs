using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using Dynamic_Games.IncInformation.Player;

namespace Dynamic_Games.IncInformation.Game
{

    class TurnThread
    {
        public Deal deal;
        int foldcount;

        public TurnThread(Deal d)
        {
            this.deal = d;
            foldcount = 0;
        }

        public void doTurn(int turnCall, int bigBlindNext)
        {
            int actualPlayer = bigBlindNext;
            int raisedPlayer = actualPlayer;
            deal.table.controls.Invoke((Action)delegate
            {
                deal.table.controls.playerVis[raisedPlayer].betLBL.ForeColor = Color.Green;
            });
            do
            {
                deal.table.controls.Invoke((Action)delegate
                {
                    deal.table.controls.playerVis[actualPlayer].betLBL.BackColor = Color.Yellow;
                });

                //if not inactive
                if (!deal.activePlayers[actualPlayer].folded)
                {
                    // player sets fields
                    deal.activePlayers[actualPlayer].decision();

                    if (!deal.activePlayers[actualPlayer].folded)
                    {
                        if (deal.activePlayers[actualPlayer].bet < turnCall)
                        {
                            deal.activePlayers[actualPlayer].folded = true;
                        }
                        if (deal.activePlayers[actualPlayer].bet > turnCall)
                        {
                            turnCall = deal.activePlayers[actualPlayer].bet;
                            deal.table.controls.Invoke((Action)delegate
                            {
                                deal.table.controls.playerVis[raisedPlayer].betLBL.ForeColor = Color.Black;
                            });
                            raisedPlayer = actualPlayer;
                            deal.table.controls.Invoke((Action)delegate
                            {
                                deal.table.controls.playerVis[raisedPlayer].betLBL.ForeColor = Color.Green;
                            });
                        }
                    }
                    else
                        foldcount++;
                }
                deal.table.controls.Invoke((Action)delegate
                {
                    deal.table.controls.playerVis[actualPlayer].betLBL.BackColor = Color.White;
                });
                actualPlayer++;
                if (deal.activePlayers.Count <= actualPlayer)
                    actualPlayer = 0;
            }
            while ((actualPlayer != raisedPlayer) && (deal.activePlayers.Count - 1 > foldcount));
            deal.table.controls.Invoke((Action)delegate
            {
                deal.table.controls.playerVis[raisedPlayer].betLBL.ForeColor = Color.Black;
            });

        }

    }
}
