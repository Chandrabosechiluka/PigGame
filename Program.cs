namespace PigGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalScore = 0;
            Random random = new Random();

            Console.WriteLine("Welcome to the Game of Pig!");
            while (totalScore < 20)
            {
                int turnScore = 0;
                bool continueTurn = true;

                Console.WriteLine($"\nYour current total score: {totalScore}");

                while (continueTurn)
                {
                    Console.WriteLine($"Turn score: {turnScore}");
                    Console.Write("Enter 'r' to roll or 'h' to hold: ");
                    char choice = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (choice == 'r')
                    {
                        int roll = random.Next(1, 7); 
                        Console.WriteLine($"You rolled: {roll}");

                        if (roll == 1)
                        {
                            Console.WriteLine("You rolled a 1! You lose all points this turn.");
                            turnScore = 0;
                            continueTurn = false; 
                        }
                        else
                        {
                            turnScore += roll;
                            Console.WriteLine($"Turn score is now: {turnScore}");
                        }
                    }
                    else if (choice == 'h')
                    {
                        totalScore += turnScore;
                        Console.WriteLine($"You held! Your total score is now: {totalScore}");
                        continueTurn = false; 
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter 'r' to roll or 'h' to hold.");
                    }
                }

                if (totalScore >= 20)
                {
                    Console.WriteLine("\nCongratulations! You've won the game with a score of 20 or more!");
                    break;
                }
            }
        }
    }
}

