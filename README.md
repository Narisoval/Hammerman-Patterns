# Table of Contents
- [Bridge Pattern](#bridge-pattern)
  * [Overview](#overview)
   
# Bridge Pattern 
In this example, we demonstrate the Bridge design 
pattern using a drink making machine scenario. 
The Bridge pattern is a structural design pattern that decouples an abstraction from 
its implementation, allowing both to vary independently.

## Overview
The main components in this example are:

1. **IDrinkMakingMachine** interface: This interface provides a common abstraction for all types of drink making machines.
2. **CoffeeMaker** and **TeaMaker** classes: These classes represent the concrete implementations of the IDrinkMakingMachine interface.
3. **Controls** class: This class serves as a higher-level abstraction that decouples from the specific implementations. It works with the IDrinkMakingMachine interface and can control any machine implementing the interface.
 
