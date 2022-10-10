using Tamagochi;

Console.WriteLine("Enter name your pet");
string name = Console.ReadLine();
Console.WriteLine("Enter color your pet");
string color = Console.ReadLine();

Pet pet = new Pet(name, color);


Console.WriteLine("Choose action with your pet: 1 - play, 2 - feed, 3 - playing sport"); 
int action = Convert.ToInt32(Console.ReadLine());
if ( action == 1)
{
    pet.Play();
}

if (action == 2)
{
    pet.Eat();
}

if (action == 3)
{
    pet.GetSport();
}