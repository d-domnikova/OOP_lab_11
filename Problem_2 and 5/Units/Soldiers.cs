using Problem_2_and_5;

namespace Problem_2.Units
{
    internal abstract class Soldiers : IUnit
    {
        public string Name { get; }
        public int Hits;
        protected Soldiers(string name, int hits)
        {
            Name = name;
            Hits = hits;    
        }

        public abstract void kingIsUnderAttack(object source, EventArgs args);

        public EventHandler<SoldiersLackOfHits> isDefeated; //звідси і все, що нижче - для завдання Problem 5
        public void SoldierIsAttacked()
        {
            Hits--;
            if (Hits <= 0) SoldierIsDefeated();
        }

        public void SoldierIsDefeated()
        {
            if (isDefeated != null)
            {
                this.isDefeated(this, new SoldiersLackOfHits(this));
            }
        }
    }
}
