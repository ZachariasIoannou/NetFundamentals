using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDelegatesEventsArgs
{
    //public delegate int WorkPerformedEventHandler(object sender, WorkPerformedEventArgs e);
    class Worker
    {
        //public event WorkPerformedEventHandler WorkPerformed;
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i + 1, workType);
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            //var del = WorkPerformed as WorkPerformedEventHandler;
            WorkPerformed?.Invoke(this, new WorkPerformedEventArgs(hours, WorkType.Brake));
        }
        protected virtual void OnWorkCompleted()
        {
            WorkCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
