using Problem_4.Employees;
namespace Problem_4
{
    internal class Job
    {
        public string nameOfJob {  get; set; }
        public int hoursOfWorkRequired { get; set; }
        public IEmployee employee { get; set; }

        public Job(string nameOfJob, int hoursOfWorkRequired, IEmployee employee)
        {
            this.nameOfJob = nameOfJob;
            this.hoursOfWorkRequired = hoursOfWorkRequired;
            this.employee = employee;
        }

        public void update()
        {
            hoursOfWorkRequired -= employee.HoursPerWeek;

            if (hoursOfWorkRequired <= 0) jobEvent();
        }

        public EventHandler<JobIsDoneEventArgs> isJobDone;

        private void jobEvent() 
        {
            Console.WriteLine($"Job {nameOfJob} done!");

            if (isJobDone != null)
            { 
                isJobDone(this, new JobIsDoneEventArgs(this)); 
            }
        } 

        public override string? ToString()
        {
            return $"Job: {nameOfJob} Hours Remaining: {hoursOfWorkRequired}";
        }
    }
}
