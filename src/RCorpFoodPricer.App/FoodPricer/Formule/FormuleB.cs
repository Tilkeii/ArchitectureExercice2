
namespace RCorpFoodPricer.App
{
  public class FormuleB : IFormule
  {
    public IMainCourse MainCourse => new PlateMeal();

    public IDrink Drink => new LargeDrink();

    public IDessert Dessert => new SpecialDessert();

    public bool Coffee => false;

    public float Price => 21.0f;
  }
}