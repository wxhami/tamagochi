using Tamagochi;

Console.Write("Enter name your pet: ");
string name = Console.ReadLine();
Console.Write("Enter color your pet: ");
string color = Console.ReadLine();

Pet pet = new Pet(name, color);

while (pet.IsAlive)
{

    Console.WriteLine("\nChoose action with your pet: 1 - play, 2 - feed, 3 - playing sport, 4 - show characteristics");
    int action = Convert.ToInt32(Console.ReadLine());
    
    Console.Clear();
    
    pet.Action((PetActionType)action);
    
    
}

if (pet.Age >= 20)
{
    Console.WriteLine("Your pet is died of old age");
}

if (pet.Hungry >= 10)
{
    Console.WriteLine("Your pet is died of hunger");
}

if (pet.Weight >= 10)
{
    Console.WriteLine("Your pet is died of obesity");
}

