Console.WriteLine("====Simple Calculator====");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Substraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Exit");
Console.WriteLine("=========================");

Console.Write(">> ");
string? userInput = Console.ReadLine();

if (int.TryParse(userInput, out int choice))
{
    // Valid number
}
else
{
    Console.WriteLine("Invalid input, not a number");
}

switch (choice)
{
    case 1:
        Console.WriteLine("Provide an x and y numbers");
        Console.Write("x: ");
        string? x = Console.ReadLine();
        Console.Write("y: ");
        string? y = Console.ReadLine();

        if (double.TryParse(x, out double num1) && double.TryParse(y, out double num2))
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        break;
    case 2:
        // Substraction logic
        Console.WriteLine("Not yet implemented");
        break;
    case 3:
        // Multiplication logic
        Console.WriteLine("Not yet implemented");
        break;
    case 4:
        // Division logic
        Console.WriteLine("Not yet implemented");
        break;
    case 5:
        Console.WriteLine("Exit");

        break;
    default:
        Console.WriteLine("Invalid option, provide number 1-5");

        break;
}

