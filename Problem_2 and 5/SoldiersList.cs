using Problem_2.Units;
using System;

namespace Problem_2_and_5
{
    internal class SoldiersList : List<Soldiers>
    {
       public void lackOfHits(object sender, SoldiersLackOfHits args)
        {
            args.soldiers.isDefeated -= this.lackOfHits;
            this.Remove(args.soldiers);
        }
    }
}
