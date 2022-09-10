/*
UML:
name:string
description:string
itemList:Items[]

metodos:
attack()
defend()
addItem()

Crc
atacar
defender

Colaboraciones:
Items



*/

namespace Library;
using System.Collections;

public class Dwarves
{

    public string Name { get; set; }
    public string Description { get; set; }

    public ArrayList ItemsList { get; set; }

    public Dwarves(string name, string description)
    {
        this.Name = name;

        this.Description = description;

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

