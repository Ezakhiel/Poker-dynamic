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
        public void writeToFile(int sorszam, int par11, int par12, int par1stilus,
                                        int par21, int par22, int par2stilus,
                                        int par31, int par32, int par3stilus,
                                        int fit1, int fit2, int fit3)
        {
            File.WriteAllText(path, "" + sorszam + par11 + par12 + par1stilus +
                                          par21 + par22 + par2stilus +
                                          par31 + par32 + par3stilus +
                                          fit1 + fit2 + fit3 + "\n");
        }

        public List<Parameters> readFromFile()
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
                list.Add(new Parameters(Int32.Parse(words[0]), Int32.Parse(words[1]), Int32.Parse(words[2]), Int32.Parse(words[3]), Int32.Parse(words[4])));
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();

            return list;

        }
    }
}
