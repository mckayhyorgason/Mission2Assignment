// See https://aka.ms/new-console-template for more information
using DiceRolling;

public class Program
{
    public static void Main(string[] args)
    {
        DiceRoll dr = new DiceRoll();
        
        int roll_count = 0;
        
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many times do you want to roll the dice?");
        roll_count = int.Parse(System.Console.ReadLine());
        
        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine($"Total number of rolls = {roll_count}.");
        
        int[] results = dr.Roll(roll_count);

        dr.Calculate(roll_count, results);
        
        System.Console.WriteLine("\n\nThank you for using the dice throwing simulator. Goodbye!");
    }
}