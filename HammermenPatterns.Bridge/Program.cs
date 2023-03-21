using HammermenPatterns.Bridge;
using HammermenPatterns.Bridge.Abstractions;
using HammermenPatterns.Bridge.Implementations;


static void MakeGreatCoffee()
{
    var coffeeMaker = new CoffeeMaker();
    var coffeeMakerControls = new Controls(coffeeMaker);
    
    coffeeMakerControls.TogglePower();
    
    coffeeMakerControls.DecreaseVolume(); 
    coffeeMakerControls.IncreaseTemperature();
    
    coffeeMakerControls.MakeDrink();
}
MakeGreatCoffee();