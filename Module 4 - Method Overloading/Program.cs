using System;
using System.ComponentModel;

class Printer
{
    public void Print(int value)
    {
        Console.WriteLine(value);
    }

    public void Print(double value)
    {
        Console.WriteLine(value);
    }

    public void Print(string value)
    {
        Console.WriteLine(value);
    }

    public void Print(string format, params object[] args)
    {
        Console.WriteLine(format, args);
    }
}

class Program
{
    static void Main()
    {
        Printer printer = new Printer();

        int intValue = 42;
        double doubleValue = 3.14;
        string stringValue = "Hello, World!";

        // Calling the overloaded Print methods
        printer.Print(intValue);
        printer.Print(doubleValue);
        printer.Print(stringValue);
        printer.Print((doubleValue+intValue));

        // Using the format and params version of Print
        printer.Print("Formatted: {0} - {1}", doubleValue, stringValue);
    }
}
