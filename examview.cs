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
        public static int right = 0, wrong = 0, skipped = 0;
        static double point = 0;
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
            ques_listbox.Items.Clear();
            listBox1.Items.Clear();
            thisexamques.Clear();
            quesread();
            init();

            try
            {
                count = 1;
                

                foreach (Question q in thisexamques)
                {
                    string stat;
                    
                    if (q.givenans == q.CorrectAnswer)
                    {
                        stat = "Correct Answer";
                        right++;
                    }
                    else if (q.givenans == "skipped")
                    {
                        stat = "Skipped Question";
                        skipped++;
                    }
                    else
                    {
                        stat = "Incorrect Answer";
                        wrong++;
                    }


                    string status = "Status :  " + stat;
                    string statement = Convert.ToString(count) +" .  " + q.statement;
                    count++;
                    ques_listbox.Items.Add(statement);
                    string options = $"\ta. {q.Option1}\t\tb. {q.Option2}\t\tc. {q.Option3}\t\td. {q.Option4}";
                    ques_listbox.Items.Add(options);
                    
                    ques_listbox.Items.Add(status);
                    ques_listbox.Items.Add("    ");

                }
                point = right - (wrong * 0.25);
                string result = $"Total Correct : {right}\tTotal Wrong : {wrong}\tTotal skipped : {skipped}\tPoint : {point}";
                ques_listbox.Items.Add("        ");
                ques_listbox.Items.Add("        ");
                listBox1.Items.Add(result);

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
                string detailpath = Utility.studentdir + comboBox1.Text + ".txt";
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

        private void button1_Click(object sender, EventArgs e)
        {
            ques_listbox.Items.Clear();
            listBox1.Items.Clear();
            count = 1;
            thisexamques.Clear();

            init();
        }

        private void init()
        {
            right = 0;
            wrong = 0;
            skipped = 0;
            point = 0;
        }
    }
}
