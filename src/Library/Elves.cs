/*
UML:
name:string
gender:string
health:double
stammina:double
ItemList:Items[]

Metodos:
addItem()

CRC:
comer
crear objetos magicos
ayudar

Colaboraciones:
Items
Wizards
Dwarves

*/
namespace Library;
using System.Collections;
public class Elves
{

    public string name { get; set; }
    public string Gender { get; set; }
    public double Stammina { get; set; }
    public double Health { get; set; }


    public ArrayList ItemsList { get; set; }


    public Elves(string name, string gender, double stammina, double health)
    {
        this.name = name;
        this.Gender = gender;
        this.Health = health;
        this.Stammina = stammina;

    }


    public void addItem(Items item)
    {

        ItemsList.Add(item);

    }

}

