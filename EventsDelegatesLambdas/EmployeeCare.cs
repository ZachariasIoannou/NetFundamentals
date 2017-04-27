using System;
namespace EventsDelegatesLambdas
{
    class EmployeeCare
    {
        public EmployeeCare(Hr hr)
        {
            hr.NewEmployee += GetEmployeeDetails;

        }

        private void GetEmployeeDetails(object sender, EmployeeEventArgs e)
        {
            Console.WriteLine("event sender: " + sender);
            Console.WriteLine("event details: " + e.Name + " " + e.Sex + " " + e.Age);   
        }
    }
}
