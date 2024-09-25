using System;

class Program
{
    static void Main()
    {
        // 1. Ask user for string
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToUpper();
        int[] indexes = new int[128];

        // 2. Iterate over each character
        foreach (char c in input)
        {
            // - Add a counter for each character
            indexes[c]++;
        }

        // 3. Find character with highest counter
        int maxCount = 0;
        char mostCommon = ' ';
        for (int i = 0; i < indexes.Length; i++)
        {
            if (indexes[i] > maxCount)
            {
                maxCount = indexes[i];
                mostCommon = (char)i;
            }
        }

        // 4. Print character
        Console.WriteLine($"'{mostCommon}' {maxCount}");
    }
}