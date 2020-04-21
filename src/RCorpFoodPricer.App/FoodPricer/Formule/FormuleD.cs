
namespace RCorpFoodPricer.App
{
  public class FormuleD : IFormule
  {
    public IMainCourse MainCourse => new SandwichMeal();

    public IDrink Drink => new LargeDrink();

    public IDessert Dessert => new SpecialDessert();

    public bool Coffee => false;

    public float Price => 16.0f;
  }
}