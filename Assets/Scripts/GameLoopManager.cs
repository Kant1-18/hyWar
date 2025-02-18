using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLoopManager : MonoBehaviour
{
    public Text scoreText; 

    private void Start()
    {
        // Vérifie si un score est stocké et l'affiche
        if (scoreText != null)
        {
            int finalScore = PlayerPrefs.GetInt("FinalScore", 0);
            scoreText.text = "Your score is : " + finalScore;
        }
    }

    // Fonction à appeler quand le joueur perd
    public static void GameOver(int score)
    {
        PlayerPrefs.SetInt("FinalScore", score);
        PlayerPrefs.Save(); 
        SceneManager.LoadScene("GameLoop");
    }

    public void RestartGame()
    {
        Debug.Log("Bouton Restart cliqué ! Changement vers Game...");
        SceneManager.LoadScene("Game");
    }

    public void GoToMenu()
    {
        Debug.Log("Bouton Menu cliqué ! Changement vers Menu...");
        SceneManager.LoadScene("Menu");
    }
}
