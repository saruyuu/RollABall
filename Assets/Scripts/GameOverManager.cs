using UnityEngine;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    //GameOverを表示するTextMeshProUGUI型の変数
    public TextMeshProUGUI clearText;

    public ScoreManager scoreManager;
    public void GameOver()
    {
        scoreManager.isGameFinished = true; 
        clearText.text = "Game\nOver!!!";
        clearText.gameObject.SetActive(true);
    }
  
}
