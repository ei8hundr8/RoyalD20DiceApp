// Simple D20 Dice Roller App
// V1.1 - Add version check
const string VERSION = "1.1";
Random random = new Random();

Console.WriteLine("--- Royal D20 Dice Roller ---");
Console.WriteLine($"App version: {VERSION}\n");
Console.Write("Press Enter to roll the D20!\n");
Console.WriteLine("Good luck, brave knight!");
Console.ReadLine();

// Generate a random number between 1 and 20 (inclusive)
int roll = random.Next(1, 21);

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
Console.WriteLine("Press Enter to exit.");
Console.ReadLine();
