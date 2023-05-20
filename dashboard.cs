﻿using System;
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
using System.Diagnostics;

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
            name_label.Text = Convert.ToString(Utility.current_student.name) + " !!";

            //this.FormClosing += MainForm_FormClosing;

            lab_corr.Text = Convert.ToString(Utility.total_corr);
            lab_wr.Text = Convert.ToString(Utility.total_wrong);
            lab_skp.Text = Convert.ToString(Utility.total_skip);

            //Add data to the piechart
            right_wrong_chart.Series["Right_Wrong"].Points.AddXY("Right", Utility.total_corr);
            right_wrong_chart.Series["Right_Wrong"].Points.AddXY("Skipped", Utility.total_skip);
            right_wrong_chart.Series["Right_Wrong"].Points.AddXY("Wrong", Utility.total_wrong);
            

            //Add data to the graph
            foreach (Exam eq in Utility.ExamsArray)
            {
                exam_chart.Series["Exam"].Points.AddXY($"Exam-{utility2.examcount}", eq.point);
                utility2.examcount++;
            }
            utility2.examcount = 1;


        }

        

        public void renit()
        {
            lab_corr.Text = Convert.ToString(Utility.total_corr);
            lab_wr.Text = Convert.ToString(Utility.total_wrong);
            lab_skp.Text = Convert.ToString(Utility.total_skip);

            //Add data to the piechart
            try
            {
                right_wrong_chart.Series["Right_Wrong"].Points.AddXY("Right", Utility.total_corr);
                right_wrong_chart.Series["Right_Wrong"].Points.AddXY("Wrong", Utility.total_wrong);
                right_wrong_chart.Series["Right_Wrong"].Points.AddXY("Skipped", Utility.total_skip);
            }
            catch
            {

            }

            //Add data to the graph
            foreach (Exam eq in Utility.ExamsArray)
            {
                exam_chart.Series["Exam"].Points.AddXY($"Exam-{utility2.examcount}", eq.point);
                utility2.examcount++;
            }
            utility2.examcount = 1;
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

            Utility.ExamsArray.Clear();
        }

        private void initialize_question_button_Click(object sender, EventArgs e)
        {

            try
            {

                //code for web cliant. Turn on after question file is uploaded

                if (File.Exists(quespath))
                {
                    File.Delete(quespath);

                    string url = "https://sakhawatadib.com/wp-content/uploads/2023/05/questions.txt";
                    string ok = quespath;
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(filedw);
                    Uri questions = new Uri(url);
                    wc.DownloadFileAsync(questions, ok);
                }
                else
                {
                    string url = "https://sakhawatadib.com/wp-content/uploads/2023/05/questions.txt";
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

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "https://sakhawatadib.com/solvish/";
            Process.Start(url);
        }

        private void right_wrong_chart_Click(object sender, EventArgs e)
        {

        }
    }
}
