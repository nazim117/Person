# Inheritance

# 1. Person
You are asked to model an application for storing data about people. You should be able to have a person and a child. 
The child derives from the person. Your task is to model the application. The only constraints are:
- People should not be able to have a negative age
- Children should not be able to have an age greater than 15.
 Person – represents the base class by which all of the others are implemented
 Child - represents a class, which derives from Person.

# 2. Zoo
Create a project Zoo. It needs to contain the following classes: 
Follow the diagram and create all of the classes. Each of them, except the Animal class, should inherit from 
another class. Every class should have:
 A constructor, which accepts one parameter: name. 
 Property Name - string.

# 3. Players and Monsters
Your task is to create the following game hierarchy: 
Create a class Hero. It should contain the following members:
 A constructor, which accepts:
o username – string
o level – int
 The following properties:
o Username - string
o Level – int
 ToString() method

# 4. Need for Speed
Create a base class Vehicle. It should contain the following members:
 A constructor that accepts the following parameters: int horsePower, double fuel
 DefaultFuelConsumption – double 
 FuelConsumption – virtual double
 Fuel – double
 HorsePower – int
 virtual void Drive(double kilometers)
o The Drive method should have a functionality to reduce the Fuel based on the traveled 
kilometers.
The default fuel consumption for Vehicle is 1.25. Some of the classes have different default fuel consumption 
values:
 SportCar – DefaultFuelConsumption = 10
 RaceMotorcycle – DefaultFuelConsumption = 8
 Car – DefaultFuelConsumption = 3

# 5. Restaurant
Create a Restaurant project with the following classes and hierarchy:
There are Food and Beverages in the restaurant, and they are all products. 
The Product class must have the following members:
 A constructor with the following parameters:
o Name – string
o Price – decimal
Beverage and Food classes are products. 
The Beverage class must have the following members:
 A constructor with the following parameters: string name, decimal price, double milliliters
o Reuse the constructor of the inherited class
 Name – string
 Price – decimal
 Milliliters – double
HotBeverage and ColdBeverage are beverages and they accept the following parameters upon initialization: 
string name, decimal price, double milliliters. Reuse the constructor of the inherited class.
Coffee and Tea are hot beverages. The Coffee class must have the following additional members:
 double CoffeeMilliliters = 50
 decimal CoffeePrice = 3.50
 Caffeine – double
The Food class must have the following members:
 A constructor with the following parameters: string name, decimal price, double grams
o Name – string
o Price – decimal
o Grams – double
MainDish, Dessert, and Starter are food. They all accept the following parameters upon initialization: string 
name, decimal price, double grams. Reuse the base class constructor.
Dessert must accept one more parameter in its constructor: double calories, and has a property:
 Calories
Make Fish, Soup and Cake inherit the proper classes. 
The Cake class must have the following default values:
 Grams = 250
 Calories = 1000
 CakePrice = 5
A Fish must have the following default values:
 Grams = 22

# 
