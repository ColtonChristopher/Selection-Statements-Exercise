using Internal;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See if you can guess the correct number?");

            var random = new Random();
            var favNumber = random.Next(1, 1000);

            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if(userInput > random)
            {
                Console.WriteLine("Your guess is too high! Sorry");
            }
            else if(userInput < random)
            {
                Console.WriteLine("Your guess is too low! Sorry");
            }
            else
            {
                Console.WriteLine("Nevermind")
            }

        }
    }
}
