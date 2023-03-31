using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solvish
{
    public partial class Performance : Form
    {
        public Performance()
        {
            InitializeComponent();

            //Add data to the piechart
            right_wrong_chart.Series["Right_Wrong"].Points.AddXY("Right", Utility.total_corr);
            right_wrong_chart.Series["Right_Wrong"].Points.AddXY("Wrong", Utility.total_wrong);
            right_wrong_chart.Series["Right_Wrong"].Points.AddXY("Skipped", Utility.total_skip);

            //Add data to the graph
            foreach(Exam eq in Utility.ExamsArray)
            {
                exam_chart.Series["Exam"].Points.AddXY($"Exam-{utility2.examcount}", eq.point);
                utility2.examcount++;
            }
            utility2.examcount = 1;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }
    }

            
        
    
}

        
    

