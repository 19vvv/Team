/*using System;

class Student{
    public string Name {get; set;}
    public int Age {get; set;}
    public double Grade {get; set;}
    
    public Student(string name, int age, double grade)
  {
    Name = name;
    Age = age;
    Grade = grade; 
  }


  public void DisplayInfo()
  {
    Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
  }
}

public class Program{
    public static void Main()
    {
        Student Futoon = new Student("Futoon",23,100);
        Student Nora = new Student("Nora",23,100);
        Student Danah = new Student("Danah",23,100);
        
        Futoon.DisplayInfo();
        Nora.DisplayInfo();
        Danah.DisplayInfo();

    }
}*/



/*
using System;
public class Program{
    public static void Main(String[]args){
    int[] array = {1,2,3,4,5};
    foreach( int arr in array)
    Console.WriteLine(arr);

}}
*/

/*
using System;
public class Program{
    public void SquareNumber(){
        Console.WriteLine("Enter Number");
        int num = int.Parse(Console.ReadLine());
        double resultnum = num*num;
        SquareNumber();
        //OR
        Console.WriteLine(resultnum);
    }

}*/



/*
using System;
public class Program{
    public static void Main(String[]args){
        Console.WriteLine("input a number between 1 and 7");
        int x = int.Parse(Console.ReadLine());
        int Week = 1;
        switch(Week){

            case 1:
            Console.WriteLine("Sunday");
            break;
            case 2:
            Console.WriteLine("Monday");
            break;
            case 3:
            Console.WriteLine("Tuesday");
            break;
            case 4:
            Console.WriteLine("Wednesday");
            break;
            case 5:
            Console.WriteLine("Thursday");
            break;
            case 6:
            Console.WriteLine("Friday");
            break;
            case 7:
            Console.WriteLine("Satudray");
            break;
            default:
            break;

        }
        }
}*/



/*
using System;
public class Program{
    public static void Main(String[]args){
        Console.WriteLine("Enter Your Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Your Age");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Your hourly wage");
        double hourlyWage = int.Parse(Console.ReadLine());

        Console.WriteLine($"Hi, my name is {name}. I am {age} years old and earn {hourlyWage} per hour.");

    }
}
*/


/*
using System;
class Program{
    public static void Main(String[]args){
        Console.WriteLine("Input a Number");
        int InputUser = int.Parse(Console.ReadLine());
        if (InputUser>=0){
            Console.WriteLine($"{InputUser} is Positive");
        }
        else if(InputUser<=0){
            Console.WriteLine($"{InputUser} is Negative");

        }
        else if(InputUser == 0){
            Console.WriteLine($"{InputUser} is Zero");

        }
        else{
            Console.WriteLine("Input Number !");

        }

    }
}*/
