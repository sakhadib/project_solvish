﻿using System;
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
        public New_Exam()
        {
            InitializeComponent();
        }

        private void StartExambutton_Click(object sender, EventArgs e)
        {
            Utility.hour = Convert.ToInt32(tb_hour.Text);
            Utility.minute = Convert.ToInt32(tb_minute.Text);
            Utility.second = 0;

            examform e1 = new examform();
            e1.Show();
            this.Hide();
        }
    }
}
