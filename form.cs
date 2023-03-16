using System;
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
            foreach(student ss in Utility.studentsArray)
            {
                if(ss.username == uname_tb.Text && ss.password == pass_tb.Text)
                {
                    //initialize dashboard
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
            }

            if(flag)
            {
                MessageBox.Show("You are authenticated");
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }
    }
}
