using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesLambdas
{
    //public delegate void EmployeeEventHandler(object sender, EmployeeEventArgs e);

    public class Hr
    {
        //public event EmployeeEventHandler NewEmployee;
        public event EventHandler<EmployeeEventArgs> NewEmployee;

        protected virtual void OnNewEmployee(EmployeeEventArgs e)
        {
            NewEmployee?.Invoke(this, e);
        }

        public void AddEmployee(string name, string sex, int age)
        {
            EmployeeEventArgs e = new EmployeeEventArgs(name, sex,age);
            OnNewEmployee(e);
        }
    }
}
