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

    public Pet(string name, string color)
    {
        Name = name;
        Color = color;
        Mood = 0;
        Weight = 0;
        Hungry = 0;
        Age = 0;
    }

    public void ShowPet()
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

    public void Eat()
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

        Age++;
    }

    public void Play()
    {
        Age++;
        if (Mood == 0)
        {
            Weight += 2;
        }

        Mood += 2;
        Hungry += 2;
    }

    public void GetSport()
    {
        Age++;

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

    public bool CheckAlive()
    {
        if (Hungry == 10 || Weight == 10.0 || Age == 20)
        {
            return false;
        }

        return true;
    }
}