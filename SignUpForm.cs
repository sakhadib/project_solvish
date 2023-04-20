using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Solvish
{
    public partial class signup_form : Form
    {
        //static string studentdir;
        WebClient wc = new WebClient(); //declaring the web cliant.
        static string folderdir = Utility.folderdir;
        public string studentpath = Utility.studentpath;
        public string quespath = Utility.quespath;
        public signup_form()
        {
            InitializeComponent();
            //MessageBox.Show("If you are not connected to internet, Please connect to the " +
               // "internet before creating account. Or the questions will not be downloaded");

            tb_name.Focus();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            



            if (tb_name.Text == null || tb_uname.Text == null || tb_pass.Text == null || tb_retype_pass.Text == null) 
            {
                MessageBox.Show("Please Fill out All boxes");
            }
            else
            {
                if(tb_pass.Text != tb_retype_pass.Text)
                {
                    MessageBox.Show("Passwords Do not Match");
                }
                else
                {
                    if(tb_pass.Text.Length < 8)
                    {
                        MessageBox.Show("Passwords must be more than 7 characters");
                    }
                    else
                    {
                        bool flag = true;
                        foreach(student ss in Utility.studentsArray)
                        {
                            if(ss.username == tb_uname.Text)
                            {
                                MessageBox.Show("Username Exist. Try another");
                                flag = false;
                                break;
                            }
                        }
                        if(flag)
                        {
                            
                            student s = new student(tb_name.Text, tb_uname.Text, tb_pass.Text);
                            Utility.current_student = s;
                            Utility.studentsArray.Add(s);
                            StreamWriter sw = File.AppendText(studentpath);
                            sw.WriteLine($"{tb_name.Text},{tb_uname.Text},{tb_pass.Text}");
                            sw.Close();

                            //creating student folder
                            string slash = @"\";
                            Utility.studentdir = folderdir + tb_uname.Text + slash;
                            try
                            {
                                DirectoryInfo dir = new DirectoryInfo(Utility.studentdir);
                                dir.Create();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            Utility.exampath = Utility.studentdir + Utility.current_student.username + ".txt";
                            var myfile = File.Create(Utility.exampath);
                            myfile.Close();
                            

                            Login_form llo = new Login_form();
                            llo.Show();
                            this.Hide();
                        }
                    }
                }
            }

            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (tb_pass.UseSystemPasswordChar)
            {
                tb_pass.UseSystemPasswordChar = false;
            }
            else
            {
                tb_pass.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (tb_retype_pass.UseSystemPasswordChar)
            {
                tb_retype_pass.UseSystemPasswordChar = false;
            }
            else
            {
                tb_retype_pass.UseSystemPasswordChar = true;
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            utility_form.login_form.Show();
            this.Hide();
        }
    }
}
