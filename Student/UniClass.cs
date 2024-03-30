using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni
{
    internal class UniClass
    {
       private int ClassId {  get; set; }
        private string ClassName { get; set; }

        public UniClass(int classId,string className) { 
        
            ClassId = classId;
            ClassName = className;
        }
        public int GetClassId()
        {
           return ClassId;
        }
        public string GetClassName()
        {
            return ClassName;
        }
    }
}
