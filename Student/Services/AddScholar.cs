using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni.Models;

namespace Uni.Services
{
    internal class AddScholar : ScholarManager
    {
        public void addScholar(Scholar scholar)
        {
            scholarsList.Add(scholar);
        }
    }
}
