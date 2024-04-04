using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni.Models;

namespace Uni.Services
{
    internal class AddClass : ScholarManager{
    
        public void AddClassToScholar(int classId)
        {
            for (int i = 0; i < scholarsList.Count; i++)
            {
                scholarsList[i].ClassScholar.Add(classId);
            }
        }
    }

}
