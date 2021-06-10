using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PlayerData")]
public class PlayerData : ScriptableObject, ISerializationCallbackReceiver
{
    public string playerName;
    public int correctAttempts;
    public bool isPlaying;

    public void OnAfterDeserialize()
    {
        playerName = "empty";
        correctAttempts = 0;
        isPlaying = false;
    }

    public void OnBeforeSerialize(){}
}
