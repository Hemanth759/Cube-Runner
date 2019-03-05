using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsButtons : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quiting!!");
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene("Level01");
    }
}
