namespace RCorpFoodPricer.App
{
  public interface IFormule
  {
    IMainCourse MainCourse {get;}
    IDrink Drink {get;}
    IDessert Dessert {get;}

    bool Coffee {get;}
    float Price {get;}

  }
}