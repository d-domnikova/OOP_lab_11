using Problem_4;
using Problem_4.Employees;

class Workspace
{
    static void Main()
    {
        JobsList jobs = new JobsList();
        List<IEmployee> employees = new List<IEmployee>();

        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            if (input[0].ToLower() == "end") break;

            switch (input[0].ToLower())
            {
                case "job":
                    IEmployee employeeForJob = employees.Find(e => e.Name.Equals(input[3]));
                    Job job = new Job(input[1], int.Parse(input[2]), employeeForJob);
                    job.isJobDone += jobs.whenJobIsDone;
                    jobs.Add(job);
                    break;

                case "standardemployee":
                    StandardEmployee standardEmployee = new StandardEmployee(input[1]);
                    employees.Add(standardEmployee);
                    break;

                case "parttimeemployee":
                    PartTimeEmployee partTimeEmployee = new PartTimeEmployee(input[1]);
                    employees.Add(partTimeEmployee);
                    break;

                case "pass": //pass week
                    foreach (Job j in jobs.ToArray()) j.update();
                    break;

                case "status":
                    foreach (Job j in jobs) Console.WriteLine(j);
                    break;
            }
        }
    }
}