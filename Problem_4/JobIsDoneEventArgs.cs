using Problem_4;

class JobIsDoneEventArgs : EventArgs
{
    public Job Job { get; }

    public JobIsDoneEventArgs(Job job)
    {
        this.Job = job;
    }
}
   
