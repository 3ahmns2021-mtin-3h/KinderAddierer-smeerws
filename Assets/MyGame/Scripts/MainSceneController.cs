using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainSceneController : MonoBehaviour
{
    public PlayerData playerData;
    public AdditonController playerAddition;
    public Button checkSum, switchScene;
    public Image bgImage;
    public Text currentAttempt;
    public Text playerName;

    private int maxNumberAttempts = 10;
    private int numberAttempts = 0;

    private int correctAttempts = 0;

    private void Start()
    {
        playerName.text = playerData.playerName;
        currentAttempt.text = maxNumberAttempts.ToString() + "/10";
    }

    public void CheckAddition()
    {
        if (!playerAddition.ValuesParsable())
        {
            return;
        }

        playerAddition.ResetInputFieldColor();
        Debug.Log("After Return");

        if (playerAddition.CheckAdditionResult())
        {
            correctAttempts++;
            bgImage.color = Color.green;
        }
        else
        {
            bgImage.color = Color.red;
        }

        playerAddition.SetInputFieldsInteractible(false);
    }

    public void NextAttempt()
    {
        if (numberAttempts > maxNumberAttempts -1)
        {
            playerData.correctAttempts = correctAttempts;
            correctAttempts = 0;
            SceneManager.LoadScene("EndScene");
        }
        else
        {
            Debug.Log(numberAttempts);
            numberAttempts++;

            playerAddition.NewRandomSum();
            playerAddition.SetInputFieldsInteractible(true);
            bgImage.color = Color.blue;
            currentAttempt.text = (maxNumberAttempts - numberAttempts).ToString() + "/10";
        }
    }
}
