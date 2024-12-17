/*using System;
public class Program{
    public static void Main(String[]args){
    string name = "Futoon";
    Console.WriteLine(name);
}}*/

/*using System;
public class Calculate{
    public static void Main(String[]args){
        int num1 = 2;
        int num2 = 4;
        int result = num1*num2;
        Console.WriteLine(result);
    }
}*/

/*using System;
public class Third{
    public static void Main(String[]args){
        int[] array = {1,2,3,4,5};


        foreach (int arr in array)
        {
            int sum=0;
            sum +=arr;
            Console.WriteLine(sum/5);
        }
}
}*/

/*using System;
public class Third{
    public static void Main(String[]args){
        int[] array = {1,2,3,4,5};


        foreach (int arr in array)
        {
            int sum=0;
            sum +=arr;
            
            sum = [0]+[1]+[2]+[3]+[4];

            Console.WriteLine(sum);
        }
}
}*/

/*using System;
public class Forth{
public static void Main(String[]args){
    int num1=int.Parse(Console.ReadLine());
    int num2=int.Parse(Console.ReadLine());
    if(num1>num2){
        Console.WriteLine($"{num1} is the larger");
    }
    else if(num2>num1){
        Console.WriteLine($"{num2} is the larger");
       
    }
    else{
        Console.WriteLine("Equal");
    }
}}
*/
/*using System;
public class Fifth{
public static void Main(String[]args){
    Console.WriteLine("Enter Your Grade: A, B, C, D, F");
    string grade = Console.ReadLine();
    switch(grade)
    {
        case "A":
        Console.WriteLine("Excellent");
        break;
        case "B":
        Console.WriteLine("Very Good");
        break;        
        case "C":
        Console.WriteLine("Good");
        break;
        case "D":
        Console.WriteLine("Needs Improvement");
        break;
        case "F":
        Console.WriteLine("Fail");
        break;
        
        default:
        break;
    }
}
}*/

/*using System;
class Movie{
    public string Title{get; set;}
    public string Director;
    public double Duration;

    public Movie(string title, string director, double duration){
        Title=title;
        Director=director;
        Duration=duration;
    }
public void PrintDetails()
    {
    Console.WriteLine($"Title: {Title}, Director: {Director}, Duration: {Duration} minutes.");
    }

public class program{
public static void Main(String[]args){
    Movie Disney1 = new Movie("Moana","Disney",120);
    Movie Disney2 = new Movie("Lion King","Disney",60);
    Movie Disney3 = new Movie("Totoro","Gibli",120);



    Disney1.PrintDetails();
    Disney2.PrintDetails();
    Disney3.PrintDetails();
    }


}}*/