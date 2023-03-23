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
using System.Net;

namespace Solvish
{
    public partial class dashboard : Form
    {
        WebClient wc = new WebClient(); //declaring the web cliant.
        static string folderdir = @"C:\solvish\";
        public string studentpath = folderdir + @"username.txt";
        public string quespath = folderdir + @"questions.txt";
        public static string exampath = folderdir + Utility.current_student.username + ".txt";

        
        public dashboard()
        {
            InitializeComponent();
            name_label.Text = Convert.ToString(Utility.current_student.name) + " !";

            //initializing all previous exams
            
            try
            {
                StreamReader examread = new StreamReader(exampath);
                string exams = examread.ReadLine();
                while (exams != null)
                {
                    string[] examfrags = exams.Split(',');
                    //stored as name,username,password
                    string Time = examfrags[0];
                    int rt_ans = Convert.ToInt32(exams[1]);
                    int wr_ans = Convert.ToInt32(examfrags[2]);
                    int skippded = Convert.ToInt32(examfrags[3]);
                    double point = Convert.ToDouble(examfrags[4]);
                    int q_count = Convert.ToInt32(examfrags[5]);

                    Exam e = new Exam(rt_ans, wr_ans, skippded, point, q_count, Time);
                    Utility.ExamsArray.Add(e);
                    exams = examread.ReadLine();
                }
                examread.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void filedw(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Downloaded Questions. You are good to go now");
        }

       

        private void new_exam_button_Click(object sender, EventArgs e)
        {
            New_Exam ne = new New_Exam();
            ne.Show();
            this.Close();
        }

        private void past_exams_btn_Click(object sender, EventArgs e)
        {
            detailed_view de = new detailed_view();
            de.Show();
            this.Hide();
        }

        private void Edit_profile_button_Click(object sender, EventArgs e)
        {
            //edit profile er form dibo eikhane
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Utility.current_student = null;
            Login_form loo = new Login_form();
            loo.Show();
            this.Hide();
        }

        private void initialize_question_button_Click(object sender, EventArgs e)
        {

            try
            {

                //code for web cliant. Turn on after question file is uploaded

                if (File.Exists(quespath))
                {
                    File.Delete(quespath);
                    string url = "https://sakhawatadib.com/wp-content/uploads/2023/03/questions.txt";
                    string ok = quespath;
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(filedw);
                    Uri questions = new Uri(url);
                    wc.DownloadFileAsync(questions, ok);
                }
                else
                {
                    string url = "https://sakhawatadib.com/wp-content/uploads/2023/03/questions.txt";
                    string ok = quespath;
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(filedw);
                    Uri questions = new Uri(url);
                    wc.DownloadFileAsync(questions, ok);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("You need to connect to internet to download the questions from server.");
            }
        }
    }
}
