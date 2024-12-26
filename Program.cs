using System;
public class Program{
    public static void Main(){
        Vehicle[] veh = new Vehicle [3];
        Car C = new Car("10 mph");
        Motorcycle M = new Motorcycle("40 mph");
        Truck T = new Truck("15 mph");
        Program p = new Program()

        veh[0] = C;
        veh[1] = M;
        veh[2] = T;

        veh[0].Accelerate(10);
        veh[1].Accelerate(40);
        veh[2].Accelerate(15);
        


    }

}