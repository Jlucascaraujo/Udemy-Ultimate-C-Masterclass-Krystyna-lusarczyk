Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();
var seeAll = "See all TODOs.";
var addTodo = "Add a TODO.";
var removeTodo = "Remove a TODO.";
var exitStage = "Exit.";

switch(userChoice)
{
    case "S":
        MessageSelectedChoice(seeALl);
        break;
    case "A":
        MessageSelectedChoice(addTodo);
        break;
    case "R":
        MessageSelectedChoice(removeTodo);
        break;
    case "E":
        MessageSelectedChoice(exitStage);
        break;
    default:
        Console.WriteLine("Invalid Choice");
        break;
}

//if ((userChoice == "S")||(userChoice == "s"))
//    {
//        MessageSelectedChoice(seeAll);
//    }
//else if ((userChoice == "A")||(userChoice == "a"))
//    {
//        MessageSelectedChoice(addTodo);
//    }
//else if ((userChoice == "R")||(userChoice == "r"))
//    {
//        MessageSelectedChoice(removeTodo);
//    }
//else if ((userChoice == "E")||(userChoice == "e"))
//    {
//        MessageSelectedChoice(exitStage);
//        Console.ReadKey();
//    }
//else
//    {
//        Console.WriteLine("Error");
//    }



void MessageSelectedChoice (string selectedChoice = "Selected Choice: ")
{
    Console.WriteLine("Selected Choice: " + selectedChoice);
}