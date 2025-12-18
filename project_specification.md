# Project 1: Simple Calculator

## Overview

This is your first .NET project. You will build a console application that performs basic arithmetic operations. This project introduces fundamental C# syntax, variables, user input/output, and control flow - the building blocks you need before tackling anything more complex.

**Estimated Time: 3-5 days**

**Difficulty: Beginner (1/5)**

---

## Learning Objectives

By completing this project, you will learn:

### C# Fundamentals
- [ ] How to create and run a .NET console application
- [ ] Variables and data types (int, double, string, bool)
- [ ] Basic operators (arithmetic, comparison, logical)
- [ ] Console input with `Console.ReadLine()`
- [ ] Console output with `Console.WriteLine()` and string interpolation
- [ ] Type conversion and parsing (`int.Parse()`, `double.TryParse()`)
- [ ] Control flow with `if/else` and `switch` statements
- [ ] Loops (`while`, `do-while`) for program continuation
- [ ] Basic error handling for invalid input

### Development Environment
- [ ] Using the .NET CLI (`dotnet new`, `dotnet run`, `dotnet build`)
- [ ] Understanding project files (`.csproj`)
- [ ] Basic debugging with breakpoints (optional but recommended)

---

## Concepts Being Introduced

| Concept | Why It Matters |
|---------|----------------|
| Variables and Types | Every program stores and manipulates data |
| User Input | Real applications interact with users |
| Control Flow | Programs must make decisions |
| Type Conversion | Data often comes as strings and needs conversion |
| Error Handling | Users make mistakes; your program should handle them |
| Program Loop | Most applications run until the user chooses to exit |

---

## Project Requirements

### Functional Requirements

1. **Display a menu** showing available operations:
   - Addition
   - Subtraction
   - Multiplication
   - Division
   - Exit

2. **Accept user input** for:
   - Operation selection
   - Two numbers to operate on

3. **Perform calculations** and display results

4. **Handle errors gracefully**:
   - Invalid menu selection
   - Non-numeric input
   - Division by zero

5. **Continue running** until the user chooses to exit

### Non-Functional Requirements

- Code must compile without warnings
- Use meaningful variable names
- Include comments explaining non-obvious logic
- Format output clearly for readability

---

## Step-by-Step Implementation Guide

### Step 1: Create the Project

Open your terminal and navigate to this project folder, then run:

```bash
dotnet new console -n SimpleCalculator
cd SimpleCalculator
```

This creates a new console application. Open the folder in your code editor.

### Step 2: Understand the Starting Point

Open `Program.cs`. You will see something like:

```csharp
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
```

Delete this and start fresh. We will build everything from scratch.

### Step 3: Create the Main Menu

Your first task is to display a menu to the user.

```csharp
Console.WriteLine("=== Simple Calculator ===");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Exit");
Console.WriteLine("========================");
Console.Write("Select an operation (1-5): ");
```

**Your Task:** Run this code with `dotnet run` to verify it displays correctly.

### Step 4: Read User Input

After displaying the menu, you need to capture what the user types:

```csharp
string? userInput = Console.ReadLine();
```

**Important:** The `?` after `string` indicates this can be null (if the user presses Ctrl+C, for example). This is C#'s nullable reference types feature.

### Step 5: Convert and Validate Input

The user's input comes as a string. You need to convert it to a number:

```csharp
// Method 1: Direct parsing (throws exception if invalid)
int choice = int.Parse(userInput);

// Method 2: TryParse (safer - returns true/false)
if (int.TryParse(userInput, out int choice))
{
    // Valid number
}
else
{
    Console.WriteLine("Invalid input. Please enter a number.");
}
```

**Your Task:** Implement input validation using `TryParse`. This is the professional approach.

### Step 6: Implement Operation Selection

Use a `switch` statement to handle different operations:

```csharp
switch (choice)
{
    case 1:
        // Addition logic here
        break;
    case 2:
        // Subtraction logic here
        break;
    case 3:
        // Multiplication logic here
        break;
    case 4:
        // Division logic here
        break;
    case 5:
        Console.WriteLine("Goodbye!");
        return; // Exit the program
    default:
        Console.WriteLine("Invalid selection. Please choose 1-5.");
        break;
}
```

### Step 7: Get Numbers from User

Create a method or inline code to get two numbers:

```csharp
Console.Write("Enter first number: ");
string? input1 = Console.ReadLine();

Console.Write("Enter second number: ");
string? input2 = Console.ReadLine();

// Parse with validation
if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
{
    // Perform calculation
}
else
{
    Console.WriteLine("Invalid number format.");
}
```

