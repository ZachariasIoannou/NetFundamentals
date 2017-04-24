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
        //    WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
        //    WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
        //    WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);

        //    //doWork(del1);
        //    //del2(4, WorkType.GenerateReports);

        //    del1 += del2 + del3;
            
        //    int resultedHours = del1(2, WorkType.Eating);

        //    Console.WriteLine(resultedHours);
            var worker = new Worker();
            worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(Worker_WorkPerformed);
            worker.WorkComplete += new EventHandler(Work_Completed);
            worker.DoWork(5, WorkType.GoToMeetings);
            Console.Read();
        }

        private static void Work_Completed(object sender, EventArgs e)
        {
            Console.WriteLine("Work is done");   
        }
        
        private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine(e.Hours + " " + e.WorkType);
        }

        //static void doWork(WorkPerformedHandler del)
        //{
        //    del(5, WorkType.Eating);
        //}

        //static int WorkPerformed1(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed1 called worked for: {0} hours {1}",hours, workType);
        //    return hours + 1;
        //}

        //static int WorkPerformed2(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed2 called worked for: {0} hours {1}", hours, workType);
        //    return hours + 2;
        //}

        //static int WorkPerformed3(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed3 called worked for: {0} hours {1}", hours, workType);
        //    return hours + 3;
        //}

    }
}
