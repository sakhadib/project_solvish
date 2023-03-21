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

        }



        

        private void Start_Click(object sender, EventArgs e)
        {

            //initializing student list
            if(System.IO.File.Exists(studentpath))
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

            

            Login_form login = new Login_form();
            login.Show();
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

        

        
    }

}
