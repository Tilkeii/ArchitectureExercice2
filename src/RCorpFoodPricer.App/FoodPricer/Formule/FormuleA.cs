
namespace RCorpFoodPricer.App
{
  public class FormuleA : IFormule
  {
    public IMainCourse MainCourse => new PlateMeal();

    public IDrink Drink => new MediumDrink();

    public IDessert Dessert => new NormalDessert();

    public bool Coffee => false;

    public float Price => 18.0f;

  }
}