public class FreshFruit : Fruit
{
    public string Season { get; set; }

    public FreshFruit(string name, double price, string season) : base(name, price)
    {
        Season = season;
    }

}