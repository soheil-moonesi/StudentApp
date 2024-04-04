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





        public void AddClassToScholar(int classId)
        {
            for (int i = 0; i < scholarsList.Count; i++)
            {
                scholarsList[i].ClassScholar.Add(classId);
            }
        }

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


        public int HandleScholarId()
        {
            int i = -1;
            Console.WriteLine("enter scholar id");
            while (i == -1)
            {
                string inputScholarId = Console.ReadLine();

                int scholarId = CheckScolarIdConsole(inputScholarId);

                if (scholarId != 0)
                {
                    i = GetScholarIndexAndValidation(scholarId);
                }

            }
            return i;
        }

   //todo:delete this section
        public int CheckScolarIdConsole(string scholarIdInput)
        {
            int scholarId = 0;
            bool successConvert = false;

            successConvert = int.TryParse(scholarIdInput, out scholarId);

            if (successConvert == false)
            {
                Console.WriteLine("Invalid input: type a number.");
            }


            return scholarId;
        }
        // to do delete this
        public int GetScholarIndexAndValidation(int scholarId)
        {

            for (int i = 0; i < scholarsList.Count; i++)
            {
                if (scholarsList[i].GetScholarId() == scholarId)
                {

                    return i;
                }

            }
            Console.WriteLine("Scholar not exist, enter another ID.");
            return -1;
        }

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


        public static void Display(ScholarManager scholarManager1, string bySomething)
        {
            for (int i = 0; i < scholarManager1.scholarsList.Count; i++)
            {
                if (bySomething == "byName")
                {
                    scholarManager1.scholarsList.Sort(new ScholarComparerName());
                }
                else if (bySomething == "byScore")
                {
                    scholarManager1.scholarsList.Sort(new ScholarComparerRate());
                }
                Console.WriteLine($"{scholarManager1.scholarsList[i].Name} \n {scholarManager1.scholarsList[i].LastName} \n {scholarManager1.scholarsList[i].ScholarId}  \n {scholarManager1.scholarsList[i].Average}");
            }
        }

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
            ScoreAverageClassAndOutMin(scholarManager1, listOfScoreForEachClass);
        }

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
            Console.WriteLine($"Min score in class {scholarManager1.scholarsList[saveIndex].ClassScholar[saveIndex]} is {MinTemp}");
        }
        public void ChangeScholar(ScholarManager scholarManager)
        {
            int i = HandleScholarId();

            Console.WriteLine("wanna change name type something otherwise just press enter");
            string tempName = Console.ReadLine();
            if (tempName != "")
            {
                scholarManager.scholarsList[i].Name = tempName;
            }
            Console.WriteLine("wanna change lastname type something otherwise just press esnter");

            string templastname = Console.ReadLine();
            if (templastname != "")
            {
                scholarManager.scholarsList[i].Name = templastname;
            }

        }
        public int GetAndConvertScholarId(string prompt)
        {
            Console.WriteLine(prompt);
            int scholarId = 0;
            int result = -1;
            while (result == -1)
            {
                bool successConvert = int.TryParse(Console.ReadLine(), out scholarId);

                if (successConvert == false)
                {
                    Console.WriteLine("Invalid input: type a number.");
                }
                else
                {
                    result = GetScholarIndexAndValidation(scholarId);
                }
            }

            return scholarId;
        }



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
