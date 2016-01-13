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
        int par13;
        int par1stilus;
        int par21;
        int par22;
        int par23;
        int par2stilus;
        int par31; 
        int par32;
        int par33;
        int par3stilus;
        int fit1; 
        int fit2; 
        int fit3;
        public Parameters(int szorszam, int par11, int par12, int par13, int par1stilus,
                                        int par21, int par22, int par23, int par2stilus,
                                        int par31, int par32, int par33, int par3stilus,
                                        int fit1, int fit2, int fit3)
        {
            this.szorszam = szorszam;
            this.par11 = par11;
            this.par12 = par12;
            this.par13 = par13;
            this.par1stilus = par1stilus;
            this.par21 = par21;
            this.par22 = par22;
            this.par23 = par23;
            this.par2stilus = par2stilus;
            this.par31 = par31;
            this.par32 = par32;
            this.par33 = par33;
            this.par3stilus = par3stilus;
            this.fit1 = fit1;
            this.fit2 = fit2;
            this.fit3 = fit3;
        }
    }
}
