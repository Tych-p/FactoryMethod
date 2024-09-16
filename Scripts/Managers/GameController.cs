using System;
using UnityEditor.TextCore.Text;
using UnityEngine;

public enum MyEnum
{
    Test1,
    Test2
}
public class GameController : MonoBehaviour
{
    [SerializeField] private FruitFactory _bananaFactory;
    [SerializeField] private FruitFactory _appleFactory;

    private void Start()
    {
        IFruit apple = SpawnFruit(_appleFactory, new Vector3(0, 0, 0));
        apple.ShowInfo();

        IFruit banana = SpawnFruit(_bananaFactory, new Vector3(5, 0, 0));
        banana.ShowInfo();
    }
    
    public IFruit SpawnFruit(FruitFactory factory, Vector3 position)
    {
        IFruit fruit = factory.CreateFruit(position);

        return fruit;
    }
}


