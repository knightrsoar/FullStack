namespace ConsoleApp1;

// // Practice loops and operators
// // 1.Part 1: FizzBuzz Game
// public class Program3
// {
//     static void Main(string[] args)
//     {
//         for (int i = 1; i <= 100; i++)
//         {
//             string result = "";
//             if (i % 3 == 0) result += "fizz";
//             if (i % 5 == 0) result += "buzz";
//             Console.WriteLine(string.IsNullOrEmpty(result) ? i.ToString() : result);
//         }
//     }
// }


// // 1.Part 2: Loop with Byte Variable
// public class Program3
// {
//     static void Main(string[] args)
//     {
//         int max = 500;
//         for (byte i = 0; i < max; i++) // Expression is always true
//         {
//             Console.WriteLine(i);
//             if (i == 255)
//             {
//                 Console.WriteLine("Warning: Byte type overflow. Loop will continue indefinitely.");
//                 break; // Optional: to prevent infinite loop
//             }
//         }
//     }
// }

// 1. Part 3: Guess the Number Game

// class Program3
// {
//     static void Main(string[] args)
//     {
//         int correctNumber = new Random().Next(3) + 1; // create a random number between 1 and 3
//         Console.WriteLine("Guess a number between 1 and 3:");
//
//         int guessedNumber = int.Parse(Console.ReadLine()); // convert user's typed answer from a string to an int
//
//         if (guessedNumber < 1 || guessedNumber > 3)
//         {
//             Console.WriteLine("Your guess is outside of the valid range.");
//         }
//         else if (guessedNumber < correctNumber)
//         {
//             Console.WriteLine("Your guess is too low.");
//         }
//         else if (guessedNumber > correctNumber)
//         {
//             Console.WriteLine("Your guess is too high.");
//         }
//         else
//         {
//             Console.WriteLine("You guessed correctly!");
//         }
//     }
// }

// // 2. Print-a-Pyramid
// class Program3
// {
//     static void Main()
//     {
//         int rows = 5;
//         for (int i = 1; i <= rows; i++)
//         {
//             for (int space = 1; space <= rows - i; space++)
//             {
//                 Console.Write(" ");
//             }
//             for (int star = 1; star <= 2 * i - 1; star++)
//             {
//                 Console.Write("*");
//             }
//             Console.WriteLine();
//         }
//     }
// }
//
// // 3. Guess the Number Game
// class Program3
// {
//     static void Main()
//     {
//         int correctNumber = new Random().Next(1, 4); // Generates a number between 1 and 3
//         Console.WriteLine("Guess a number between 1 and 3:");
//         int guessedNumber = int.Parse(Console.ReadLine());
//
//         if (guessedNumber < 1 || guessedNumber > 3)
//         {
//             Console.WriteLine("Your guess is outside of the valid range.");
//         }
//         else if (guessedNumber < correctNumber)
//         {
//             Console.WriteLine("Your guess is too low.");
//         }
//         else if (guessedNumber > correctNumber)
//         {
//             Console.WriteLine("Your guess is too high.");
//         }
//         else
//         {
//             Console.WriteLine("You guessed correctly!");
//         }
//     }
// }
//
// // 4. Calculate Age in Days and Next Anniversary
// class Program3
// {
//     static void Main()
//     {
//         DateTime birthDate = new DateTime(1990, 1, 1); // Change to the desired birth date
//         DateTime currentDate = DateTime.Now;
//
//         int daysOld = (currentDate - birthDate).Days;
//         int daysToNextAnniversary = 10000 - (daysOld % 10000);
//
//         Console.WriteLine($"You are {daysOld} days old.");
//         Console.WriteLine($"Days to next 10,000 day anniversary: {daysToNextAnniversary}");
//     }
// }
//
// // 5. Greet User Based on Time of Day
// class Program
// {
//     static void Main()
//     {
//         DateTime now = DateTime.Now; // Use DateTime.Now for the current time
//
//         int hour = now.Hour;
//
//         if (hour >= 0 && hour < 12)
//         {
//             Console.WriteLine("Good Morning");
//         }
//         if (hour >= 12 && hour < 16)
//         {
//             Console.WriteLine("Good Afternoon");
//         }
//         if (hour >= 16 && hour < 20)
//         {
//             Console.WriteLine("Good Evening");
//         }
//         if (hour >= 20)
//         {
//             Console.WriteLine("Good Night");
//         }
//     }
// }


// 6. Counting Up with Different Increments
class Program
{
    static void Main()
    {
        for (int increment = 1; increment <= 4; increment++)
        {
            for (int i = 0; i <= 24; i += increment)
            {
                Console.Write(i + (i < 24 ? "," : ""));
            }
            Console.WriteLine();
        }
    }
}