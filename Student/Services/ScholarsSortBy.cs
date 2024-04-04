using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Services
{
    internal class ScholarsSortBy
    {
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
    }
}
