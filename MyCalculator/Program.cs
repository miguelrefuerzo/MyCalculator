// See https://aka.ms/new-console-template for more information
using MyCalculator;
char action;
int x, y;
Console.WriteLine("What would you like to do? \na. Add\nb. Subtract\nc. Multiply\nd. Divide");

action = Console.ReadLine()[0];


switch (action)
{
    case 'a':
        Console.Clear();
        Console.WriteLine("Addition");
        Console.WriteLine("Number:");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        Addition.Adding(x, y);
        break;
    case 'b':
        Console.Clear();
        Console.WriteLine("Subtraction");
        Console.WriteLine("Number: ");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        Subtraction.Subtracting(x, y);
        break;
    case 'c':
        Console.Clear();
        Console.WriteLine("Multiplication");
        Console.WriteLine("Number: ");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        Multiplication.Multiplicating(x, y);
        break;
    case 'd':
        Console.Clear();
        Console.WriteLine("Division");
        Console.WriteLine("Number: ");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        Division.Dividing(x, y);
        break;
    default:
        break;
}