using UnityEngine;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    //GameOver‚ğ•\¦‚·‚éTextMeshProUGUIŒ^‚Ì•Ï”
    public TextMeshProUGUI clearText;

    public ScoreManager scoreManager;
    public void GameOver()
    {
        scoreManager.isGameFinished = true; 
        clearText.text = "Game\nOver!!!";
        clearText.gameObject.SetActive(true);
    }
  
}
