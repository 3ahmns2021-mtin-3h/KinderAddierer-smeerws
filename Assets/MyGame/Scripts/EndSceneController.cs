using UnityEngine;
using UnityEngine.UI;

public class EndSceneController : MonoBehaviour
{
    public PlayerData playerData;
    public Text playerName;
    public Text correctAnswers;
        
    void Start()
    {
        playerName.text = playerData.playerName;
        correctAnswers.text = playerData.correctAttempts.ToString() + "/10";
    }

    
}
