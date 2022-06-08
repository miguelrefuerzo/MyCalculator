// See https://aka.ms/new-console-template for more information
using MyCalculator;
char action;
int x, y;
Console.WriteLine("What would you like to do? \na. Add\nb. Subtract\nc. Multiply\nd. Divide");

action = Console.ReadLine()[0];


switch (action)
{
    case 'a':
        Console.WriteLine("Addition");
        Console.WriteLine("Number:");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        Addition.Adding(x, y);
        break;
    default:
        break;
}