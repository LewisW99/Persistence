using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        UpdateScoreText();
    }

    public void AddPoint()
    {
        ScoreManager.Instance.AddScore(1);
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + ScoreManager.Instance.Score;
    }
}
