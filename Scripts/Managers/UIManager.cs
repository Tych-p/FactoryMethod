using System;
using TMPro;
using UnityEngine;

public class UIManager: MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _currentScore;
    
    private void OnEnable()
    {
        EventBus.Instance.ScoreChange += DisplayScore;
    }

    private void OnDisable()
    {
        EventBus.Instance.ScoreChange -= DisplayScore;
    }

    private void DisplayScore(int points)
    {
        _currentScore.text = (Int32.Parse(_currentScore.text) + points).ToString();
    }
}
