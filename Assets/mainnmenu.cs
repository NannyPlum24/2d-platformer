using UnityEngine;
using UnityEngine.SceneManagement;

public class mainnmenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void PlayGame()
    {
        SceneManager.LoadScene("back");

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}