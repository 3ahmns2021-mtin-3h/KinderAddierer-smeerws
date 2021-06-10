using UnityEngine;
using UnityEngine.UI;

public class WelcomeScenecontroller : MonoBehaviour
{
    public PlayerData playerData;
    public Text txtPlayerName;
    public InputField ifPlayerName;

    // Start is called before the first frame update
    void Start()
    {
        txtPlayerName.gameObject.SetActive(false);
        ifPlayerName.gameObject.SetActive(false);

        if (playerData.isPlaying)
        {
            txtPlayerName.gameObject.SetActive(true);
            txtPlayerName.text = playerData.playerName;
        }
        else
        {
            ifPlayerName.gameObject.SetActive(true);
        }
    }

    public void WriteDataToPlayerData()
    {
        if (!playerData.isPlaying)
        {
            playerData.playerName = ifPlayerName.text;
            playerData.isPlaying = true;
        }

    }
}
