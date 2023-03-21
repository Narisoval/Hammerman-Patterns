namespace HammermenPatterns.Bridge.Implementations;

public class TeaMaker : IDrinkMakingMachine
{
    public int Temperature { get; set; }
    public int Volume { get; set; }
    
    public bool TurnedOn { get; set; }

    public void MakeDrink()
    {
        Console.WriteLine($"Making {Volume} of tea that is {Temperature} degrees hot");
    }
}