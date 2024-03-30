using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni
{
    internal class ClassManager
    {
        
            List<UniClass> classList = new List<UniClass>();

            public void addClass(UniClass uniClass)
            {
            classList.Add(uniClass);
            }
            public void removeClass(int classId)
            {
                for (int i = 0; i < classList.Count ; i++)
                {

                if (classList[i].GetClassId() == classId)
                    {
                        classList.RemoveAt(i);
                    }
                }
            }
        public int GetAndConvertClassId(string prompt)
        {
            int classId =0;

            Console.WriteLine(prompt);

            while (classId == 0)
            {
                bool successConvert = int.TryParse(Console.ReadLine(), out classId);

                if (successConvert = false)
                {
                    Console.WriteLine("wrong input");
                }

            }
            //if (classId == 0)
            //{
            //    GetAndConvertClassId(prompt);
            //}
            return classId;
        }
        public List<UniClass> GetClasses() { 
        return classList;
        }

    }
}
