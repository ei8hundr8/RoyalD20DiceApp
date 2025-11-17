// Represents a single Die
public class Dice
{
    // We make the Random object 'static' so all dice share one
    private static Random _random = new Random();
    private int _sides;

    // Constructor
    public Dice(int sides)
    {
        _sides = sides;
    }

    // Roll method
    public int Roll()
    {
        // We add 1 because Next() is exclusive of the upper bound
        return _random.Next(1, _sides + 1);
    }
}