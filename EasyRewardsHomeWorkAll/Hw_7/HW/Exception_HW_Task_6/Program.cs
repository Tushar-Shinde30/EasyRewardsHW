using System;

class Program
{
    static void Main()
    {
        try
        {
            ThrowCustomException();
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"Custom Exception caught: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    static void ThrowCustomException()
    {
        throw new CustomException("This is a custom exception.");
    }
}

public class CustomException : Exception
{
    public CustomException() : base() { }

    public CustomException(string message) : base(message) { }

    public CustomException(string message, Exception innerException) : base(message, innerException) { }
}
