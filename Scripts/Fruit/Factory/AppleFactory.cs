using UnityEngine;
public class AppleFactory : FruitFactory
{
    [SerializeField] private GameObject _commonApplePrefab;
    [SerializeField] private GameObject _uncommonApplePrefab;
    [SerializeField] private GameObject _epicApplePrefab;
    [SerializeField] private GameObject _legendaryApplePrefab;

    public override Fruit CreateFruit(Vector3 spawnPosition, RarityType rarity)
    {
        GameObject apple;
        
        switch (rarity)
        {
            case RarityType.Common:
                apple = Instantiate(_commonApplePrefab, spawnPosition, Quaternion.identity);
                break;
            case RarityType.Uncommon:
                apple = Instantiate(_uncommonApplePrefab, spawnPosition, Quaternion.identity);
                break;
            case RarityType.Epic:
                apple = Instantiate(_epicApplePrefab, spawnPosition, Quaternion.identity);
                break;
            case RarityType.Legendary:
                apple = Instantiate(_legendaryApplePrefab, spawnPosition, Quaternion.identity);
                break;
            
            default:
                apple = Instantiate(_commonApplePrefab, spawnPosition, Quaternion.identity);
                break;  
        }

        return apple.GetComponent<Fruit>();
    }

}

