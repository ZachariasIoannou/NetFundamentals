﻿using System;
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
    public partial class AsyncBad : Form
    {
        delegate void UpdateProgressDelegate(int val);
        public AsyncBad()
        {
            InitializeComponent();
        }

        //public static void Main()
        //{
        //    Application.Run( new AsyncBad());
        //}

        private void StartButton_Click(object sender, EventArgs e)
        {
            var progDel = new UpdateProgressDelegate(StartProcess);
            progDel.BeginInvoke(100, null, null);
            MessageBox.Show(@"Done with operation");
        }

        private void StartProcess(int max)
        {
            this.progressBar1.Maximum = max;
            for (int i = 0; i < max; i++)
            {
                Thread.Sleep(10);
                lblOutput.Text = i.ToString();
                this.progressBar1.Value = i;

            }
        }

        private void AsyncBad_Load(object sender, EventArgs e)
        {

        }
    }
}
