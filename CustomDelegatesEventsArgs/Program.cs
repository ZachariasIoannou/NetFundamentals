using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CustomDelegatesEventsArgs
{
    //public delegate void WorkPerformedHanlder(int hours, WorkType workType);

    class Program
    {

        static void Main(string[] args)
        {
            var worker = new Worker();
            worker.WorkPerformed += WorkPerformed;
            worker.WorkCompleted += Worker_WorkCompleted;     

            worker.DoWork(8,WorkType.Brake);

            Console.Read();
        }

        private static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Worker is done");
        }

        static void WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine("Hours woerked"  + e.Hours + " " + e.WorkType);
        }
        
    }

    public enum WorkType
        {
            GoToMeetings,
            Golf,
            Brake,
        }
    }

