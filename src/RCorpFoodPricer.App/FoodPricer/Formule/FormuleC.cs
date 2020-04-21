
namespace RCorpFoodPricer.App
{
  public class FormuleC : IFormule
  {
    public IMainCourse MainCourse => new SandwichMeal();

    public IDrink Drink => new MediumDrink();

    public IDessert Dessert => new NormalDessert();

    public bool Coffee => false;

    public float Price => 13.0f;
  }
}