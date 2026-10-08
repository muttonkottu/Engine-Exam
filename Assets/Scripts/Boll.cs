using UnityEngine;

public class Boll : Bullet
{
    public override void Damage()
    {
        print("Did teeny tiny explosion!");
    }

    public override void PrintEnemyDefense()
    {
        print("20");
    }
}
