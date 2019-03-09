using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject ButtonOne;
    public GameObject ButtonTwo;

   public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void TraceOne()
    {
        SceneManager.LoadScene(2);
    }

    public void TraceTwo()
    {
        SceneManager.LoadScene(3);
        Coins.TotalCash -= 20;
    }


}
