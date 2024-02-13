class Program
{
    static void Main(string[] args)
    {
        FruitStand fruitStand = new FruitStand();

        FreshFruit apple = new FreshFruit("Apple", 1.50, "Fall");
        FreshFruit orange = new FreshFruit("Orange", 1.00, "All seasons");

        Dried raisins = new Dried("Raisins", 2.00, 12);

        fruitStand.AddFruit(apple);
        fruitStand.AddFruit(orange);

        fruitStand.DisplayStash();

        int quantity = 10;
        double Cost = fruitStand.Cost(quantity);
        Console.WriteLine($"Total for {quantity}: ${Cost}" + quantity);

        Console.ReadLine();
    }
}