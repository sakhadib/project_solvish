using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvish
{
    internal class Subject
    {
        public string name { get; set; }

        List<Chapter> chapters = new List<Chapter>();

        public Subject(string name) 
        {
          this.name = name;
        }
    }
}
