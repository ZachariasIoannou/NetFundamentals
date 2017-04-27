using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomDelegatesEventsArgs
{
    public delegate int BizRulesDelegate(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            BizRulesDelegate addDel = (x, y) => x + y;
            BizRulesDelegate multiplyDel = (x, y) => x * y;
            var data = new ProcessData();
            data.Process(2, 3, addDel);
            data.Process(2, 3, multiplyDel);

            Action<int, int> myAction = (x, y) => Console.Write(x + y);
            Action<int, int> myMultuiplyAction = (x, y) => Console.Write(x + y);

            data.ProcessAction(2,3,myAction);
            data.ProcessAction(2, 3, myMultuiplyAction);

            var worker = new Worker();
            worker.WorkPerformed += (s,e) => Console.WriteLine("Hours woerked" + e.Hours + " " + e.WorkType); 
            worker.WorkCompleted += (s, e) =>
            {
                Console.WriteLine("Worker is done");
            };

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

