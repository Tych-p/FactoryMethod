using UnityEngine;
using UnityEngine.PlayerLoop;

public class Apple : Fruit
{
    public Apple(RarityType rarity) : base(FruitType.Apple, rarity, 25) { }
}
