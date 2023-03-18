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
using System.Net;

namespace Solvish
{
    public partial class dashboard : Form
    {
        WebClient wc = new WebClient(); //declaring the web cliant.
        static string folderdir = @"C:\solvish";
        public string studentpath = folderdir + @"\username.txt";
        public string quespath = folderdir + @"\questions.txt";
        public dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                //code for web cliant. Turn on after question file is uploaded

                if (File.Exists(quespath))
                {
                    File.Delete(quespath);
                    string url = "https://sakhawatadib.com/wp-content/uploads/2023/03/questions.txt";
                    string ok = quespath;
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(filedw);
                    Uri questions = new Uri(url);
                    wc.DownloadFileAsync(questions, ok);
                }
                else
                {
                    string url = "https://sakhawatadib.com/wp-content/uploads/2023/03/questions.txt";
                    string ok = quespath;
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(filedw);
                    Uri questions = new Uri(url);
                    wc.DownloadFileAsync(questions, ok);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("You need to connect to internet to download the questions from server.");
            }
        }
        private void filedw(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Downloaded Questions. You are good to go now");
        }
    }
}
