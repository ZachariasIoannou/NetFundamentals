using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDelegatesEventsArgs
{
    public delegate void WorkPerformedHanlder(int hours, WorkType workType);

    class Program
    {

        static void Main(string[] args)
        {
            WorkPerformedHanlder del1 = new WorkPerformedHanlder(WorkPerformed1);
            WorkPerformedHanlder del2 = new WorkPerformedHanlder(WorkPerformed2);
            WorkPerformedHanlder del3 = new WorkPerformedHanlder(WorkPerformed3);

            del1(5, WorkType.Golf);
            del2(15, WorkType.Brake);

            del1 += del2 + del3;

            DoWork(del1);

            Console.Read();
        }

        static void DoWork(WorkPerformedHanlder del)
        {
            del(5,WorkType.Brake);
        }

        static void WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed1 called " + hours.ToString());
        }

        static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed2 called " + hours.ToString());
        }
        static void WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed3 called " + hours.ToString());
        }

    }

    public enum WorkType
        {
            GoToMeetings,
            Golf,
            Brake,
        }
    }

