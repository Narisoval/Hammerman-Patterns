namespace HammermenPatterns.Bridge.Implementations;

public interface IDrinkMakingMachine
{
    public int Temperature { get; set; }
    
    public int Volume { get; set; }

    public bool TurnedOn { get; set; } 
    
    public void MakeDrink();
}