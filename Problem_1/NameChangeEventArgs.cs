class NameChangeEventArgs : EventArgs
{
    public string name { get; }

    public NameChangeEventArgs(string name)
    {
        this.name = name;
    }
}
   
