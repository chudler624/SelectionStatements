//Exercise 1, 

int favoriteNumber = 3;

Console.WriteLine("Can you Guess my Favorite number between 1 and 10?");
int userGuess= int.Parse(Console.ReadLine());

if (userGuess <=2)
    Console.WriteLine("My number is higher");
else if (userGuess ==3)
    Console.WriteLine("You got it! How'd you guess my number?");
else if (userGuess >= 4)
    Console.WriteLine("My number is lower");

//Exercise #2



Console.WriteLine("What is your favorite subject in School?");

string subject = Console.ReadLine();

switch (subject)
{
    case "math":
        Console.WriteLine("Wow, you must be pretty smart");
        break;
    case "english":
        Console.WriteLine("You probably like to read a lot");
        break;
    case "gym":
        Console.WriteLine("You probably like sports");
        break;
    case "history":
        Console.WriteLine("You must like hearing old stories");
        break;
    case "lunch":
        Console.WriteLine("I bet you like to eat");
        break;
    case "science":
        Console.WriteLine("Maybe you'll be a scientist one day");
        break;
    default:
        Console.WriteLine("Oh Wow, that's pretty interesting");
        break;
}
