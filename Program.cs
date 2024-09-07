namespace CodeReviews.MathGame.ZackTzeng;

class Program
{
    static List<string> histories = [];
    static bool shouldContinue = true;
    static void Main(string[] args)
    {
        while (shouldContinue)
        {
            Console.WriteLine("1. Play + game");
            Console.WriteLine("2. Play - game");
            Console.WriteLine("3. Play * game");
            Console.WriteLine("4. Play / game");
            Console.WriteLine("5. Show history");
            Console.WriteLine("6. Stop playing");

            Console.Write("Please choose an option: ");
            int selectedOption = Convert.ToInt32(Console.ReadLine());
            switch (selectedOption)
            {
                case 1:
                    generatePlusGame();
                    break;
                case 2:
                    generateMinusGame();
                    break;
                case 3:
                    generateMultiplyGame();
                    break;
                case 4:
                    generateDivideGame();
                    break;
                case 5:
                    showHistory();
                    break;
                case 6:
                    stopPlaying();
                    break;
                default:
                    Console.WriteLine("Please select from 1 to 6");
                    break;
            }
        }
    }

    static void generatePlusGame()
    {
        int leftOperand = generateRandomInteger(0, 10);
        int rightOperand = generateRandomInteger(0, 10);
        int sum = leftOperand + rightOperand;
        Console.WriteLine("Please enter the answer:");
        Console.Write($"{leftOperand} + {rightOperand} = ");
        int attemptedAnswer = Convert.ToInt32(Console.ReadLine());
        if (attemptedAnswer == sum)
        {
            Console.WriteLine("You got it right!");
            histories.Add($"{leftOperand} + {rightOperand} = {attemptedAnswer} (Correct!)");
        }
        else
        {
            Console.WriteLine($"You got it Wrong. The answer is {sum}");
            histories.Add($"{leftOperand} + {rightOperand} = {attemptedAnswer} (Incorrect...)");
        }
    }

    static void generateMinusGame()
    {
        int leftOperand = generateRandomInteger(0, 10);
        int rightOperand = generateRandomInteger(0, 10);
        int difference = leftOperand - rightOperand;
        Console.WriteLine("Please enter the answer:");
        Console.Write($"{leftOperand} - {rightOperand} = ");
        int attemptedAnswer = Convert.ToInt32(Console.ReadLine());
        if (attemptedAnswer == difference)
        {
            Console.WriteLine("You got it right!");
            histories.Add($"{leftOperand} + {rightOperand} = {attemptedAnswer} (Correct!)");
        }
        else
        {
            Console.WriteLine($"You got it Wrong. The answer is {difference}");
            histories.Add($"{leftOperand} + {rightOperand} = {attemptedAnswer} (Incorrect...)");
        }
    }

    static void generateMultiplyGame()
    {
        int leftOperand = generateRandomInteger(0, 10);
        int rightOperand = generateRandomInteger(0, 10);
        int product = leftOperand * rightOperand;
        Console.WriteLine("Please enter the answer:");
        Console.Write($"{leftOperand} * {rightOperand} = ");
        int attemptedAnswer = Convert.ToInt32(Console.ReadLine());
        if (attemptedAnswer == product)
        {
            Console.WriteLine("You got it right!");
            histories.Add($"{leftOperand} + {rightOperand} = {attemptedAnswer} (Correct!)");
        }
        else
        {
            Console.WriteLine($"You got it Wrong. The answer is {product}");
            histories.Add($"{leftOperand} + {rightOperand} = {attemptedAnswer} (Incorrect...)");
        }
    }

    static void generateDivideGame()
    {
        int quotient = generateRandomInteger(1, 11);
        int rightOperand = generateRandomInteger(1, 11);
        int leftOperand = quotient * rightOperand;

        Console.WriteLine("Please enter the answer:");
        Console.Write($"{leftOperand} / {rightOperand} = ");
        int attemptedAnswer = Convert.ToInt32(Console.ReadLine());
        if (attemptedAnswer == quotient)
        {
            Console.WriteLine("You got it right!");
            histories.Add($"{leftOperand} + {rightOperand} = {attemptedAnswer} (Correct!)");
        }
        else
        {
            Console.WriteLine($"You got it Wrong. The answer is {quotient}");
            histories.Add($"{leftOperand} + {rightOperand} = {attemptedAnswer} (Incorrect...)");
        }
    }

    static void showHistory()
    {
        if (histories.Count == 0)
        {
            Console.WriteLine("There is no history");
        }
        else
        {
            foreach (var h in histories)
            {
                Console.WriteLine(h);
            }
            Console.WriteLine("End of histories");
        }
    }

    static void stopPlaying()
    {
        shouldContinue = false;
        Console.WriteLine("Game over");
    }

    static int generateRandomInteger(int min, int max)
    {
        Random rd = new Random();
        int randomNumber = rd.Next(min, max);
        return randomNumber;
    }
}
