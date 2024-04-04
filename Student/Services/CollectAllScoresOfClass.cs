using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Services
{
    internal class CollectAllScoresOfClass : ScholarManager
    {
        public static void MinScoreClass(ScholarManager scholarManager1)
        {
            List<List<int>> listOfScoreForEachClass = new List<List<int>>();

            for (int i = 0; i < scholarManager1.scholarsList[i].ClassScholar.Count; i++)
            {
                listOfScoreForEachClass.Add(new List<int>());

                for (int j = 0; j < scholarManager1.scholarsList.Count; j++)
                {
                    listOfScoreForEachClass[i].Add(scholarManager1.scholarsList[j].ClassScore[i]);
                }
            }
        }
    }
}
