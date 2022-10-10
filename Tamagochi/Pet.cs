using System.Drawing;
using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace Tamagochi;

public class Pet
{
    public int Mood;
    public string Name;
    public string Color;
    public double Weight;
    public int Hungry;
    public int Age;

    public bool IsAlive => CheckAlive();

    public Pet(string name, string color)
    {
        Name = name;
        Color = color;
        Mood = 0;
        Weight = 0;
        Hungry = 0;
        Age = 0;
    }

    public void Action(PetActionType action)
    {
        if (action == PetActionType.Show)
        {
            ShowPet();
        }
        else
        {
            Age++;

            Animation(GetStringAction(action));

            switch (action)
            {
                case PetActionType.Play:
                    Play();
                    break;
                case PetActionType.Eat:
                    Eat();
                    break;
                case PetActionType.Sport:
                    Sport();
                    break;
            }
        }
    }

    private void ShowPet()
    {
        Console.WriteLine(
            $"Name: {Name} \nColor: {Color} \nMood: {GetMood()} \nWeight: {Weight} \nHungry: {Hungry} \nAge: {Age}");
    }

    private string GetMood()
    {
        if (Mood is <= 3 and >= 1)
        {
            return "sad";
        }

        if (Mood <= 6 && Mood >= 4)
        {
            return "normal";
        }

        if (Mood <= 10 && Mood >= 5)
        {
            return "happy";
        }

        return "depression";
    }

    private void Eat()
    {
        if (Hungry == 0)
        {
            Weight++;
        }

        if (Hungry > 0 && Hungry < 4)
        {
            Hungry = 0;
        }

        if (Hungry >= 4)
        {
            Weight += 0.3;
            Hungry -= 3;
            Mood += 1;
        }

        if (Mood == 0)
        {
            Weight += 2;
        }
    }

    private void Play()
    {
        if (Mood == 0)
        {
            Weight += 2;
        }

        Mood += 2;
        Hungry += 2;
    }

    private void Sport()
    {
        if (Mood > 0)
        {
            Weight -= 1;
        }

        if (Mood == 0)
        {
            Weight += 2;
        }

        Hungry += 3;
        Mood -= 1;
    }

    private bool CheckAlive()
    {
        if (Hungry >= 10 || Weight >= 10.0 || Age >= 20)
        {
            return false;
        }

        return true;
    }

    private void Animation(string action)
    {
        Console.Write(action);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
    }

    private string GetStringAction(PetActionType action)
    {
        return action switch
        {
            PetActionType.Eat => "Eating",
            PetActionType.Play => "Playing",
            PetActionType.Sport => "Training"
        };
    }
}