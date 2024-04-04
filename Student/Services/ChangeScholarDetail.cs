using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni.Models;

namespace Uni.Services
{
    internal class ChangeScholarDetail : ScholarManager{

        public void changeScholarDetail(ScholarManager scholarManager)
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
    }

}
