// See https://aka.ms/new-console-template for more information
using UnaPizza;

Console.WriteLine("Willkommen beim PizzaBuilder!");
Console.WriteLine("Wir erstellen eine Pizza Schritt für Schritt");
Console.WriteLine("");

//Erstellung der Pizza
Pizza pizza = new PizzaBuilder()
    .SetSize("Large")
    .AddCheese()
    .AddTomatoes()
    .AddPepperoni()
    .AddOlives()
    .Build();

//Ausgabe der fertigen Pizza
Console.WriteLine("Ihre Pizza wurde erstellt:");
Console.WriteLine($"Pizza [Size: {pizza.Size}, Cheese: {pizza.HasCheese}, Pepperoni: {pizza.HasPepperoni}, Tomatoes: {pizza.HasTomatoes}, Olives: {pizza.HasOlives}]");
Console.WriteLine("");

Console.WriteLine("Drücken Sie eine beliebige Taste um das Programm zu beenden");
Console.ReadKey();

