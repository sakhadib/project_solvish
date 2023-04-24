using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solvish
{
    public partial class examview : Form
    {
        List<Question> thisexamques = new List<Question>();
        static int count = 1;
        public examview()
        {
            InitializeComponent();
            foreach(Exam ee in Utility.ExamsArray)
            {
                string time = ee.time;
                comboBox1.Items.Add(time);
            }
        }

        private void examview_Load(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            quesread();
            try
            {
                foreach(Question q in thisexamques)
                {
                    string statement = Convert.ToString(count) +" .  " + q.statement;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void quesread()
        {
            try
            {
                string detailpath = Utility.studentdir + comboBox1.Text;
                StreamReader questread = new StreamReader(detailpath);
                string quest = questread.ReadLine();
                while (quest != null)
                {
                    string[] quesfrags = quest.Split(',');
                    //stored as statement,op1,op2,op3,op4,ans,given_ans

                    string statement = quesfrags[0];
                    string op1 = quesfrags[1];
                    string op2 = quesfrags[2];
                    string op3 = quesfrags[3];
                    string op4 = quesfrags[4];
                    string corr = quesfrags[5];
                    string given = quesfrags[6];

                    Question q = new Question(statement, op1, op2, op3, op4, corr, given);
                    thisexamques.Add(q);
                    quest = questread.ReadLine();
                }
                questread.Close();
            }
            catch
            {
                MessageBox.Show("Please select the valid exam time");
            }
        }
    }
}
