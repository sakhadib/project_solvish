using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solvish
{
    public partial class Login_form : Form
    {
        static string folderdir = @"C:\solvish\";
        public string studentpath = folderdir + @"username.txt";
        public string quespath = folderdir + @"questions.txt";
        

        public Login_form()
        {
            InitializeComponent();
        }

        private void form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            try
            {
                
                foreach (student ss in Utility.studentsArray)
                {
                    if (ss.username == uname_tb.Text && ss.password == pass_tb.Text)
                    {
                        //initialize dashboard
                        flag = true;
                        Utility.current_student = ss;
                        break;
                    }
                    else
                    {
                        flag = false;
                    }
                }

                
            }
            catch
            {
                MessageBox.Show("Input Valid Characters");
            }

            //initializing all previous exams

            try
            {
                string exampath = folderdir + Utility.current_student.username + ".txt";
                StreamReader examread = new StreamReader(exampath);
                string exams = examread.ReadLine();
                while (exams != null)
                {
                    string[] examfrags = exams.Split(',');
                    //stored as name,username,password
                    string Time = examfrags[0];
                    int rt_ans = Convert.ToInt32(examfrags[1]);
                    int wr_ans = Convert.ToInt32(examfrags[2]);
                    int skippded = Convert.ToInt32(examfrags[3]);
                    double point = Convert.ToDouble(examfrags[4]);
                    int q_count = Convert.ToInt32(examfrags[5]);

                    Exam eq = new Exam(rt_ans, wr_ans, skippded, point, q_count, Time);
                    Utility.ExamsArray.Add(eq);
                    exams = examread.ReadLine();
                }
                examread.Close();

                Utility.count_result();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"Examfrags e somossa");
            }

            if (flag)
            {
                utility_form.dashboard = new dashboard();
                utility_form.dashboard.Show();

                /*dashboard dd = new dashboard();
                dd.Show();*/
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(pass_tb.UseSystemPasswordChar)
            {
                pass_tb.UseSystemPasswordChar = false;
            }
            else
            {
                pass_tb.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            utility_form.signup_Form.Show();
            this.Hide();
        }
    }
}
