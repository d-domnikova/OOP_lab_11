using Problem_2.Units;
using Problem_2_and_5;

class Workspace
{
    static void Main()
    {
        SoldiersList soldiers = new SoldiersList();

        string kingsName = Console.ReadLine();
        King king = new King(kingsName);

        string[] input = Console.ReadLine().Split(' ');
        foreach (string royalGuardsName in input)
        {
            if (royalGuardsName != kingsName)
            {
                RoyalGuard royalGuard = new RoyalGuard(royalGuardsName);
                soldiers.Add(royalGuard);
                king.underAttack += royalGuard.kingIsUnderAttack;

            }
        }

        input = Console.ReadLine().Split(' ');
        foreach (string footmansName in input)
        {
            if (footmansName != kingsName)
            {
                Footman footman = new Footman(footmansName);
                soldiers.Add(footman);
                king.underAttack += footman.kingIsUnderAttack;
            }
        }

        while (input[0].ToLower() != "end")
        {
            input = Console.ReadLine().Split(' ');
            switch (input[0].ToLower())
            {
                case "kill": //змінено з урахуванням завдання в Problem 5
                    Soldiers soldier = soldiers.Find(s => s.Name == input[1]);
                    soldier.SoldierIsAttacked();
                    if(soldier.Hits <= 0) king.underAttack -= soldier.kingIsUnderAttack;
                    break;
                case "attack":
                    king.OnUnderAttack();
                    break;
            }
        }
    }
}