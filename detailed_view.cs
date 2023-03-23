using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solvish
{
    public partial class detailed_view : Form
    {
        public detailed_view()
        {
            InitializeComponent();
            List<Exam> ExamsArrayCopy = new List<Exam>(Utility.ExamsArray);
            ExamsArrayCopy.Reverse();
            string start = "\tDate and Time of exam\tn(Q)\tCA\tWA\tSk\tPt";
            string mid = "\t                     \t    \t  \t  \t  \t   ";
            string end = "\t_____________________\t____\t__\t__\t__\t___";
            result_lb.Items.Add(start);
            result_lb.Items.Add(end);
            result_lb.Items.Add(mid);
            foreach (Exam e in Utility.ExamsArray)
            {
                string st = $"\t{e.time}\t{e.q_count}\t{e.right_ans_ct}\t{e.wrong_ans_ct}\t{e.skipped_ct}\t{e.point}";
                result_lb.Items.Add(st);
            }
        }

        
    }
}
