using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Games.IncInformation.Player
{
    class AI
    {
        /*
         WinChance- t meg kell adni neki dinamikusnak jatekos szamtol fuggoen
         */


        public AI(Player AIPlayer,
                  int strategyType,
                  int bet,
                  int winChance,
                  int playerCount,
                  int mybet,
                  int randomFactorForWinChance,
                  int ramdomFactorForMyBet)
        {
            strategyForAI(AIPlayer, strategyType,
                          bet,
                          winChance,
                          playerCount,
                          mybet,
                          randomFactorForWinChance,
                          ramdomFactorForMyBet);

        }

        public void strategyForAI(Player AIPlayer,
                                    int strategyType,
                                    int bet,
                                    int winChance,
                                    int playerCount,
                                    int mybet,
                                    int randomFactorForWinChance,
                                    int randomFactorForMyBet)
        {
            switch (strategyType)
            {
                case 1: // Tight Passive
                    {
                        // if he give a good starting card maybe he playing but not every time because he scaring, if he dont have good cards he fold
                        strategyType = 0; // need to add a number for the strategy

                        if (winChance > 25)
                        {
                            if (bet > (AIPlayer.cash % 40))
                            {
                                if ((randomFactorForWinChance + randomFactorForMyBet) % 100 > 50)
                                {
                                    if (winChance > 40 && ((randomFactorForWinChance + randomFactorForMyBet) % 100 > 50))
                                    {
                                        if (winChance > 99)
                                        {
                                            AIPlayer.bet = AIPlayer.cash;
                                        }
                                        else
                                        {
                                            Random rnd = new Random();
                                            int dice = rnd.Next(bet, bet + AIPlayer.table.bigBlind);
                                            int seged = AIPlayer.cash % dice;
                                            AIPlayer.bet = seged;
                                        }
                                    }
                                    else
                                    {
                                        int segedbet = bet - mybet;
                                        AIPlayer.bet = segedbet;
                                    }
                                }
                                else
                                {
                                    AIPlayer.folded = true;
                                    AIPlayer.bet = 0;
                                }
                            }
                            else
                            {
                                AIPlayer.folded = true;
                                AIPlayer.bet = 0;
                            }
                        }
                        else
                        {
                            AIPlayer.folded = true;
                            AIPlayer.bet = 0;
                        }

                    } break;
                case 2: // Loose Passive
                    {
                        // only call dont raise he want to see the all cards
                        strategyType = 0; // need to add a number for the strategy

                        if (winChance > 5)
                        {
                            if (bet > (AIPlayer.cash % 70) || 60 > (randomFactorForWinChance + randomFactorForMyBet))
                            {
                                if (AIPlayer.table.statevalue == Game.State.River)
                                {
                                    if ((randomFactorForWinChance + randomFactorForMyBet) % 100 < 20)
                                    {
                                        if (bet < (AIPlayer.cash % 50) || 50 > (randomFactorForWinChance + randomFactorForMyBet))
                                        {
                                            if (winChance > 60 && ((randomFactorForWinChance + randomFactorForMyBet) % 100 > 50))
                                            {
                                                if (winChance > 85)
                                                {
                                                    AIPlayer.bet = AIPlayer.cash;
                                                }
                                                else
                                                {
                                                    Random rnd = new Random();
                                                    int dice = rnd.Next(bet, bet + AIPlayer.table.bigBlind);
                                                    int seged = AIPlayer.cash % dice;
                                                    AIPlayer.bet = seged;
                                                }
                                            }
                                            else
                                            {
                                                int segedbet = bet - mybet;
                                                AIPlayer.bet = segedbet;
                                            }
                                        }
                                        else
                                        {
                                            AIPlayer.folded = true;
                                            AIPlayer.bet = 0;
                                        }
                                    }
                                    else
                                    {
                                        AIPlayer.folded = true;
                                        AIPlayer.bet = 0;
                                    }
                                }
                                else
                                {
                                    int segedbet = bet - mybet;
                                    AIPlayer.bet = segedbet;
                                }
                            }
                            else
                            {
                                AIPlayer.folded = true;
                                AIPlayer.bet = 0;
                            }

                        }
                        else
                        {
                            AIPlayer.folded = true;
                            AIPlayer.bet = 0;
                        }

                    } break;
                case 3: // Tight Aggressive (TAG)
                    {
                        // need a good winChance to go but when he got do everyting 
                        strategyType = 0; // need to add a number for the strategy

                        if (winChance > 20)
                        {
                            if ((randomFactorForWinChance + randomFactorForMyBet) % 100 > 10)
                            {
                                if ((randomFactorForWinChance * winChance + randomFactorForMyBet * mybet * bet) % 100 > 50)
                                {
                                    if (winChance > 25 && ((randomFactorForWinChance + randomFactorForMyBet) % 100 > 15))
                                    {
                                        Random rnd2 = new Random();
                                        int dice2 = rnd2.Next(1, winChance);
                                        int seged2 = AIPlayer.cash % dice2;
                                        AIPlayer.bet = seged2;
                                    }
                                    else
                                    {
                                        int segedbet = bet - mybet;
                                        AIPlayer.bet = segedbet;
                                    }
                                }
                            }
                            else
                            {
                                if ((randomFactorForWinChance + randomFactorForMyBet) % 100 < 5)
                                {
                                    if ((randomFactorForWinChance + randomFactorForMyBet) % 100 < 1)
                                    {
                                        Random rnd = new Random();
                                        int dice = rnd.Next(bet, AIPlayer.cash);
                                        int seged = AIPlayer.cash % dice;
                                        AIPlayer.bet = seged;
                                    }
                                    else
                                    {
                                        int segedbet = bet - mybet;
                                        AIPlayer.bet = segedbet;
                                    }
                                }
                                else
                                {
                                    AIPlayer.folded = true;
                                    AIPlayer.bet = 0;
                                }
                            }
                        }
                        else
                        {
                            AIPlayer.folded = true;
                            AIPlayer.bet = 0;
                        }

                    } break;
                case 4: // Loose Aggressive (LAG)
                    {
                        // need to raise and be the last in the game dont mather if he loose or win
                        strategyType = 0; // need to add a number for the strategy

                        if (winChance > 5)
                        {
                            if ((randomFactorForWinChance + randomFactorForMyBet) % 100 > 10)
                            {
                                if (bet < (AIPlayer.cash % 70) && winChance > 20)
                                {
                                    if ((randomFactorForWinChance * winChance + randomFactorForMyBet * mybet * bet) % 100 > 50)
                                    {
                                        Random rnd = new Random();
                                        int dice = rnd.Next(1, winChance);
                                        if (dice > 10 && (randomFactorForWinChance + randomFactorForMyBet) % 100 > 10)
                                        {
                                            if (winChance > 25 && ((randomFactorForWinChance + randomFactorForMyBet) % 100 > 15))
                                            {
                                                Random rnd2 = new Random();
                                                int dice2 = rnd2.Next(1, winChance);
                                                int seged2 = AIPlayer.cash % dice2;
                                                AIPlayer.bet = seged2;
                                            }
                                            else
                                            {
                                                int segedbet = bet - mybet;
                                                AIPlayer.bet = segedbet;
                                            }
                                        }
                                        else
                                        {
                                            AIPlayer.folded = true;
                                            AIPlayer.bet = 0;
                                        }

                                    }
                                    else
                                    {
                                        AIPlayer.folded = true;
                                        AIPlayer.bet = 0;
                                    }
                                }
                                else
                                {
                                    //bloff
                                    if ((randomFactorForWinChance + randomFactorForMyBet) % 100 < 8)
                                    {
                                        if ((randomFactorForWinChance + randomFactorForMyBet) % 100 < 2)
                                        {
                                            Random rnd = new Random();
                                            int dice = rnd.Next(bet, AIPlayer.cash);
                                            int seged = AIPlayer.cash % dice;
                                            AIPlayer.bet = seged;
                                        }
                                        else
                                        {
                                            int segedbet = bet - mybet;
                                            AIPlayer.bet = segedbet;
                                        }
                                    }
                                    else
                                    {
                                        AIPlayer.folded = true;
                                        AIPlayer.bet = 0;
                                    }
                                }
                            }
                            else
                            {
                                AIPlayer.folded = true;
                                AIPlayer.bet = 0;
                            }
                        }
                        else
                        {
                            AIPlayer.folded = true;
                            AIPlayer.bet = 0;
                        }

                    } break;
                default:
                    break;
            }
        }
    }
}
