
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

        if (ageToInt < 1 || ageToInt > 100)
        {
            Console.WriteLine("ENTER SCORE BETWEEN 1-100");
            return;
        }
        else
        {
            switch (ageToInt)
            {
                case (>= 90):
                    Console.WriteLine("SUPER");
                    break;
                case (>= 80):
                    Console.WriteLine("GOOD");
                    break;
                case (>= 50):
                    Console.WriteLine("NO BED");
                    break;

                default:
                    Console.WriteLine("BED");
                    break;
            }

        }
            

       
               

    
    }

}