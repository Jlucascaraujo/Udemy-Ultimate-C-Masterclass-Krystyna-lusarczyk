using System.Threading.Channels;

Console.WriteLine("Hello!");

var firstInputMsg = "Input the first number: ";
Console.WriteLine(firstInputMsg);
var firstNum = Console.ReadLine();

var secondInputMsg = "Input the second number: ";
Console.WriteLine(secondInputMsg);
var secondNum = Console.ReadLine();

var options =   "What do you want to do with those numbers?\n" +
                "[A]dd\n" +
                "[S]ubtract\n" +
                "[M]ultiply\n";

Console.WriteLine(options);
var userChoice = Console.ReadLine();

if(userChoice is string)
{
    if(userChoice == "A"||userChoice == "a")
    {
        if(int.TryParse(firstNum, out int num1) && int.TryParse(secondNum, out int num2))
        {
            Console.WriteLine($"Result: {num1 + num2}");
        }
        else
        {
            Console.WriteLine("Invalid input! Please, input a valid number!");
        }
    }
    else if(userChoice == "S"||userChoice == "s")
    {
        if (int.TryParse(firstNum, out int num1) && int.TryParse(secondNum, out int num2))
        {
            Console.WriteLine($"Result: {num1 - num2}");
        }
        else
        {
            Console.WriteLine("Invalid input! Please, input a valid number!");
        }
    }
    else if(userChoice == "M"||userChoice == "m")
    {
        if (int.TryParse(firstNum, out int num1) && int.TryParse(secondNum, out int num2))
        {
            Console.WriteLine($"Result: {num1 * num2}");
        }
        else
        {
            Console.WriteLine("Invalid input! Please, input a valid number!");
        }
    }
    else
    {
        Console.WriteLine(value: "Invalid Choice! Please, input A, S or M.");
    }
} else
{
    Console.WriteLine("What the hell happened!?");
}

var closeMsg = "Press any key to close.";
Console.WriteLine(closeMsg);
Console.ReadKey();
