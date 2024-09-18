using UnityEngine;
using UnityEngine.EventSystems;
public class Fruit : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] int points;
    public FruitType type;
    public RarityType rarity;

    public Fruit(FruitType type, RarityType rarity, int points)
    {
        this.points = points;
        this.type = type;
        this.rarity = rarity;
    }

    public void DropInBox()
    {
        EventBus.Instance.ScoreChange?.Invoke(this.points);
        Destroy(gameObject);
    }

    public void ShowInfo()
    {
        Debug.Log(type.ToString() + " " + rarity.ToString() + " " + points.ToString());
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        EventBus.Instance.ScoreChange?.Invoke(this.points);
        ShowInfo();
        Destroy(gameObject);
    }
}
