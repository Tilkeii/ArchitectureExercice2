namespace RCorpFoodPricer.App
{
  public class Meal {
    private float TotalPrice = 0.0f;
    private IMainCourse MainCourse;
    private IDrink Drink;
    private IDessert Dessert;
    private bool Coffee;

    public Meal(MealBuilder builder) {
      this.TotalPrice = builder.TotalPrice;
      this.MainCourse = builder.MainCourse;
      this.Drink = builder.Drink;
      this.Dessert = builder.Dessert;
    }

    public float GetTotalPrice() {
      return this.TotalPrice;
    }
  }
}