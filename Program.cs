//Ex 1
Console.WriteLine("Exercise 1");
int n = Convert.ToInt32(Console.ReadLine());
int a = Convert.ToInt32(Console.ReadLine());

if (n > a)
{
    Console.WriteLine("First number is greater than second number");
}
else if (n < a)
{
    Console.WriteLine("First number is less than second number");
}
else
{
    Console.WriteLine("The numbers are equal");
}

//Ex 2
Console.WriteLine("Exercise 2");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 5 && n < 10)
{
    Console.WriteLine("The number is greater than 5 and less than 10");
}
else
{
    Console.WriteLine("Unknown number");
}

//Ex 3
Console.WriteLine("Exercise 3");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 5 || n == 10)
{
    Console.WriteLine("The number is either 5 or 10");
}
else
{
    Console.WriteLine("Unknown number");
}

//Ex 4
Console.WriteLine("Exercise 4");
double n = Convert.ToDouble(Console.ReadLine());
if (n < 100)
{
    Console.WriteLine(n + (n * (0.05)));
}
else if (n >= 100 && n <= 200)
{
    Console.WriteLine(n + (n * (0.07)));
}
else if (n > 200)
{
    Console.WriteLine(n + (n * (0.1)));
}

//Ex 5 
Console.WriteLine("Exercise 5");
double n = Convert.ToDouble(Console.ReadLine());
if (n < 100)
{
    Console.WriteLine(n + (n * (0.05) + 15));
}
else if (n >= 100 && n <= 200)
{
    Console.WriteLine(n + (n * (0.07) + 15));
}
else if (n > 200)
{
    Console.WriteLine(n + (n * (0.1) + 15));
}

//Ex 6
Console.WriteLine("Exercise 6");
Console.WriteLine("Enter operation number: 1.Add 2.Subtract 3.Multiply");
int n = Convert.ToInt32(Console.ReadLine());

switch (n)
{
    case 1:
        Console.WriteLine("Addition");
        break;
    case 2:
        Console.WriteLine("Subtraction");
        break;
    case 3:
        Console.WriteLine("Multiplication");
        break;
    default:
        Console.WriteLine("Operation undefined");
        break;
}

//Ex 7
Console.WriteLine("Exercise 7");
Console.WriteLine("Enter operation number: 1.Add 2.Subtract 3.Multiply");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter first number:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number:");
int b = Convert.ToInt32(Console.ReadLine());

switch (n)
{
    case 1:
        Console.WriteLine($"Result: {a + b}");
        break;
    case 2:
        Console.WriteLine($"Result: {a - b}");
        break;
    case 3:
        Console.WriteLine($"Result: {a * b}");
        break;
    default:
        Console.WriteLine("Operation undefined");
        break;
}