using System.Resources;
using UnityEngine;

public class BananaFactory : FruitFactory
{
    [SerializeField] private GameObject _bananaPrefab;

    public override IFruit CreateFruit(Vector3 spawnPosition)
    {
        GameObject banana = Instantiate(_bananaPrefab, spawnPosition, Quaternion.identity);

        return banana.GetComponent<IFruit>();
    }
}
