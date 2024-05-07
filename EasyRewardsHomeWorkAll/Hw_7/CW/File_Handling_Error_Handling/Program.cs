using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"D:\EasYRewardsTrainingAll\EasyRewardsHomeWorkAll\sum.txt";

        try
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            int sum = 0;
            foreach (string line in lines)
            {
                // Try to parse each line as an integer and add it to the sum
                if (int.TryParse(line, out int number))
                {
                    sum += number;
                }
                else
                {
                    // If the line cannot be parsed as an integer, throw FormatException
                    throw new FormatException($"Invalid data found in the file: '{line}'");
                }
            }

            Console.WriteLine($"Sum of integers in the file: {sum}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error reading the file: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error parsing data from the file: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}
