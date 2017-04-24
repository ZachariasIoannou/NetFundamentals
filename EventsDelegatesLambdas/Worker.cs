using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesLambdas
{
    //public delegate int WorkPerformedHandler(object sender, EventArgs e);

    public class Worker
    {

        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkComplete;

        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
                System.Threading.Thread.Sleep(500);
                OnWorkPerformed(i + 1, workType);
            }
            OnWorkComplete();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            WorkPerformed?.Invoke(this, new WorkPerformedEventArgs(hours, workType));
        }

        protected virtual void OnWorkComplete()
        {
            WorkComplete?.Invoke(this, EventArgs.Empty);
        }
    }
}