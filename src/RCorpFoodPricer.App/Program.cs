using System;

namespace RCorpFoodPricer.App
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      IMainCourse plateMeal = new PlateMeal();
      IDrink smallDrink = new SmallDrink();
      IDessert NormalDessert = new NormalDessert();

      Meal meal = new MealBuilder()
        .AddMainCourse(plateMeal)
        .AddDrink(smallDrink)
        .AddDesert(NormalDessert)
        .HasCoffee(true)
        .Build();

      Console.WriteLine("Price : " + meal.GetTotalPrice());

      IFormule formuleA = new FormuleA();
      Meal mealWithFormule = new MealBuilder()
        .BuildWithFormule(formuleA);

      Console.WriteLine("Formule A : " + mealWithFormule.GetTotalPrice());
      
    }
  }
}
