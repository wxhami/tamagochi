using System.Drawing;
using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace Tamagochi;

public class Pet
{
   public int Mood;
   public string Name;
   public string Color;
   public int Weight;
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
      Console.WriteLine($"Name: {Name} \nColor: {Color} \nMood: {GetMood()} \nWeight: {Weight} \nHungry: {Hungry} \nAge: {Age}");
   }

   public string GetMood()
   {
      if (Mood <= 3 && Mood >= 1)
      {
         return "sad";
      }
      else if (Mood <= 6 && Mood >= 4) 
      {
         return "normal";
      }
      else if (Mood <= 10 && Mood >= 5)
      {
         return "happy";
      }

      return "depression";
   }
}

