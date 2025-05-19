using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int Score { get; private set; }

    private const string SaveKey = "PlayerScore";

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); //  Persist across scenes
        }

        LoadScore();
    }

    public void AddScore(int amount)
    {
        Score += amount;
        SaveScore();
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt(SaveKey, Score);
        PlayerPrefs.Save();
    }

    public void LoadScore()
    {
        Score = PlayerPrefs.GetInt(SaveKey, 0);
    }
}
