using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter words separated by space: ");
        var words = Console.ReadLine().Split(' ');
        Console.WriteLine("Enter a character: ");
        var c = Console.ReadLine()[0];

        var count = 0;
        var positions = new Dictionary<string, List<int>>();
        foreach (var word in words)
        {
            var indices = new List<int>();
            for (var i = 0; i < word.Length; i++)
            {
                if (word[i] == c)
                {
                    count++;
                    indices.Add(i);
                }
            }
            positions[word] = indices;
        }

        Console.WriteLine($"'{c}' appears {count} times.");
        Console.WriteLine("Positions in each word:");
        foreach (var kvp in positions)
        {
            Console.WriteLine($"{kvp.Key}: [{string.Join(", ", kvp.Value)}]");
        }
    }
}
