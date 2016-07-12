using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilderSample
{
    public partial class Form1 : Form
    {
        Progress progress = new Progress();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            progress.Init((int)loopLimit.Value);
            progress.Show();
            progress.NextMain();
            NormalLoop();

            progress.NextMain();
            ParallelNormalLoop(2);

            progress.NextMain();
            ParallelNormalLoop(4);

            progress.NextMain();
            ParallelNormalLoop(10);

            progress.Hide();
            MessageBox.Show("Done.");
        }

        private void ParallelNormalLoop(int threadCount)
        {
            string lines = "";
            DateTime timer = DateTime.Now;

            Parallel.For(0, threadCount, i =>
            {
                string threadLines = "";
                for (long j = 0; j < loopLimit.Value / threadCount; j++)
                {
                    long rowNo = j + (((int)loopLimit.Value / 10) * i);
                    threadLines += string.Format("{0},data{1},{2}{3}", rowNo, rowNo, DateTime.Now, System.Environment.NewLine);
                }
                lock (lines) {
                    lines += threadLines;
                };
            });
            switch(threadCount)
            {
                case 2:
                    txtParallelThread2.Text = ((Double)(DateTime.Now.Ticks - timer.Ticks) / 10000000.0).ToString();
                    break;
                case 4:
                    txtParallelThread4.Text = ((Double)(DateTime.Now.Ticks - timer.Ticks) / 10000000.0).ToString();
                    break;
                case 10:
                    txtParallelThread10.Text = ((Double)(DateTime.Now.Ticks - timer.Ticks) / 10000000.0).ToString();
                    break;
                default: break;
            }
            Update();
        }

        private void NormalLoop()
        {
            string lines = "";
            DateTime timer = DateTime.Now;

            for (long i = 0; i < loopLimit.Value; i++)
            {
                lines += string.Format("{0},data{1},{2}{3}", i, i, DateTime.Now, System.Environment.NewLine);
                progress.NextInFunction();
            }
            txtNormal.Text = ((Double)(DateTime.Now.Ticks - timer.Ticks) / 10000000.0).ToString();
            Update();
        }

    }
}
