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
            WorkPerformedDelegate del1 = new WorkPerformedDelegate(WorkPerformed1);
            WorkPerformedDelegate del2 = new WorkPerformedDelegate(WorkPerformed2);
            WorkPerformedDelegate del3 = new WorkPerformedDelegate(WorkPerformed3);

            //doWork(del1);
            //del2(4, WorkType.GenerateReports);

            del1 += del2 + del3;
            
            int resultedHours = del1(2, WorkType.Eating);

            Console.WriteLine(resultedHours);

            Console.Read();
        }

        static void doWork(WorkPerformedDelegate del)
        {
            del(5, WorkType.Eating);
        }

        static int WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed1 called worked for: {0} hours {1}",hours, workType);
            return hours + 1;
        }

        static int WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed2 called worked for: {0} hours {1}", hours, workType);
            return hours + 2;
        }

        static int WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed3 called worked for: {0} hours {1}", hours, workType);
            return hours + 3;
        }
        
    }
}
