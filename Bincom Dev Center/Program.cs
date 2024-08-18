using System;

class Program
{
    static void Main(string[] args)
    {
        // Task No 1: Declare and initialize variables:

        string name = "John Doe";
        int age = 25;
        bool isAdmin = true;
        PrintDetails(name, age, isAdmin);

        static void PrintDetails(string name, int age, bool isAdmin)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Is Admin: {isAdmin}");
        }

        // Task No 2: Write a program that takes an integer input from the user and prints out whether the number is even or odd.
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(IsEven(number) ? $"{number} is Even" : $"{number} is Odd");

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Task 3: Write a program that prints out the numbers 1 to 10 using a for loop.

        Console.WriteLine("Numbers from 1 to 10: ");
        for (int i = 1; i <= 10; i++)
        {
            PrintNumber(i);
        }

        static void PrintNumber(int number)
        {
            Console.WriteLine(number);
        }

        // Task 4:Declare and initialize an integer array with the values 2, 4, 6, 8, 10.

        int[] numbers = new int[] { 2, 4, 6, 8, 10 };
        int totalSum = CalculateSum(numbers);
        Console.WriteLine("Array elements:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        static int CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        Console.WriteLine($"Sum of array elements: {totalSum}");

        // Task 5: Write a method named Greet that takes a string parameter name and prints out a personalized greeting message.

        Greet("Alice");

        static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
