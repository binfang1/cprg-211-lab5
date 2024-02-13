namespace Lab5;

using System;
class InvalidRadiusException : Exception
{
    public InvalidRadiusException()
    {
        Console.WriteLine("Radius is greater than 0");
    }

    public InvalidRadiusException(double radius)
    {
        Console.WriteLine($"Radius: {radius} is not valid");
    }
}

