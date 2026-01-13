namespace DiceRolling;

public class DiceRoll
{
    
    public int[] Roll(int numRoll)
    {
        Random rand = new Random();
        int[] diceTotals = new int[13];

        for (int i = 0; i < numRoll; i++)
        {
            int die1 = rand.Next(1, 7);
            int die2 = rand.Next(1, 7);

            int rollTotal = die1 + die2;
            
            diceTotals[rollTotal]++;
        }
        
        return (diceTotals);
    }
    
    public void Calculate(int numRoll, int[] diceTotals)
    {
        double[] dicePercentage = new double[13];
        
        for (int i = 2; i < 13; i++)
        {
            System.Console.WriteLine();
            dicePercentage[i] = ((double)diceTotals[i] / numRoll) * 100;
            System.Console.Write($"{i}: ");
            for (int j = 0; j < dicePercentage[i]; j++) 
            {
                System.Console.Write($"*");
            }
        }
    }
}