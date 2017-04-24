using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesLambdas
{
    class Program
    {
        public delegate void WorkPerformedDelegate(int hours, WorkType workType);

        static void Main(string[] args)
        {
            WorkPerformedDelegate del1 = new WorkPerformedDelegate(WorkPerformed1);
            WorkPerformedDelegate del2 = new WorkPerformedDelegate(WorkPerformed2);
            WorkPerformedDelegate del3 = new WorkPerformedDelegate(WorkPerformed3);

            //doWork(del1);
            //del2(4, WorkType.GenerateReports);

            del1 += del2 + del3;
            
            del1(2, WorkType.Eating);

            Console.Read();
        }

        static void doWork(WorkPerformedDelegate del)
        {
            del(5, WorkType.Eating);
        }

        static void WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed1 called worked for: {0} hours {1}",hours, workType);
        }

        static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed2 called worked for: {0} hours {1}", hours, workType);
        }

        static void WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed3 called worked for: {0} hours {1}", hours, workType);
        }

        public enum WorkType
        {
            GoToMeetings,
            Golf,
            Eating,
            GenerateReports
        }
    }
}
