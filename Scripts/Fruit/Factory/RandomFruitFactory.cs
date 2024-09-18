using System.Collections.Generic;
using UnityEngine;

public class RandomFruitFactory : MonoBehaviour
{
    [SerializeField] private FruitFactory _bananaFactory;
    [SerializeField] private FruitFactory _appleFactory;
    
    [SerializeField] private float commonChance = 0.5f;
    [SerializeField] private float uncommonChance = 0.3f;
    [SerializeField] private float epicChance = 0.15f;
    [SerializeField] private float legendaryChance = 0.05f;

    [SerializeField] List<FruitType> fruits;
    
    [SerializeField] private float appleChance = 0.5f;
    [SerializeField] private float bananaChance = 0.5f;    

    public Fruit SpawnRandomFruit(Vector3 spawnPosition)
    {
        FruitType fruitType = GetRandomFruit();
        RarityType fruitRarity = GetRandomRarity();

        Fruit spawnedFruit = null;

        switch (fruitType)
        {
            case FruitType.Apple:
                spawnedFruit = _appleFactory.CreateFruit(spawnPosition, fruitRarity);
                break;
            case FruitType.Banana:
                spawnedFruit = _bananaFactory.CreateFruit(spawnPosition, fruitRarity);
                break;
            default:
                spawnedFruit = _appleFactory.CreateFruit(spawnPosition, fruitRarity);
                break;
        }

        if (spawnedFruit is not null)
        {
            spawnedFruit.ShowInfo();
        }
        
        return spawnedFruit;
    }

    private RarityType GetRandomRarity()
    {
        float randomValue = Random.Range(0f, 1f);

        if (randomValue <= legendaryChance)
        {
            return RarityType.Legendary;
        }
        else if (randomValue <= legendaryChance + epicChance)
        {
            return RarityType.Epic;
        }
        else if (randomValue <= legendaryChance + epicChance + uncommonChance)
        {
            return RarityType.Uncommon;
        }
        else
        {
            return RarityType.Common;
        }
    }

    private FruitType GetRandomFruit()
    {
        return fruits[Random.Range(0, fruits.Count)];
    }
}
