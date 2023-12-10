namespace Problem_2.Units
{
    internal class Footman : Soldiers
    {
        public string Name { get; }
        public const int Hits = 2; //problem 5

        public Footman(string name) : base (name, Hits)
        {
            Name = name;
        }

        public override void kingIsUnderAttack(object source, EventArgs args)
        {
            Console.WriteLine($"Footman {Name} is panicking!");
        }
    }
}
