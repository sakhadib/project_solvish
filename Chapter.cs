using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvish
{
    internal class Chapter
    {
        public string name {  get; set; }
        public int ChapterNumber { get; set; }
        
        List<Question> questions = new List<Question>();

        public Chapter (string name, int number) 
        {
            this.name = name;
            ChapterNumber = number;
        }
    }
}
