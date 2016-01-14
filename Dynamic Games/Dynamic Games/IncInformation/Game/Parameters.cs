using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Games.IncInformation.GameLoop
{
    class Parameters
    {
        int szorszam; 
        int par11; 
        int par12; 
        int par1stilus;
        int fit1;  
        public Parameters(int szorszam, int par11, int par12, int par1stilus, int fit1)
        {
            this.szorszam = szorszam;
            this.par11 = par11;
            this.par12 = par12;
            this.par1stilus = par1stilus;
            this.fit1 = fit1;
        }
        public void generateParameters(int sorszam,int type, int randomFactorForWinChance, int randomFactorForMyBet)
        {
            Random rnd = new Random();
            randomFactorForMyBet = randomFactorForMyBet * rnd.Next(1, 100) / 100;
            //kell a tobbi prameter generalasa is
        }
    }
}
