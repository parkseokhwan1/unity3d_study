using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    class Program
    {
        static int BinSearch(int[] nArr, int nBegin, int nEnd, int nTarget)
        {
            int nMid = 0;
            nMid = (nBegin + nEnd) / 2;

            if(nArr[nMid] == nTarget)
            {
                return nMid;
            }
            else if(nTarget < nArr[nMid])
            {
                return BinSearch(nArr, nBegin, nMid - 1, nTarget);
            }
            else
            {
                return BinSearch(nArr, nMid + 1, nEnd, nTarget);
            }
        }

        static void Main(string[] args)
        {
            int[] nArr = { 1, 3, 5, 7, 9, 11, 13 };
            int nResult;

            for (int i=0; i<nArr.Length; i++)
            {
                Console.WriteLine("");
            }
        }
    }
}
