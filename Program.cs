using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice (1-4): ");
            string choice = Console.ReadLine();

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
                    Console.WriteLine("Exiting... Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void GradeCalculator()
    {
        Console.Write("Enter numerical grade (0-100): ");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
            Console.WriteLine("Grade: A");
        else if (grade >= 80)
            Console.WriteLine("Grade: B");
        else if (grade >= 70)
            Console.WriteLine("Grade: C");
        else if (grade >= 60)
            Console.WriteLine("Grade: D");
        else
            Console.WriteLine("Grade: F");
    }

    static void TicketPriceCalculator()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age <= 12 || age >= 65)
            Console.WriteLine("Ticket Price: GHC7");
        else
            Console.WriteLine("Ticket Price: GHC10");
    }

    static void TriangleTypeIdentifier()
    {
        Console.Write("Enter side 1: ");
        int side1 = int.Parse(Console.ReadLine());

        Console.Write("Enter side 2: ");
        int side2 = int.Parse(Console.ReadLine());

        Console.Write("Enter side 3: ");
        int side3 = int.Parse(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
            Console.WriteLine("Triangle type: Equilateral");
        else if (side1 == side2 || side2 == side3 || side1 == side3)
            Console.WriteLine("Triangle type: Isosceles");
        else
            Console.WriteLine("Triangle type: Scalene");
    }
}
