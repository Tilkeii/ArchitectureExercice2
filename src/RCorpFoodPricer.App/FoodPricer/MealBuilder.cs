namespace RCorpFoodPricer.App
{
  public class MealBuilder
  {
    public float TotalPrice = 0.0f;
    public IMainCourse MainCourse;
    public IDrink Drink;
    public IDessert Dessert;
    public bool Coffee;

    public MealBuilder AddMainCourse(IMainCourse mainCourse)
    {
      this.MainCourse = mainCourse;
      this.TotalPrice += mainCourse.Price;
      return this;
    }

    public MealBuilder AddDrink(IDrink drink)
    {
      this.Drink = drink;
      this.TotalPrice += drink.Price;
      return this;
    }

    public MealBuilder AddDesert(IDessert dessert)
    {
      this.Dessert = dessert;
      this.TotalPrice += dessert.Price;
      return this;
    }

    public MealBuilder HasCoffee(bool coffee)
    {
      this.Coffee = coffee;
      this.TotalPrice += 1.0f;
      return this;
    }

    public Meal BuildWithFormule(IFormule formule) {
      this.TotalPrice = formule.Price;
      this.MainCourse = formule.MainCourse;
      this.Drink = formule.Drink;
      this.Dessert = formule.Dessert;
      this.Coffee = formule.Coffee;

      return Build();
    }

    public Meal Build() {
      return new Meal(this);
    }

  }
}