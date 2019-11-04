using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_1
{
    class Lotto
    {
        public ArrayList generateLines(int noOfLines)
        {
            int noOfLinesFilled = 0;
            int randNum;
            ArrayList lottoLine = new ArrayList();
            ArrayList allLottoLines = new ArrayList();
            Random rand = new Random();
            do
            {
                int lineFilled = 0;
                do
                {
                    randNum = rand.Next(1, 50);
                    if (!lottoLine.Contains(rand))
                    {
                        lottoLine.Add(randNum);
                        lineFilled++;
                    }
                } while (lineFilled == 6);
                lottoLine.Sort();
                allLottoLines.Add(lottoLine);
                lottoLine.Clear();
                noOfLinesFilled++;
            } while (noOfLinesFilled == noOfLines);
            
            return allLottoLines;
        }
    }
}
