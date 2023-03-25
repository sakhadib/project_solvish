﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Solvish
{
    public partial class StartForm : Form
    {
        WebClient wc = new WebClient(); //declaring the web cliant.
        
        Exam current_exam = new Exam();
        static string folderdir = @"C:\solvish\";
        public string studentpath = folderdir + "username.txt"; //for initializing the student list
        public string quespath = folderdir + "questions.txt"; //for initializing the question list
        
        public StartForm()
        {
            InitializeComponent();
            if (Directory.Exists(folderdir))//kaj kore
            {
                // do nothing;
            }
            else
            {
                //if do not exist then create the directory first.
                DirectoryInfo dir = new DirectoryInfo(folderdir);
                dir.Create();
                
            }

            try
            {

                //code for web cliant. Turn on after question file is uploaded

                if (System.IO.File.Exists(quespath))
                {
                    StreamReader questread = new StreamReader(quespath);
                    string quest = questread.ReadLine();
                    while (quest != null)
                    {
                        string[] quesfrags = quest.Split(',');
                        //stored as statement,op1,op2,op3,op4,ans
                        string ID = quesfrags[0];
                        string statement = quesfrags[1];
                        string op1 = quesfrags[2];
                        string op2 = quesfrags[3];
                        string op3 = quesfrags[4];
                        string op4 = quesfrags[5];
                        string corr = quesfrags[6];
                        int id = Convert.ToInt32(ID);
                        Question q = new Question(id, statement, op1, op2, op3, op4, corr);
                        Utility.QuestionsArray.Add(q);
                        quest = questread.ReadLine();
                    }
                    questread.Close();
                }
                else
                {
                    string url = "https://sakhawatadib.com/wp-content/uploads/2023/03/questions.txt";
                    string ok = quespath;
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(filedw);
                    Uri questions = new Uri(url);
                    wc.DownloadFileAsync(questions, ok);


                    StreamReader questread = new StreamReader(quespath);
                    string quest = questread.ReadLine();
                    while (quest != null)
                    {
                        string[] quesfrags = quest.Split(',');
                        //stored as statement,op1,op2,op3,op4,ans
                        string ID = quesfrags[0];
                        string statement = quesfrags[1];
                        string op1 = quesfrags[2];
                        string op2 = quesfrags[3];
                        string op3 = quesfrags[4];
                        string op4 = quesfrags[5];
                        string corr = quesfrags[6];
                        int id = Convert.ToInt32(ID);
                        Question q = new Question(id, statement, op1, op2, op3, op4, corr);
                        Utility.QuestionsArray.Add(q);
                        quest = questread.ReadLine();
                    }
                    questread.Close();

                }


            }
            catch (Exception)
            {
                MessageBox.Show("You need to connect to internet to download the questions from server.");
            }

        }



        

        private void Start_Click(object sender, EventArgs e)
        {

            try
            {
                //initializing student list
                if (System.IO.File.Exists(studentpath))
                {
                    StreamReader studentread = new StreamReader(studentpath);
                    string students = studentread.ReadLine();
                    while (students != null)
                    {
                        string[] studentfrags = students.Split(',');
                        //stored as name,username,password
                        string name = studentfrags[0];
                        string username = studentfrags[1];
                        string password = studentfrags[2];

                        student s = new student(name, username, password);
                        Utility.studentsArray.Add(s);
                        students = studentread.ReadLine();
                    }
                    studentread.Close();
                }


                else
                {
                    System.IO.File.Create(studentpath);
                    StreamReader studentread = new StreamReader(studentpath);
                    string students = studentread.ReadLine();
                    while (students != null)
                    {
                        string[] studentfrags = students.Split(',');
                        //stored as name,username,password
                        string name = studentfrags[0];
                        string username = studentfrags[1];
                        string password = studentfrags[2];

                        student s = new student(name, username, password);
                        Utility.studentsArray.Add(s);
                        students = studentread.ReadLine();
                    }
                    studentread.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            Login_form login = new Login_form();
            login.Show();
            /*test_form tf = new test_form();
            tf.Show();*/
            this.Hide();

            //testing
            /*foreach(student s in Utility.studentsArray)
            {
                string wp = $"{s.name}\t{s.username}\t{s.password}";
                listBox1.Items.Add(wp);
            }
            foreach (Question qqqt in Utility.QuestionsArray)
            {
                string qp = $"{qqqt.id}\t{qqqt.statement}\t{qqqt.Option1}\t{qqqt.Option2}\t{qqqt.Option3}\t{qqqt.Option4}\t{qqqt.CorrectAnswer}";
                listBox2.Items.Add(qp);
            }*/

        }

        private void filedw(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Downloaded Questions. You are good to go now");
        }




    }

}
