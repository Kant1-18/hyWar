using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GamePauseManager : MonoBehaviour
{
    [Header("Références UI")]
    public Text countdownText;  // Texte du décompte
    public Button resumeButton; // Bouton "Resume"

    [Header("Paramètres du Countdown")]
    public float countdownTime = 3f;  // Temps du décompte en secondes

    private bool isCountingDown = false;

    private void Start()
    {
        // Met le jeu en pause
        Time.timeScale = 0f;

        // Masque le texte du décompte au démarrage
        if (countdownText != null)
        {
            countdownText.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogWarning("CountdownText n'est pas assigné dans l'inspecteur !");
        }

        // Associe la fonction StartCountdown() au clic du bouton Resume
        if (resumeButton != null)
        {
            resumeButton.onClick.AddListener(StartCountdown);
        }
        else
        {
            Debug.LogWarning("ResumeButton n'est pas assigné dans l'inspecteur !");
        }
    }

    // Appelé uniquement quand on clique sur le bouton Resume
    private void StartCountdown()
    {
        if (!isCountingDown)
        {
            Debug.Log("Début du décompte pour reprendre le jeu...");
            StartCoroutine(CountdownAndResume());
        }
    }

    // Coroutine pour le décompte de 3 secondes avant de reprendre le jeu
    private IEnumerator CountdownAndResume()
    {
        isCountingDown = true;

        // Affiche le texte du décompte
        if (countdownText != null)
        {
            countdownText.gameObject.SetActive(true);
        }

        float countdown = countdownTime;
        while (countdown > 0f)
        {
            int secondsLeft = Mathf.CeilToInt(countdown);
            if (countdownText != null)
            {
                countdownText.text = secondsLeft.ToString();
            }
            yield return null;  // Attend la frame suivante
            countdown -= Time.unscaledDeltaTime;  // Utilise le delta non affecté par la pause
        }

        ResumeGame();
    }

    public void ResumeGame()
    {
        // Réactive le temps
        Time.timeScale = 1f;

        // Avant de décharger la scène de pause, assure-toi que la scène "Game" est active
        Scene gameScene = SceneManager.GetSceneByName("Game");
        if (gameScene.IsValid())
        {
            SceneManager.SetActiveScene(gameScene);
        }
        else
        {
            Debug.LogWarning("La scène 'Game' n'est pas chargée !");
        }

        // Décharge la scène de pause pour reprendre le jeu sans perdre son état
        SceneManager.UnloadSceneAsync("GamePause");
    }

    public void GoToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }
}
