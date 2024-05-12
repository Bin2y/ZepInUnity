using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Text playerNameText;

    private void Start()
    {
        //최초로 한번 이름 등록
        SetPlayerNameText();
    }
    private void SetPlayerNameText()
    {
        if (DataManager.instance.playerName != null)
        {
            playerNameText.text = DataManager.instance.playerName;
        }
    }

   
}
