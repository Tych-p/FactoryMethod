using UnityEngine;

public abstract class FruitFactory : MonoBehaviour
{
    public abstract Fruit CreateFruit(Vector3 spawnPosition, RarityType fruitRarity); 
}
