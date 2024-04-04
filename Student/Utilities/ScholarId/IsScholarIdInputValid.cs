using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Utilities.ScholarId
{
    public class IsScholarIdInputValid
    {
        public bool isScholarIdInputValid(string scholarIdInput)
        {
            int scholarId = 0;
            bool successConvert = false;

            successConvert = int.TryParse(scholarIdInput, out scholarId);

            return successConvert;
        }
    }
}
