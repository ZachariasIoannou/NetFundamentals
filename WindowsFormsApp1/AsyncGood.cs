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

namespace WindowsFormsApp1
{
    public partial class AsyncGood : Form
    {
        delegate void StartProcessDelegate(int val);
        delegate void ShowProcessDelegate(int val);

        public AsyncGood()
        {
            InitializeComponent();
        }

        public static void Main()
        {
            Application.Run(new AsyncGood());
        }

        private void StartButton_Click_1(object sender, EventArgs e)
        {
            var progDel = new StartProcessDelegate(StartProcess);
            progDel.BeginInvoke(100, null, null);
            MessageBox.Show(@"Done with operation");
        }
        //called asyncronusly
        private void StartProcess(int max)
        {
            ShowProgress(0);
            for (int i = 0; i < max; i++)
            {
                Thread.Sleep(10);
                ShowProgress(i);

            }
        }
     
        private void ShowProgress(int i)
        {
            //this is hit if a background thread calls ShowProgress()
            if (lblOutput.InvokeRequired == true)
            {
                var del = new ShowProcessDelegate(ShowProgress);
                this.BeginInvoke(del,new object[]{i});
            }
            else
            {
                lblOutput.Text = i.ToString();
                progressBar1.Value = i;
            }
        }




    }
}
