
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        string output = "ENTER SCORE";
        Console.WriteLine(output);

        string score = Console.ReadLine();
        double ageToInt;

        if (!double.TryParse(score, out ageToInt))
        {
            Console.WriteLine($"ENTER NUMBER (0,0)!! NOT {score}");
            return;
        }


   
        if (ageToInt >= 90 && ageToInt <= 100) Console.WriteLine("SUPER");

        else 
        if (ageToInt >= 70 &&  ageToInt <= 89 ) Console.WriteLine("GOOD");   
        
        else Console.WriteLine("Not SUPER");
               
            


    
    }

}