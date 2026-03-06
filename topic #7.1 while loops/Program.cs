namespace topic__7._1_while_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randNum;
            int points = 3;
            int flip;
            string choice, result;
           


            while (points > 0)
            {
                Console.WriteLine("Press enter to play the game");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You have " + points + " points");
                Console.WriteLine("im going to flip a coin, make your decision");
                Console.Write("Choose 'heads', 'tails, or 'quit': ");
                choice = Console.ReadLine().ToLower();

                if (choice == "quit")
                {
                    Console.WriteLine("Thanks for playing! You finished with " + points + " Points");
                    return;
                }

                if (choice != "heads" && choice != "tails")
                {
                    Console.WriteLine("Invalid choice. Please choose heads, tails or quit");
                    continue;
                }

                randNum = generator.Next(2);
                result = randNum == 0 ? "heads" : "tails";
                Console.WriteLine("the coin landed on " + result);

                if (choice == result)
                {
                    points++;
                    Console.WriteLine("You guessed correctly! +1 point.");
                }
                else
                {
                    points--;
                    Console.WriteLine("Wrong guess. -1 point.");
                }
            }

            Console.WriteLine("You ran out of points. Game over!");




        }
    }
}
