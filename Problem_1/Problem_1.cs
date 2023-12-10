class Problem_1
{
    static void Main(string[] args)
    {
        Dispatcher dispatcher = new Dispatcher();
        Handler handler = new Handler();
        dispatcher.NameChange += handler.OnDispatcherNameChange;

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "end") break;

            dispatcher.Name = input;
        }
    }
}