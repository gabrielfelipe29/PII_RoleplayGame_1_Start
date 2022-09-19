namespace Library;
using System;


public class Spell: IItems
{

    public string Name { get; set; }
    public double Attack { get; set; }
    public double Defense { get; set; }
    public string Description { get; set; }


    public double GetAttackValue(Spell spell)
    {
        return this.Attack;
    }
    public double GetDefenseValue()
    {
        return this.Defense;
    }

}
