using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class SceneHandler : MonoBehaviour
{
    //[SerializeField] private UnityEvent onDamageTaken;

    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void NextLevel()
    {
        int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
        currentLevelIndex++;
        SceneManager.LoadScene(currentLevelIndex);
    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting Game");
    }
}
