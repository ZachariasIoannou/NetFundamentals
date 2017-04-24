using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesLambdas
{
    public delegate int BizRulesDelegate(int x, int y);
    class Program
    {
      
        static void Main(string[] args)
        {
            BizRulesDelegate addDel = (x, y) => x + y;
            BizRulesDelegate MultiplyDel = (x, y) => x * y;
            
            var data = new ProcessData();

            data.Process(2,3,addDel );
            data.Process(2, 3, MultiplyDel);

            Action<int, int> myAction = (x, y) => Console.Write(x + y);
            Action<int, int> myMultiplyAction = (x, y) => Console.Write(x * y);

            data.ProcessAction(2, 3, myAction);
            data.ProcessAction(2,3,myMultiplyAction);

            var worker = new Worker();

            worker.WorkPerformed += delegate(object sender, WorkPerformedEventArgs e)
            {
                Console.WriteLine(e.Hours + " " + e.WorkType);
            };

            worker.WorkComplete += delegate(object sender, EventArgs e)
            {
                Console.WriteLine("Work is Complete");
            };

            worker.DoWork(5, WorkType.GoToMeetings);

            Console.Read();
        }
    }
}
