using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesLambdas
{
    class Program
    {
      
        static void Main(string[] args)
        {
            var worker = new Worker();
            worker.WorkPerformed += Worker_WorkPerformed1;
            worker.WorkComplete += Worker_WorkComplete;
            worker.DoWork(5, WorkType.GoToMeetings);
            Console.Read();
        }

        private static void Worker_WorkComplete(object sender, EventArgs e)
        {
            Console.WriteLine("Work is done");
        }

        private static void Worker_WorkPerformed1(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine(e.Hours + " " + e.WorkType);
        }

    }
}
