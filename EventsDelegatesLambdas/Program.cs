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
            worker.WorkPerformed += Worker_WorkPerformed;
            worker.WorkComplete += Worker_WorkComplete1;
            worker.DoWork(5, WorkType.GoToMeetings);
            Console.Read();
        }

        //private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        //{
        //    Console.WriteLine(e.Hours + " " + e.WorkType);
        //}

        //private static void Worker_WorkComplete1(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Work is Complete");
        //}



    }
}
