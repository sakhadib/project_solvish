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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Solvish
{
    public partial class signup_form : Form
    {
        string studentpath = "username.txt";
        public signup_form()
        {
            InitializeComponent();
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
            if(tb_name.Text == null || tb_uname.Text == null || tb_pass.Text == null || tb_retype_pass.Text == null) 
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
                    if(tb_pass.Text.Length <= 8)
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
                                MessageBox.Show("Passwords must be more than 7 characters");
                                flag = false;
                                break;
                            }
                        }
                        if(flag)
                        {
                            student s = new student(tb_name.Text, tb_uname.Text, tb_pass.Text);
                            StreamWriter sw = File.AppendText(studentpath);
                            sw.WriteLine($"{tb_name.Text},{tb_uname.Text},{tb_pass.Text}");
                            sw.Close();
                        }
                    }
                }
            }
        }

        
    }
}
