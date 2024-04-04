using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Utilities.ScholarId
{
    internal class ScholarIdExistIndexRetrieve : ScholarManager
    {
        public int GetScholarIndexAndValidation(int scholarId)
        {

            for (int i = 0; i < scholarsList.Count; i++)
            {
                if (scholarsList[i].GetScholarId() == scholarId)
                {

                    return i;
                }

            }
            return -1;
        }
    }
}
