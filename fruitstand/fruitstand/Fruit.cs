public class Fruit
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Fruit(string name, double price)
    {
        Name = name;
        Price = price;
    }
    public virtual double Cost(int quantity)
    {
        return Price * quantity;
    }
}