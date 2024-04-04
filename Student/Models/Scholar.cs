using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Models
{
    public class Scholar
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public int ScholarId { get; set; }
        public List<int> ClassScholar { get; set; } = new List<int>();
        public List<int> ClassScore = new List<int>();
        public int Average { get; set; }

        public Scholar(string name, string lastName, int scholarId)
        {
            Name = name;
            LastName = lastName;
            ScholarId = scholarId;
        }

        public int GetScholarId()
        {
            return ScholarId;
        }

    }
}
