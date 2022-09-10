//UML:
//name:string
//health:double
//ItemList:Items[]
//Metodos
//attack()
//defend()
//addItem()


//CRC
//dominio de la magia
//capacidad de atacar
//capacidad de defender
//
//Colaboraciones
//Items
using System;
using System.Collections;

namespace Library;


public class Wizards
{

    public string Name { get; set; }
    public double Health { get; set; }

    public ArrayList ItemsList { get; set; }

    public Wizards(string name, double health, ArrayList items)
    {

        this.Name = name;
        this.Health = health;
        this.ItemsList = items;

    }

    public void addItem(Items item)
    {

        ItemsList.Add(item);

    }

    
    public void Attack()
    {
        //
    }

    public void Defend()
    {
        //


    }


}