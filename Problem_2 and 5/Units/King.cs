namespace Problem_2.Units
{
    internal class King : IUnit
    {
        public string Name { get; }

        public King(string name)
        {
            Name = name;
        }

        public EventHandler underAttack;

        public void OnUnderAttack()
        {
            Console.WriteLine($"King {Name} is under attack!");
            if ( underAttack != null ) this.underAttack(this, EventArgs.Empty);
        }
    }
}
