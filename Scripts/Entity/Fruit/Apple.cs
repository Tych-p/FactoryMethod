using UnityEngine;
using UnityEngine.PlayerLoop;

public class Apple : MonoBehaviour, IFruit
{
    public void ShowInfo()
    {
        Debug.Log("This is apple");
    }
}
