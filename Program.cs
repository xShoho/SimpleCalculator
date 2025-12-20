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
    Console.WriteLine("Invalid input, not a number.");
}

