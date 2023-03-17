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
    public partial class examform : Form
    {
        public examform()
        {
            InitializeComponent();
            TimeLabel.Text = $"{Utility.hour} : {Utility.minute} : {Utility.second}";
        }

        System.Timers.Timer timer;
        int s = Utility.second;
        int m = Utility.minute;
        int h = Utility.hour;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Result result = new Result();
            result.Show();
            this.Hide();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                if(TimeLabel.Text== "0 : 0 : 0")
                {
                    timer.Stop();
                    Result result = new Result();
                    result.Show();
                    this.Hide();
                }

                if(s== 0) 
                {
                    m--;
                    s = 59;
                
                }
                else { s--; }
                if(m==0)
                {
                    if(h>0) 
                    {
                        h--;
                        m = 59;
                    }
                }

                TimeLabel.Text = $"{h} : {m} : {s}";
            }

            ));
        }

        private void examform_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }
    }
}
