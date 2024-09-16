using UnityEngine;
public class AppleFactory : FruitFactory
{
    [SerializeField] private GameObject _applePrefab;

    public override IFruit CreateFruit(Vector3 spawnPosition)
    {
        GameObject apple = Instantiate(_applePrefab, spawnPosition, Quaternion.identity);

        return apple.GetComponent<IFruit>();
    }

}

