using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni.Models;

namespace Uni
{
    public class ScholarManager
    {
       public List<Scholar> scholarsList = new List<Scholar>();

        //public void RemoveClassScholars(int classId)
        //{
        //    for (int i = 0; i < scholarsList.Count; i++)
        //    {
        //        for (int j = scholarsList[i].ClassScholar.Count - 1; j >= 0; j--)
        //        {
        //            if (scholarsList[i].ClassScholar[j] == classId)
        //            {
        //                scholarsList[i].ClassScholar.RemoveAt(j);
        //            }
        //        }
        //    }
        //}


        //public static void ScoresIni(ScholarManager scholarManager)
        //{
        //    Random random = new Random();

        //    for (int i = 0; i < scholarManager.scholarsList.Count; i++)
        //    {
        //        for (int j = 0; j < scholarManager.scholarsList[i].ClassScholar.Count; j++)
        //        {
        //            scholarManager.scholarsList[i].ClassScore.Add(random.Next(0, 20));

        //        }
        //    }
        //   ScoreAverage(scholarManager);
        //}





        //to do must remove delegate and back to normal execution 
        public delegate void WhichSection(int i, ScholarManager scholarManager1,string operation);

        public void PerformOperationOnAllSections(WhichSection whichSection,ScholarManager scholarManager1,string operation)
        {
            for (int i = 0; i < scholarsList.Count; i++)
            {
                whichSection(i, scholarManager1, operation);
            }
        }
    }
}
