using System.Collections;
using System.Collections.Generic;
using System.Data;
using System;
using UnityEngine;
using UnityEngine.UI;
public class MainSceneUIManager : UIManager
{
    public GameObject popUpCharacterName;
    public Text playerNameText;
    public GameObject characterNameBar;

    [Header("Time")]
    public Text currentTimeText;

    [Header("Bar")]
    public GameObject peopleListBar;

    [Header("Text")]
    public Text playerListText;


    private void Start()
    {
        //최초로 넘어온 값을 등록
        SetPlayerNameText();
        showPlayerList();
    }



    private void showPlayerList()
    {
        playerListText.text = "";
        foreach (string obj in DataManager.instance.currentUsers)
        {
            playerListText.text += obj;
            playerListText.text += "\n";
        }
    }

    public override void ChooseCharacter(GameObject obj)
    {
        base.ChooseCharacter(obj);
        GameManager.Instance.SwapCharacter();
    }
    public void SetPlayerNameText()
    {

        if (DataManager.instance.playerName != null)
        {
            playerNameText.text = DataManager.instance.playerName;
            popUpCharacterName.SetActive(false);
        }
        //update
        showPlayerList();
    }

    public void PopUpCharacterName()
    {
        popUpCharacterName.SetActive(true);
        characterNameBar.SetActive(false);
    }

    public void EnterCharacterName()
    {
        DataManager.instance.SetCharacterName(inputField.text.ToString());
        characterNameBar.SetActive(true);
    }

    public void OnPressX()
    {
        peopleListBar.SetActive(false);
    }
    public void PopUpPeopleListBar()
    {
        peopleListBar.SetActive(true);
    }
}
