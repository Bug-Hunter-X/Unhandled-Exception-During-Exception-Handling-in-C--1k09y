using System;
using System.IO;

public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        try
        {
            // Simulate some code that might throw an exception
            int result = 10 / 0; // This will throw a DivideByZeroException
        }
        catch (Exception ex)
        {
            // Log the exception for better debugging
            string errorMessage = $"An error occurred: {ex.Message}
Stack Trace: {ex.StackTrace}";
            try
            {
                File.WriteAllText("error.log", errorMessage); // Could potentially fail
            }
            catch (IOException ioEx)
            {
                Console.WriteLine($"Failed to log error: {ioEx.Message}");
                Console.WriteLine("Original error:");
                Console.WriteLine(errorMessage); //Print to console if logging fails
            }
            // Re-throw the exception after logging
            throw; 
        }
    }
}