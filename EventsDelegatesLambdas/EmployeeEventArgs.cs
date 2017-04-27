namespace EventsDelegatesLambdas
{
    public class EmployeeEventArgs
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        public EmployeeEventArgs(string name, string sex, int age)
        {
            Name = name;
            Sex = sex;
            Age = age;
        }
    }
}
