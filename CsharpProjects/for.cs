using System;

namespace CsharpProjects
{
    class Program
    {
        static void Main()
        {
            string[] names = { "Alex", "Eddie", "David", "Michael" };

            // Use a for-loop to modify the array elements
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "David")
                    names[i] = "Sammy";
            }

            // Print the results
            foreach (var name in names) Console.WriteLine(name);
        }
    }
}

