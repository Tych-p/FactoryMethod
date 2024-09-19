using System.Resources;
using UnityEngine;

public class BananaFactory : FruitFactory
{
    [SerializeField] private GameObject _commonBananaPrefab;
    [SerializeField] private GameObject _uncommonBananaPrefab;
    [SerializeField] private GameObject _epicBananaPrefab;
    [SerializeField] private GameObject _legendaryBananaPrefab;

    public override Fruit CreateFruit(Vector3 spawnPosition, RarityType rarity)
    {
        GameObject banana;
        
        switch (rarity)
        {
            case RarityType.Common:
                banana = Instantiate(_commonBananaPrefab, spawnPosition, Quaternion.identity);
                break;
            case RarityType.Uncommon:
                banana = Instantiate(_uncommonBananaPrefab, spawnPosition, Quaternion.identity);
                break;
            case RarityType.Epic:
                banana = Instantiate(_epicBananaPrefab, spawnPosition, Quaternion.identity);
                break;
            case RarityType.Legendary:
                banana = Instantiate(_legendaryBananaPrefab, spawnPosition, Quaternion.identity);
                break;
            
            default:
                banana = Instantiate(_commonBananaPrefab, spawnPosition, Quaternion.identity);
                break;  
        }

        return banana.GetComponent<Fruit>();
    }
}
