bool running = true;

while (running)
{
    Console.WriteLine("==== Simple Calculator ====");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Substraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Exit");
    Console.WriteLine("===========================");

    Console.Write(">> ");
    string? userInput = Console.ReadLine();

    if (int.TryParse(userInput, out int choice))
    {
        Console.Clear();

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
                    break;
                }

                break;
            case 2:
                Console.WriteLine("Provide an x and y numbers");
                Console.Write("x: ");
                string? subX = Console.ReadLine();
                Console.Write("y: ");
                string? subY = Console.ReadLine();

                if (
                    double.TryParse(subX, out double subXDouble)
                    && double.TryParse(subY, out double subYDouble)
                )
                {
                    Console.WriteLine($"{subXDouble} - {subYDouble} = {subXDouble - subYDouble}");
                }
                else
                {
                    Console.WriteLine("Invalid input, not a number");
                    break;
                }

                break;
            case 3:
                // Multiplication logic
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
                    break;
                }

                break;
            case 4:
                Console.WriteLine("Provide an x and y numbers");
                Console.Write("x: ");
                string? divX = Console.ReadLine();
                Console.Write("y: ");
                string? divY = Console.ReadLine();

                if (
                    double.TryParse(divX, out double divXDouble)
                    && double.TryParse(divY, out double divYDouble)
                )
                {
                    if (divYDouble != 0)
                    {
                        Console.WriteLine(
                            $"{divXDouble} / {divYDouble} = {divXDouble / divYDouble}"
                        );
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by 0");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, not a number");
                    break;
                }

                break;
            case 5:
                Console.WriteLine("Exit");
                running = false;

                break;
            default:
                Console.WriteLine("Invalid option, provide number 1-5");

                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input, not a number");
    }
}
