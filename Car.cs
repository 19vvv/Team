using System;
public class Car : Vehicle
{
    public Car(string Name, int Speed) : base(Name, Speed)
    {
    }

    public int FuelEfficiency;

    public override void Start(){
        Console.WriteLine("The car is starting with a smooth engine sound!" );

    }
}