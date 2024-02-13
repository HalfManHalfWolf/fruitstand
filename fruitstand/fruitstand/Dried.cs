public class Dried : Fruit
{
    public int sundried { get; set; }

    public Dried(string name, double price, int sundried) : base(name, price)
    {
        sundried = sundried;
    }
}