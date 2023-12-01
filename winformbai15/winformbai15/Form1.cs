using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformbai15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //cong viec chinh

            int sum = 0;
            for(int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);
                sum += i;
                //goi su kien progresschange
                backgroundWorker1.ReportProgress(i);//tien trinh chay
                if (backgroundWorker1.CancellationPending)//kiem tra co cancel khog
                {
                    e.Cancel = true;//e cua doworkevent
                    backgroundWorker1.ReportProgress(0);
                    return;
                }

            }
            e.Result = sum;

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value=e.ProgressPercentage;
            lbl1.Text=e.ProgressPercentage.ToString()+"%";

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lbl2.Text = "tien trinh huy";
            }
            else if(e.Error != null)
            {
                lbl2.Text = e.Error.Message;
            }
            else
            {
                lbl2.Text="ket qua la"+e.Result.ToString()+"%";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lbl2.Text = "";
            //check backgroundworker bi busy khong
            if(!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                lbl2.Text = "dang chay tien trinh";
            }
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //neu worker dang chay cancel
            if(backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            else
            {
                lbl2.Text = "app dang khong chay";
            }
        }
    }
}
