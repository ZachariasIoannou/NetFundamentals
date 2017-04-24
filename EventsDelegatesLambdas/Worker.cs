using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesLambdas
{
    public delegate int WorkPerformedHandler(int hours, WorkType workType);

    public class Worker
    {
        public event WorkPerformedHandler WorkPerformed;
        public event EventHandler WorkComplete;

        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
               OnWorkPerformed(i + 1, workType);
            }
            OnWorkComplete();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType worktype)
        {
            var del = WorkPerformed as WorkPerformedHandler;
            if (del != null)
            {
                del(hours,worktype);
            }
        }
        protected virtual void OnWorkComplete()
        {
            var del = WorkComplete as EventHandler;
            if (del != null)
            {
                del(this,EventArgs.Empty);
            }
        }
    }


}
