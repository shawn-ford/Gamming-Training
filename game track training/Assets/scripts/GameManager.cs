using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static int score;
    public TextMeshProUGUI scoreText;
    public GameObject victoryTextObject;


    void Start()
    {
        score = 0;
        UpdateUI();
        victoryTextObject.SetActive(false);
    }


    public void UpdateScore(int amount)
    {
        score += amount;
        UpdateUI();


        if (score == 5)
        {
            WinGame();
        }
    }


    public void UpdateUI()
    {
        scoreText.text = score.ToString();
    }


    public void WinGame()
    {
        victoryTextObject.SetActive(true);
    }
}


