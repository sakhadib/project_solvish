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
        public static string folderdir = @"C:\solvish\";
        public static string exampath = folderdir + Utility.current_student.username + ".txt";
        
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
                MessageBox.Show(ex.Message);
            }
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }

        private void save_and_close_button_Click(object sender, EventArgs e)
        {
            utility2.re_init();
            try
            {
                StreamWriter sw = File.AppendText(exampath);
                sw.WriteLine($"{utility2.current_exam.time},{utility2.current_exam.right_ans_ct},{utility2.current_exam.wrong_ans_ct}" +
                    $",{utility2.current_exam.skipped_ct},{utility2.current_exam.point},{ utility2.current_exam.q_count}");
                sw.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }

            dashboard de = new dashboard();
            de.Show();
            this.Hide();
        }
    }
}
