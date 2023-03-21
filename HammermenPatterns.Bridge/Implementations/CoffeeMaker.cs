namespace HammermenPatterns.Bridge.Implementations;

public class CoffeeMaker : IDrinkMakingMachine
{
    public int Temperature { get; set; }
    
    public int Volume { get; set; }
    
    public bool TurnedOn { get; set; }
    
    public void MakeDrink()
    {
        Console.WriteLine($"Making {Volume} ml of coffee that is {Temperature} degrees hot");
    }

}