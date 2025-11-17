// Simple D20 Dice Roller App
// Version 1.1 - Added Version Check
const string VERSION = "1.1";

// Create our D20 die one time
Dice d20 = new Dice(20);
bool keepPlaying = true;

while (keepPlaying)
{
    Console.Clear(); // Clear the screen for a fresh roll
    Console.WriteLine("--- Royal D20 Dice Roller ---");
    Console.WriteLine($"App Version: {VERSION}");
    Console.WriteLine("Good luck, brave knight!");
    Console.Write("Press Enter to roll the D20!");
    Console.ReadLine();

    // Use our new Dice class to roll!
    int roll = d20.Roll(); 

    Console.WriteLine($"\n** YOU ROLLED A {roll}! **");

    if (roll == 20)
    {
        Console.WriteLine("CRITICAL SUCCESS! The crowd cheers for the brave knight!");
    }
    else if (roll == 1)
    {
        Console.WriteLine("CRITICAL FAILURE! Oh no, the dice fell off the table!");
    }
    Console.WriteLine("-----------------------------");

    // Ask the user to play again
    Console.Write("Roll again? (Y/n): ");
    string? choice = Console.ReadLine();

    if (choice?.ToLower() == "n")
    {
        keepPlaying = false;
    }
}

Console.WriteLine("Thank you for playing!");