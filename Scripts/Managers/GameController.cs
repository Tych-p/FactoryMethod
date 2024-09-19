using System;
using UnityEditor.TextCore.Text;
using UnityEngine;
public class GameController : MonoBehaviour
{
    [SerializeField] private RandomFruitFactory _randomFruitFactory;

    private void Start()
    {
       
    }
    
    public void SpawnFruit()
    {
        Fruit fruit = _randomFruitFactory.SpawnRandomFruit(new Vector3(0, 0, 0));

        //return fruit;
    }
}


