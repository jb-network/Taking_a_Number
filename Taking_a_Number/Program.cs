// This is challenge work for the "C# Players Guide"
// Level 13 Taking a Number Challenge
// This challenge requires a method that provides a return entered by the user
// This challenge requires a method that can determine if a number provided by a user is in a range
// Added Next Program and End Program Methods for future use
// Note: This is using local functions rather than methods



//Call 1
string call1 = "How many hours will you work on C# this week?";
int returnedNumber = AskForNumber(call1);
Console.WriteLine($"Number of hours returned from call 1: {returnedNumber}");

//Call to clear screen
nextProgram();

//Call 2
string call2 = "Pick a number between: ";
int returnValue = AskForNumberInRange(call2, 1, 10);
Console.WriteLine($"The user's in range guess returned from call 2: {returnValue}");

//Call to clear screen
nextProgram();

//Call to end the program
endProgram();

//Method 1
int AskForNumber(string call1)
{
    Console.WriteLine(call1);
    int numberofHours = Convert.ToInt32(Console.ReadLine());
    return numberofHours;
}

//Method 2
int AskForNumberInRange(string call2, int min, int max)
{
    int userGuess;
    do
    {
        Console.WriteLine(call2 + $"{min} and {max}:");
        userGuess = Convert.ToInt32(Console.ReadLine());
        if (userGuess < min || userGuess > max) Console.WriteLine("The number you provided was out of range, please try again.");
    }
    while (userGuess < min || userGuess > max);
    return userGuess;
}

//End Program method
void endProgram()
{
    Console.WriteLine("Press any key to end the program");
    Console.ReadKey();
}

//Clear screen method
void nextProgram()
{
    Console.WriteLine("Press any key to move foward");
    Console.ReadKey();
    Console.Clear();
}