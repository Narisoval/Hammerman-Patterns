using HammermenPatterns.Bridge.Implementations;

namespace HammermenPatterns.Bridge.Abstractions;

public class Controls
{
    protected IDrinkMakingMachine _drinkMakingMachine;

    private const int DefaultVolume = 250;
    private const int VolumeIncrease = 10;

    private const int DefaultTemperature = 75;
    private const int TemperatureIncrease = 5;
    
    public Controls(IDrinkMakingMachine drinkMakingMachine)
    {
        _drinkMakingMachine = drinkMakingMachine;
        _drinkMakingMachine.Volume = DefaultVolume;
        _drinkMakingMachine.Temperature = DefaultTemperature;
        _drinkMakingMachine.TurnedOn = false;
    }

    public void TogglePower()
    {
        Console.WriteLine("Toggling power of the machine... ");
        _drinkMakingMachine.TurnedOn = !_drinkMakingMachine.TurnedOn;

        if (_drinkMakingMachine.TurnedOn)
        {
            Console.WriteLine("Machine is now turning on... ");
            return;
        }
        
        Console.WriteLine("Machine is now turning off... ");
    }

    public void IncreaseVolume()
    {
        Console.WriteLine($"Increasing volume by {VolumeIncrease}... ");
        
        if(_drinkMakingMachine.TurnedOn)
            _drinkMakingMachine.Volume += VolumeIncrease;
        
        PrintVolume();
    }
    
    public void DecreaseVolume()
    {
        Console.WriteLine($"Decreasing volume by {VolumeIncrease}... ");
        if(_drinkMakingMachine.TurnedOn)
            _drinkMakingMachine.Volume -= VolumeIncrease;
        
        PrintVolume();
    }

    public void IncreaseTemperature()
    {
        Console.WriteLine($"Increasing temperature by {VolumeIncrease}... ");
        if(_drinkMakingMachine.TurnedOn)
            _drinkMakingMachine.Temperature += TemperatureIncrease;
        
        PrintTemperature();
    }
    
    public void DecreaseTemperature()
    {
        Console.WriteLine($"Decreasing temperature by {VolumeIncrease}... ");
        if(_drinkMakingMachine.TurnedOn)
            _drinkMakingMachine.Temperature -= TemperatureIncrease;
        
        PrintTemperature();
    }

    public void MakeDrink()
    {
        if(_drinkMakingMachine.TurnedOn)
            _drinkMakingMachine.MakeDrink();
    }
    
    private void PrintVolume()
    {
        Console.WriteLine($"Volume now is {_drinkMakingMachine.Volume}.");
    }

    private void PrintTemperature()
    {
        Console.WriteLine($"Temperature now is {_drinkMakingMachine.Temperature}.");
    }
}