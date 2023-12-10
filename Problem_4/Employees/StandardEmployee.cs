namespace Problem_4.Employees
{
    internal class StandardEmployee : IEmployee
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private int hoursPerWeek;
        public int HoursPerWeek { get { return hoursPerWeek; } set { hoursPerWeek = value; } }

        public StandardEmployee(string name)
        {
            Name = name;
            HoursPerWeek = 40;
        }
    }
}
