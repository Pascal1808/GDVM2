using TMPro;
using UnityEngine;

public class uiScoreBoard : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreField;
    [SerializeField] private TextMeshProUGUI multiplierField;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
       ComboSystem.OnScoreChange += UpdateUI; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        ComboSystem.OnScoreChange -= UpdateUI;
    }

    private void UpdateUI(int score, int multiplier)
    {
        scoreField.text = " score: " + score;
        multiplierField.text = " multiplier: x" + multiplier;
    }
}
