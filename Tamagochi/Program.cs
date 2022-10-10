using Tamagochi;

Console.WriteLine("Enter name your pet");
string name = Console.ReadLine();
Console.WriteLine("Enter color your pet");
string color = Console.ReadLine();

Pet pet = new Pet(name, color);


pet.ShowPet();