namespace Library;
using System;
using System.Collections.Generic;



public class BookOfSpells
{

    public string Name { get; set; }
    public List<Spell> listOfSpells = new List<Spell>();
    

    public BookOfSpells(string name)
    {
        this.Name = name;
    }

}