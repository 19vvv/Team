using System;
public class Vehicle{
    public string Name {get; set;}
    private int Speed {get; set;}
    public static int TotalVehicles;

    public Vehicle(string Name, int Speed){
        this.Name = Name;
        this.Speed = Speed;
        TotalVehicles++;
    }

    public virtual void Start(){
        Console.WriteLine("Vehicle is starting!");

    }

    public virtual void  Accelerate(int increment){
        Console.WriteLine("New Speed " +Speed);

    }

    public int GetSpeed(){
        return Speed;
    }
}