/*
UML:
nombre:string
daño:double
heal:double
capacidades:string

metodos:
Ninguno

CRC


Colaboraciones
Wizards
Elves
Dwarves

*/
namespace Library;
using System;


public class Items
{

    public string Name { get; set; }
    public double Damage { get; set; }
    public double Healing { get; set; }
    public string Description { get; set; }


    public Items(string name, double damage, double healing, string description)
    {
        this.Name = name;
        this.Damage = damage;
        this.Healing = healing;
        this.Description = description;

    }

}

