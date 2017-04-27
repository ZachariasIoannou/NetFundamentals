using System;
using System.Runtime.InteropServices;

namespace EventsDelegatesLambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            Hr hr = new Hr();
            EmployeeCare employeeCare = new EmployeeCare(hr);
            hr.AddEmployee("zach", "Male", 19);
            Console.ReadLine();
        }
    }
}
