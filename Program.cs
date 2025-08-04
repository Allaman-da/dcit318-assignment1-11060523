using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n=== Console Application Menu ===");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option (1-4): ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    GradeCalculator();
                    break;
                case "2":
                    TicketPriceCalculator();
                    break;
                case "3":
                    TriangleTypeIdentifier();
                    break;
                case "4":
                    Console.WriteLine("Exiting application. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }

    static void GradeCalculator()
    {
        Console.Write("\nEnter your numerical grade (0 - 100): ");
        int grade = int.Parse(Console.ReadLine() ?? "0");

        string letterGrade;

        if (grade >= 90)
            letterGrade = "A";
        else if (grade >= 80)
            letterGrade = "B";
        else if (grade >= 70)
            letterGrade = "C";
        else if (grade >= 60)
            letterGrade = "D";
        else
            letterGrade = "F";

        Console.WriteLine($"Your letter grade is: {letterGrade}");
    }

    static void TicketPriceCalculator()
    {
        Console.Write("\nEnter your age: ");
        int age = int.Parse(Console.ReadLine() ?? "0");

        double price;

        if (age <= 12 || age >= 65)
            price = 7.00;
        else
            price = 10.00;

        Console.WriteLine($"Your ticket price is: GHC{price}");
    }

    static void TriangleTypeIdentifier()
    {
        Console.Write("\nEnter side 1: ");
        double side1 = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter side 2: ");
        double side2 = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter side 3: ");
        double side3 = double.Parse(Console.ReadLine() ?? "0");

        if (side1 == side2 && side2 == side3)
            Console.WriteLine("The triangle is Equilateral.");
        else if (side1 == side2 || side1 == side3 || side2 == side3)
            Console.WriteLine("The triangle is Isosceles.");
        else
            Console.WriteLine("The triangle is Scalene.");
    }
}
