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
        string? addX = Console.ReadLine();
        Console.Write("y: ");
        string? addY = Console.ReadLine();

        if (
            double.TryParse(addX, out double addXDouble)
            && double.TryParse(addY, out double addYDouble)
        )
        {
            Console.WriteLine($"{addXDouble} + {addYDouble} = {addXDouble + addYDouble}");
        }
        else
        {
            Console.WriteLine("Invalid input, not a number");
        }

        break;
    case 2:
        // Substraction logic
        Console.WriteLine("Provide an x and y numbers");
        Console.Write("x: ");
        string? mulX = Console.ReadLine();
        Console.Write("y: ");
        string? mulY = Console.ReadLine();

        if (
            double.TryParse(mulX, out double mulXDouble)
            && double.TryParse(mulY, out double mulYDouble)
        )
        {
            Console.WriteLine($"{mulXDouble} * {mulYDouble} = {mulXDouble * mulYDouble}");
        }
        else
        {
            Console.WriteLine("Invalid input, not a number");
        }

        break;
    case 3:
        // Multiplication logic
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
