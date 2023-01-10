using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Handles game over
    bool gameEnded = false;
    public float restartDelay = 3f;

    public GameObject objectiveUI;
    public GameObject gameOver;

    private void Update()
    {
        
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOver.SetActive(false);
    }
}
