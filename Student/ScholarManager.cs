using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni
{
    internal class ScholarManager
    {
        List<Scholar> scholarsList = new List<Scholar>();
        public void addScholar(Scholar scholar)
        {
            scholarsList.Add(scholar);
        }
        public void removeScholar(int scholarId)
        {
            int temp = 0;

            for (int i = 0; i <  scholarsList.Count; i++)
            {
               if( scholarsList[i].GetScholarId() == scholarId)
                {
                    scholarsList.RemoveAt(i);
                    temp = 1;
                }
               else if(i ==  scholarsList.Count-1  && temp ==0) { Console.WriteLine("Scholar not exist"); break; }
            }   
        }
        public void AddClassToScholar(int classId)
        {
            for (int i = 0; i < scholarsList.Count; i++)
            {
                    scholarsList[i].ClassScholar.Add(classId);
            }
        }

        public void RemoveClassScholars(int classId)
        {
            for (int i = 0; i < scholarsList.Count; i++)
            {
                for (int j = scholarsList[i].ClassScholar.Count - 1 ; j >= 0; j--)
                {
                    if (scholarsList[i].ClassScholar[j] == classId)
                    {
                        scholarsList[i].ClassScholar.RemoveAt(j);
                    }
                }
            }
        }

        public int GetAndConvertScholarId(string prompt)
        {
            Console.WriteLine(prompt);
            int scholarId = 0;

            while (scholarId==0)
            {
               bool successConvert = int.TryParse(Console.ReadLine(), out scholarId);

                if (successConvert==false)
                {
                    Console.WriteLine("Invalid input: type a number.");
                }
            }
     

            return scholarId;
        }

        public static void ScoresIni(ScholarManager scholarManager)
        {
            Random random = new Random();

            for (int i = 0; i < scholarManager.scholarsList.Count; i++)
            {
               for (int j = 0; j < scholarManager.scholarsList[i].ClassScholar.Count; j++)
                {
                    scholarManager.scholarsList[i].ClassScore.Add(random.Next(0,20));

                }
            }
            ScoreAverage(scholarManager);
        }

        public static void ScoresAssign(ScholarManager scholarManager,int scholarId)
        {
   
            for (int i = 0; i < scholarManager.scholarsList.Count; i++)
            {
                if(scholarManager.scholarsList[i].GetScholarId( ) == scholarId)
                for (int j = 0; j < scholarManager.scholarsList[i].ClassScholar.Count; j++)
                    {
                        int ScoreInput = 0;


                      Console.WriteLine($"class id: {scholarManager.scholarsList[i].ClassScholar[j]} score : ");

                        while (ScoreInput == 0)
                        {
                            bool check = int.TryParse(Console.ReadLine(), out ScoreInput);
                            if (check == false)
                            {
                                Console.WriteLine("type number");

                            }
                        }
                        scholarManager.scholarsList[i].ClassScore[j]=ScoreInput;
                }
            }
        }

        public static void ScoreAverage(ScholarManager scholarManager1)
        {
       
                for (int i = 0; i < scholarManager1.scholarsList.Count; i++)
                 {
                    for (int j = 0; j < scholarManager1.scholarsList[i].ClassScholar.Count; j++)
                    {
                    scholarManager1.scholarsList[i].Average   += scholarManager1.scholarsList[i].ClassScore[j] ;
                    }
                scholarManager1.scholarsList[i].Average /= scholarManager1.scholarsList[i].ClassScore.Count;
                  }
        }

        public static void RatingScholar(ScholarManager scholarManager1)
        {

            scholarManager1.scholarsList.Sort(new ScholarComparerRate());
            for (int i = 0; i < scholarManager1.scholarsList.Count; i++)
            {
                Console.WriteLine($"{scholarManager1.scholarsList[i].Name} \n {scholarManager1.scholarsList[i].LastName} \n {scholarManager1.scholarsList[i].Average}");
            }
            
        }

        public static void SortScholarName(ScholarManager scholarManager1)
        {

            scholarManager1.scholarsList.Sort(new ScholarComparerName());
            for (int i = 0; i < scholarManager1.scholarsList.Count; i++)
            {
                Console.WriteLine($"{scholarManager1.scholarsList[i].Name} \n {scholarManager1.scholarsList[i].LastName} \n {scholarManager1.scholarsList[i].ScholarId}");
            }

        }

        public static void displayScholars(ScholarManager scholarManager1)
        {

            for (int i = 0; i < scholarManager1.scholarsList.Count; i++)
            {
                Console.WriteLine($"{scholarManager1.scholarsList[i].Name} \n {scholarManager1.scholarsList[i].LastName} \n {scholarManager1.scholarsList[i].ScholarId}");
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
            ScoreAverageClassAndOutMin(scholarManager1,listOfScoreForEachClass);
        }

        public static void ScoreAverageClassAndOutMin(ScholarManager scholarManager1, List<List<int>> listOfScoreForEachClass)
        {
            List<int> temp = new List<int>();
            int MinTemp =999;
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
        public static void ChangeScholar(ScholarManager scholarManager, int scholarId)
        {
            int temp = 0;

            for (int i = 0; i < scholarManager.scholarsList.Count; i++)
            {
                if (scholarManager.scholarsList[i].GetScholarId() == scholarId)
                {
                    temp = 1;
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
                else if(i == scholarManager.scholarsList.Count-1 && temp==0) { Console.WriteLine("scholar not exist");
                    break;
                }
            }
        }

    }
}
