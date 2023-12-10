namespace Problem_4.Employees
{
    internal class PartTimeEmployee : IEmployee
    {
        private string name;
        public string Name { get { return this.name; } set { this.name = value; } }

        private int hoursPerWeek;
        public int HoursPerWeek { get { return this.hoursPerWeek; } set { this.hoursPerWeek = value; } }

        public PartTimeEmployee(string name)
        {
            Name = name;
            HoursPerWeek = 20;
        }
    }
}
