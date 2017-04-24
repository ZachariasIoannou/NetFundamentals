using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesLambdas
{

    public delegate int WorkPerformedDelegate(int hours, WorkType workType);

    public class Worker
    {
        public event WorkPerformedDelegate WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {
            
        }
    }
}
