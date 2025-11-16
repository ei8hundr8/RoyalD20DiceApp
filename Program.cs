// Simple D20 Dice Roller App
// V1.0 - Initial Release
Random random = new Random();

Console.WriteLine("--- Royal D20 Dice Roller - Version 1.0 ---");
Console.Write("Press Enter to roll the D20!\n");
Console.WriteLine("Good luck, brave knight!");
Console.ReadLine();

// Generate a random number between 1 and 20 (inclusive)
int roll = random.Next(1, 21);

Console.WriteLine($"\n** YOU ROLLED A {roll}! **");

if (roll == 20)
{
	Console.WriteLine("CRITICAL SUCCESS! A roll worthy of a knight!");
}
else if (roll == 1)
{
	Console.WriteLine("CRITICAL FAILURE! Better luck next time!");
}
Console.WriteLine("-----------------------------");
Console.WriteLine("Press Enter to exit.");
Console.ReadLine();