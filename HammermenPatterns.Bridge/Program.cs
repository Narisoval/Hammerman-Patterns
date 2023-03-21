using HammermenPatterns.Bridge.Abstractions;
using HammermenPatterns.Bridge.Implementations;


static void MakeGreatDrink(IDrinkMakingMachine drinkMakingMachine)
{
    var coffeeMakerControls = new Controls(drinkMakingMachine);
    
    coffeeMakerControls.TogglePower();
    
    coffeeMakerControls.DecreaseVolume(); 
    coffeeMakerControls.IncreaseTemperature();
    
    coffeeMakerControls.MakeDrink();
}

var coffeeMaker = new CoffeeMaker();
MakeGreatDrink(coffeeMaker);