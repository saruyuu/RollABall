using UnityEngine;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    //GameOver��\������TextMeshProUGUI�^�̕ϐ�
    public TextMeshProUGUI clearText;

    public ScoreManager scoreManager;
    public void GameOver()
    {
        scoreManager.isGameFinished = true; 
        clearText.text = "Game\nOver!!!";
        clearText.gameObject.SetActive(true);
    }
  
}
