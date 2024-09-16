using UnityEngine;

public abstract class FruitFactory : MonoBehaviour
{
    public abstract IFruit CreateFruit(Vector3 spawnPosition); 
}
