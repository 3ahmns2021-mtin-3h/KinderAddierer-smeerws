using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public WelcomeScenecontroller welcomeController;

   public void SwitchToMainScene()
    {
        welcomeController.WriteDataToPlayerData();
        SceneManager.LoadScene("MainScene");
    }

    public void SwitchToWelcomeScene()
    {
        SceneManager.LoadScene("WelcomeScene");
    }
}