**Why `double` instead of `int`?** Using `double` allows decimal numbers and provides more flexibility.

### Step 8: Perform and Display Calculations

For each operation, perform the calculation and display the result:

```csharp
case 1:
    Console.Write("Enter first number: ");
    // ... get inputs ...
    double result = num1 + num2;
    Console.WriteLine($"{num1} + {num2} = {result}");
    break;
```

**String Interpolation:** The `$""` syntax allows you to embed variables directly in strings using `{variableName}`.

### Step 9: Handle Division by Zero

Division requires special handling:

```csharp
case 4:
    // ... get inputs ...
    if (num2 == 0)
    {
        Console.WriteLine("Error: Cannot divide by zero.");
    }
    else
    {
        double result = num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {result}");
    }
    break;
```

### Step 10: Add the Main Loop

Wrap everything in a loop so the program continues running:

```csharp
while (true)
{
    // Display menu
    // Get input
    // Process selection
    // If exit, break out of loop
}
```

Or use a boolean flag:

```csharp
bool running = true;
while (running)
{
    // ... menu and processing ...

    case 5:
        running = false;
        Console.WriteLine("Goodbye!");
        break;
}
```

### Step 11: Add Finishing Touches

- Clear the console between operations (optional): `Console.Clear()`
- Add a "Press Enter to continue" prompt after each calculation
- Format numbers nicely for display: `result.ToString("F2")` for 2 decimal places

---

## Sample Program Flow

```
=== Simple Calculator ===
1. Addition
2. Subtraction
3. Multiplication
4. Division
5. Exit
========================
Select an operation (1-5): 1

Enter first number: 10
Enter second number: 3
10 + 3 = 13

Press Enter to continue...

=== Simple Calculator ===
1. Addition
2. Subtraction
3. Multiplication
4. Division
5. Exit
========================
Select an operation (1-5): 4

Enter first number: 10
Enter second number: 0
Error: Cannot divide by zero.

Press Enter to continue...

=== Simple Calculator ===
1. Addition
2. Subtraction
3. Multiplication
4. Division
5. Exit
========================
Select an operation (1-5): 5

Goodbye!
```

---

## Acceptance Criteria

Your project is complete when:

- [ ] Program compiles and runs without errors
- [ ] Menu displays all five options clearly
- [ ] All four arithmetic operations work correctly
- [ ] Program handles non-numeric input gracefully (no crashes)
- [ ] Division by zero shows an error message (no crashes)
- [ ] Invalid menu selections show an error message
- [ ] Program continues until user selects Exit
- [ ] Code uses meaningful variable names (not `x`, `y`, `z`)
- [ ] Code includes comments explaining the logic

---

## Common Mistakes to Avoid

1. **Using `int.Parse()` without validation** - Your program will crash if the user types "abc"

2. **Forgetting to handle null from `Console.ReadLine()`** - In .NET 6+, `ReadLine()` can return null

3. **Not handling division by zero** - This will cause runtime errors or `Infinity` results

4. **Magic numbers** - Avoid code like `if (choice == 1)` without explanation. Use comments or constants.

5. **Inconsistent formatting** - Keep your output neat and aligned

---

## Extension Challenges (Optional)

If you finish early, try these enhancements:

1. **Add more operations**: Square root, power, modulo
2. **Add calculation history**: Store and display previous calculations
3. **Add input validation**: Reject numbers outside a reasonable range
4. **Format large numbers**: Add thousand separators (1,000,000)

---

## How This Prepares You for Project 2

In the next project, you will:
- Use **classes** to organize code (instead of everything in `Program.cs`)
- Work with **collections** (List<T>) to store multiple items
- Learn about **properties** and **methods** in classes
- Understand **object-oriented programming** basics

The input/output skills and control flow patterns you learn here will be used throughout your .NET journey.

---

## Submission Checklist

Before moving to Project 2, ensure:

- [ ] Your calculator handles all edge cases
- [ ] You understand every line of code you wrote
- [ ] You can explain what `TryParse` does and why it is better than `Parse`
- [ ] You can explain the difference between `int`, `double`, and `string`
- [ ] You understand how `while` loops and `switch` statements work

---

## Resources

- [Microsoft Learn: Console Apps](https://learn.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code)
- [C# Type Conversion](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions)
- [C# switch Statement](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements#the-switch-statement)
