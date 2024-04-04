using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Utilities.ScholarId
{
    internal class AskScholarId : ScholarManager
    {
     public string askScholarId(){
                Console.WriteLine("Enter scholar id:");
            return Console.ReadLine();
      }
        
    }
}
