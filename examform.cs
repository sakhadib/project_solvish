using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.AxHost;

namespace Solvish
{
    public partial class examform : Form
    {
        public static int index = -1;
        
        public examform()
        {
            InitializeComponent();
            //initializing randomized questions for exam
            utility2.init_ques();

            TimeLabel.Text = $"{Utility.hour} : {Utility.minute} : {Utility.second}";
            quescng(index);
            index++;
        }

        System.Timers.Timer timer;
        int s = Utility.second;
        int m = Utility.minute;
        int h = Utility.hour;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        //submit button
        private void button7_Click(object sender, EventArgs e)
        {
            //utility2.re_init();
            index = -1;
            timer.Stop();

            
            
            //result
            ResultForm result = new ResultForm();
            result.Show();
            this.Hide();
        }

        //method for timer

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                if(TimeLabel.Text== "0 : 0 : 0")
                {
                    timer.Stop();
                    ResultForm result = new ResultForm();
                    result.Show();
                    this.Hide();
                }

                if(s== 0) 
                {
                    m--;
                    s = 59;
                
                }
                else { s--; }
                if(m==0)
                {
                    if(h>0) 
                    {
                        h--;
                        m = 59;
                    }
                }

                TimeLabel.Text = $"{h} : {m} : {s}";
            }

            ));
        }

        private void examform_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        public void givenset( string statement, string givenans)
        {
            foreach (Question q in utility2.current_questions)
            {
                if (statement == q.statement)
                {
                    q.givenans = givenans;
                }
            }
        }


        //option buttons
        private void op_a_btn_Click(object sender, EventArgs e)
        {
            string ans = op_a_btn.Text;         //taking ans
            string st = lab_statement.Text;     //taking statement
            bool corr = iscorr(st, ans);        //checking
            givenset(st, ans);
            
            if (corr)                           //for correct ans
                pointct(2);                     //pass value 2
            else                                //for incorrect ans   
                pointct(0);                     //pass value 0
            if (index != utility2.num_of_ques - 1)
            {
                quescng(index);                     //changing question
                index++;                            //increamenting index
            }
            else
            {
                MessageBox.Show("Exam is finished. Hit the submit button");
            }
        }

        private void op_b_btn_Click(object sender, EventArgs e)
        {
            string ans = op_b_btn.Text;         //taking ans
            string st = lab_statement.Text;     //taking statement
            bool corr = iscorr(st, ans);        //checking
            givenset(st, ans);

            if (corr)                           //for correct ans
                pointct(2);                     //pass value 2
            else                                //for incorrect ans   
                pointct(0);                     //pass value 0

            if (index != utility2.num_of_ques - 1)
            {
                quescng(index);                     //changing question
                index++;                            //increamenting index
            }
            else
            {
                MessageBox.Show("Exam is finished. Hit the submit button");
            }
        }

        private void op_c_btn_Click(object sender, EventArgs e)
        {
            string ans = op_c_btn.Text;         //taking ans
            string st = lab_statement.Text;     //taking statement
            bool corr = iscorr(st, ans);        //checking
            givenset(st, ans);

            if (corr)                           //for correct ans
                pointct(2);                     //pass value 2
            else                                //for incorrect ans   
                pointct(0);                     //pass value 0

            if (index != utility2.num_of_ques - 1)
            {
                quescng(index);                     //changing question
                index++;                            //increamenting index
            }
            else
            {
                MessageBox.Show("Exam is finished. Hit the submit button");
            }
        }

        private void op_d_btn_Click(object sender, EventArgs e)
        {
            string ans = op_d_btn.Text;         //taking ans
            string st = lab_statement.Text;     //taking statement
            bool corr = iscorr(st, ans);        //checking
            givenset(st, ans);

            if (corr)                           //for correct ans
                pointct(2);                     //pass value 2
            else                                //for incorrect ans   
                pointct(0);                     //pass value 0

            if (index != utility2.num_of_ques - 1)
            {
                quescng(index);                     //changing question
                index++;                            //increamenting index
            }
            else
            {
                MessageBox.Show("Exam is finished. Hit the submit button");
            }
        }

        private void skp_butt_Click(object sender, EventArgs e)
        {
            try
            {
                pointct(1);
                if (index <= utility2.num_of_ques - 1)
                {
                    quescng(index);                     //changing question
                    index++;                            //increamenting index
                }
                else
                {
                    MessageBox.Show("Exam is finished. Hit the submit button");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //methods nessesary for question change and point count

        //for question change
        private void quescng(int idx)
        {
            try
            {
                int xdx = idx + 1;
                Question q = utility2.current_questions[xdx];  
                lab_statement.Text = q.statement;
                op_a_btn.Text = q.Option1;
                op_b_btn.Text = q.Option2;
                op_c_btn.Text = q.Option3;
                op_d_btn.Text = q.Option4;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Application.Exit();
            }
        }

        //for correct ans check
        private bool iscorr(string statement, string ans)
        {
            bool flag = false;
            foreach (Question q in utility2.current_questions)
            {
                if (statement == q.statement)
                {
                    if (ans == q.CorrectAnswer)
                    {
                        flag = true;
                    }
                }
            }

            if (flag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //point er chorachori
        private void pointct(int flag)
        {
            if(flag == 2)
            {
                utility2.rt_ans++;
                utility2.curr_point = utility2.curr_point + 1;
            }

            else if(flag == 1)
            {
                utility2.sk_ans++;
            }

            else
            {
                utility2.wr_ans++;
                utility2.curr_point = utility2.curr_point - 0.25;
            }
        }

        
    }
}
