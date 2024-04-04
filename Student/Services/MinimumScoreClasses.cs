using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Services
{
    internal class MinimumScoreClasses
    {
        public static void ScoreAverageClassAndOutMin(ScholarManager scholarManager1, List<List<int>> listOfScoreForEachClass)
        {
            List<int> temp = new List<int>();
            int MinTemp = 999;
            int saveIndex = 0;
            for (int i = 0; i < listOfScoreForEachClass.Count; i++)
            {
                temp.Add(0);

                for (int j = 0; j < listOfScoreForEachClass[i].Count; j++)
                {
                    temp[i] += listOfScoreForEachClass[i][j];
                }
                temp[i] /= listOfScoreForEachClass[i].Count;

                if (temp[i] < MinTemp)
                {
                    MinTemp = temp[i];
                    saveIndex = i;
                }
            }
        }
    }
}
