using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Utilities.ScholarId
{
    internal class GetScholarIdFromUser 
    {
        AskScholarId askScholarId = new AskScholarId();

        public string GetIdFromUser()
        {
            return askScholarId.askScholarId();
        }
    }
}
