using System;

class MyProgram
{
    static void Main()
    {
        TestCase1();
        TestCase2();
    }

    static void TestCase1()
    {
        // Test case 1: "Hello World"
        string input = "Hello World";
        Console.WriteLine("Input: " + input);
        RunProgram(input);
        Console.WriteLine(); // For spacing between test cases
    }

    static void TestCase2()
    {
        // Test case 2: "Programming"
        string input = "Programming";
        Console.WriteLine("Input: " + input);
        RunProgram(input);
    }

    static void RunProgram(string input)
    {
        // Convert to uppercase
        input = input.ToUpper();

        int[] indexes = new int[128];

        // Iterate over each character
        foreach (char c in input)
        {
            // Add a counter for each character
            indexes[c]++;
        }

        // Find character with highest counter
        int maxIndex = Array.IndexOf(indexes, indexes.Max());
        char mostCommon = (char)maxIndex;

        // Print character
        Console.WriteLine($"'{mostCommon}' {indexes[maxIndex]}");
    }
}
