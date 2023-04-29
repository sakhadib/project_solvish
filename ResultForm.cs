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

namespace Solvish
{
    public partial class ResultForm : Form
    {
        public static string folderdir = Utility.folderdir;
        public static string exampath = Utility.exampath;
        
        public ResultForm()
        {
            InitializeComponent();
            try
            {
                lab_c_ans.Text = Convert.ToString(utility2.rt_ans);
                lab_w_ans.Text = Convert.ToString(utility2.wr_ans);
                lab_sk_ans.Text = Convert.ToString(utility2.sk_ans);
                lab_pt.Text = Convert.ToString(utility2.curr_point);


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " 1 no e somossa");
            }

            utility2.re_init();
            Utility.count_result();
            try
            {
                string format = "dd_MM_yyyy__hh-mm";
                string v = DateTime.Now.ToString(format);
                utility2.current_exam.time = v;
                StreamWriter sw = File.AppendText(exampath);
                sw.WriteLine($"{utility2.current_exam.time},{utility2.current_exam.right_ans_ct},{utility2.current_exam.wrong_ans_ct}" +
                    $",{utility2.current_exam.skipped_ct},{utility2.current_exam.point},{utility2.current_exam.q_count}");
                sw.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 2 no e somossa");
            }

            try
            {
                //Creating exam file
                string examdetaipath = Utility.studentdir + utility2.current_exam.time + ".txt";
                var myfile = File.Create(examdetaipath);
                myfile.Close();



                //Saving the exam details
                foreach (Question qq in utility2.current_questions)
                {
                    StreamWriter sww = File.AppendText(examdetaipath);
                    sww.WriteLine($"{qq.statement},{qq.Option1},{qq.Option2},{qq.Option3},{qq.Option4},{qq.CorrectAnswer},{qq.givenans}");
                    sww.Close();
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message + "3 e somossa");
            }
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }

        private void save_and_close_button_Click(object sender, EventArgs e)
        {
            
            dashboard de = new dashboard();
            de.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
