using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solvish
{
    public partial class New_Exam : Form
    {
        static string k = "                  ";
        static string x = "__\t_______\t\t___________";
        static int pp = 0;
        public New_Exam()
        {
            InitializeComponent();
            tb_hour.Text = "0";
            tb_minute.Text = "0";

            string z = "no\tsubject\t\tchapter";
            
            listBox1.Items.Add(z);
            listBox1.Items.Add(x);

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            comboBox3.SelectedIndexChanged += ComboBox3_SelectedIndexChanged;


        }

        private void StartExambutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (utility2.current_exam_chaps.Count > 0)
                {
                    if (Convert.ToInt32(num_of_ques_tb.Text) > 0)
                    {
                        pp = 0;
                        try
                        {
                            //initializing the timer
                            Utility.hour = Convert.ToInt32(tb_hour.Text);
                            Utility.minute = Convert.ToInt32(tb_minute.Text);
                            Utility.second = 0;

                            //Checking for timer isuues

                            if (Utility.minute >= 60)
                            {
                                throw new ArgumentException("Invalid minute value. Value must be between 0 and 60.");
                            }

                            if (Utility.hour >= 24)
                            {
                                throw new ArgumentException("Invalid hour value. Value must be between 0 and 24.");
                            }

                        }
                        catch (Exception z)
                        {
                            MessageBox.Show(z.Message + "in the timer");
                        }



                        //Aquiring the number of questions
                        try
                        {
                            utility2.num_of_ques = Convert.ToInt32(num_of_ques_tb.Text) + 1;
                        }
                        catch (Exception w)
                        {
                            MessageBox.Show(w.Message);
                        }

                        utility2.init_ques();

                        // exam form loading
                        examform e1 = new examform();
                        e1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please input a valid number of questions");
                    }

                }
                else
                {
                    MessageBox.Show("Please select some chapters for exam");
                }
            }
            catch
            {
                MessageBox.Show("Please input numbers in every box");
            }
        }

        


        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pp = 0;
            string z = "no\tsubject\t\tchapter";
            listBox1.Items.Add(z);
            listBox1.Items.Add(x);
            utility2.current_exam_chaps.Clear();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item in the ComboBox
            string selectedItem = comboBox1.SelectedItem.ToString();
            int chapcode = 0;
            if (selectedItem == "Dynamics") chapcode = 1100;
            else if (selectedItem == "Mechancis") chapcode = 1200;
            else if (selectedItem == "WEAP") chapcode = 1300;
            else if (selectedItem == "Pressure") chapcode = 1400;
            string s = $"{++pp}\tphysics\t\t{selectedItem}";
            listBox1.Items.Add(s);
            //listBox1.Items.Add(k);
            utility2.current_exam_chaps.Add(chapcode);
        }
        
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item in the ComboBox
            string selectedItem = comboBox2.SelectedItem.ToString();
            int chapcode = 0;
            if (selectedItem == "State of Matter") chapcode = 2100;
            else if (selectedItem == "Structure of Matter") chapcode = 2200;
            else if (selectedItem == "Periodic Table") chapcode = 2300;
            else if (selectedItem == "Chemical Bond") chapcode = 2400;
            string s = $"{++pp}\tChemistry\t\t{selectedItem}";
            listBox1.Items.Add(s);
            utility2.current_exam_chaps.Add(chapcode);
        }

        

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item in the ComboBox
            string selectedItem = comboBox3.SelectedItem.ToString();
            int chapcode = 0;
            if (selectedItem == "ICT & Bangladesh") chapcode = 3100;
            else if (selectedItem == "Computer security") chapcode = 3200;
            else if (selectedItem == "Internet Education") chapcode = 3300;
            else if (selectedItem == "Accounts") chapcode = 3400;
            string s = $"{++pp}\tICT\t\t{selectedItem}";
            listBox1.Items.Add(s);
            
            utility2.current_exam_chaps.Add(chapcode);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
