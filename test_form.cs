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
    public partial class test_form : Form
    {
        public test_form()
        {
            InitializeComponent();
            utility2.current_exam_chaps.Add(1100);
            utility2.num_of_ques = 10;
            utility2.init_ques();
        }

        private void main_ques_btn_Click(object sender, EventArgs e)
        {
            foreach(Question q in utility2.current_questions)
            {
                string s = $"{q.id}\t{q.statement}\t{q.CorrectAnswer}";
                listBox1.Items.Add(s);
            }
        }
    }
}
