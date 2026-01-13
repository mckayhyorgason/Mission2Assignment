namespace DiceRolling;

public class DiceRoll
{
    //Method for rolling the dice
    public int[] Roll(int numRoll)
    {
        //importing random library
        Random rand = new Random();
        //setting the array for dice totals
        int[] diceTotals = new int[13];

        //loop to roll the dice the amount given by user
        for (int i = 0; i < numRoll; i++)
        {
            int die1 = rand.Next(1, 7);
            int die2 = rand.Next(1, 7);

            //both die added together
            int rollTotal = die1 + die2;
            
            //one is added to the spot in the array equal to the dice total
            diceTotals[rollTotal]++;
        }
        //returns the full array
        return (diceTotals);
    }
    
    public void Calculate(int numRoll, int[] diceTotals)
    {
        double[] dicePercentage = new double[13];
        
        //loop that calculates the percentage of each number rolled and prints an * for every percent
        for (int i = 2; i < 13; i++)
        {
            System.Console.WriteLine();
            dicePercentage[i] = ((double)diceTotals[i] / numRoll) * 100;
            //prints the number spot in the array
            System.Console.Write($"{i}: ");
            //prints an * for every percent
            for (int j = 0; j < dicePercentage[i]; j++) 
            {
                System.Console.Write($"*");
            }
        }
    }
}