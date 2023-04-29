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
        public static int x = 0;
        public detailed_view()
        {
            InitializeComponent();
            
            List<Exam> ExamsArrayCopy = new List<Exam>(Utility.ExamsArray);
            ExamsArrayCopy.Reverse();
            string uu = "\t\t\t\tYOUR DETAILED EXAM VIEW";
            result_lb.Items.Add(uu);
            string start = "\tNo.\tDate and Time of exam\tn(Q)\tCA\tWA\tSk\tPt";
            string mid = "     ";
            string end = "\t___\t_____________________\t____\t__\t__\t__\t___";
            result_lb.Items.Add(mid);
            result_lb.Items.Add(start);
            result_lb.Items.Add(end);
            result_lb.Items.Add(mid);
            foreach (Exam e in ExamsArrayCopy)
            {
                string st = $"\t{++x}\t{e.time}\t\t{e.q_count}\t{e.right_ans_ct}\t{e.wrong_ans_ct}\t{e.skipped_ct}\t{e.point}";
                result_lb.Items.Add(st);
                result_lb.Items.Add(mid);
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            x = 0;
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            examview ev = new examview();
            ev.Show();
            this.Hide();
        }
    }
}
