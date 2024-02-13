using System;
using System.Collections.Generic;

public class FruitStand
{
    private List<FruitStand> stash;

    public FruitStand()
    {
        stash = new List<FruitStand>();
    }

    public void AddFruit(Fruit fruit)
    {
        stash.Add(fruit);
    }

   public double Cost (int quantity)
    {
        double cost = 0;
        foreach (var fruit in stash)
        {
            cost += fruit.Cost(quantity);
        }
        return cost;
    }
}