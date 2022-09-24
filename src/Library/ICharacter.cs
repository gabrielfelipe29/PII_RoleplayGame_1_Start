namespace Library;
using System;
public interface ICharacter
{
    public string Name { get; set; }
    public string Description { get; set; } 
    public double InitialHealth {get;set;}
    public double ActualHealth {get;set;}
    public Items AttackItem {get;set;}
    public Items DefenseItem {get;set;}
public void Attack( ICharacter otherCharacter){
    //
}
public void Cure(){
    //
}
}
