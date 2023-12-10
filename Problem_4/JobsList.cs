namespace Problem_4
{
    internal class JobsList : List<Job>
    {
        public void whenJobIsDone(object sender, JobIsDoneEventArgs args)
        {
            args.Job.isJobDone -= this.whenJobIsDone;
            this.Remove(args.Job);
        }
    }
}
