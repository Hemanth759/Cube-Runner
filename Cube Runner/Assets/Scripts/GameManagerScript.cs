using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    bool GameHasEnded = false;

    public float RestartDelay = 2f;
    public GameObject CompleteLevelUI;

    public void GameComplete()
    {
        CompleteLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if(GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Game has ended");
            Invoke("Restart", RestartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
