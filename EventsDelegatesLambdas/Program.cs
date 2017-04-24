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
