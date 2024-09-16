using UnityEngine;

public class Banana : MonoBehaviour, IFruit
{
    public void ShowInfo()
    {
        Debug.Log("This is a banana");
    } 
}