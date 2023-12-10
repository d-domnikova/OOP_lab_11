namespace Problem_2.Units
{
    internal class RoyalGuard : Soldiers
    {
        public string Name { get; }
        public const int Hits = 3; //problem 5

        public RoyalGuard(string name) : base (name, Hits)
        {
            Name = name;
        }

        public override void kingIsUnderAttack(object source, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {Name} is defending!");
        }
    }
}
