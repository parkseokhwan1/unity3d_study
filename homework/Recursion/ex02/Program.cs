using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    class Program
    {
        // 조건
        // 각 요소 값들은 정렬되어 있어야 한다.
        // 각 요소 값들은 모두 달라야 한다. 

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
            int nResult = BinSearch(nArr, 0, nArr.Length, 11);

            for (int i=0; i<nArr.Length; i++)
            {
                Console.Write(nArr[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("11은 " + nResult + "번째 배열 요소에 있습니다.");
        }
    }
}
