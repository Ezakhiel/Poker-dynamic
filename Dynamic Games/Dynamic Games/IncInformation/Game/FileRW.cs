using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Games.IncInformation.GameLoop
{
    class FileRW
    {
        String path = "/location";
        public void writeToFile(int sorszam, int par11, int par12, int par13, int par1stilus,
                                        int par21, int par22, int par23, int par2stilus,
                                        int par31, int par32, int par33, int par3stilus,
                                        int fit1, int fit2, int fit3)
        {
            File.WriteAllText(path, "" + sorszam + par11 + par12 + par13 + par1stilus +
                                          par21 + par22 + par23 + par2stilus +
                                          par31 + par32 + par33 + par3stilus +
                                          fit1 + fit2 + fit3 + "\n");
        }

        public String readFromFile()
        {
            StreamReader sr = new StreamReader(path);

            String line;

            List<Parameters> list = new List<Parameters>();

            line = sr.ReadLine();

            String[] words;
            //Continue to read until you reach end of file
            while (line != null)
            {
                words = line.Split(' ');
                //write the lie to console window
                //hozza kell adni a listahoz
                //tarolni kell
                //list.Add((int)words[0], (int)words[1], (int)words[2]);
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();

            return line;

        }
    }
}
