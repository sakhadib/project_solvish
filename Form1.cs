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
    public partial class Form1 : Form
    {
        Exam current_exam = new Exam();
        public string path = "username.txt"; //for initializing the student list
        public Form1()
        {
            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Login_form f = new Login_form();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            signup_form f1 = new signup_form();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            examform ff = new examform();
            ff.Show();
            this.Hide();
        }
        
        private void Start_Click(object sender, EventArgs e)
        {
            //initializing student list
            StreamReader studentread = new StreamReader(path);
            string students = studentread.ReadLine();
            while(students != null)
            {
                string[] studentfrags = students.Split(',');
                //stored as username,
            }

        }


    }

}
