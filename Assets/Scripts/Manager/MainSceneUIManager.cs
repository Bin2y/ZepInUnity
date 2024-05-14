using System.Collections;
using System.Collections.Generic;
using System.Data;
using System;
using UnityEngine;
using UnityEngine.UI;
public class MainSceneUIManager : UIManager
{
    public static MainSceneUIManager Instance;

    public GameObject popUpCharacterName;
    public Text playerNameText;
    public GameObject characterNameBar;

    [Header("Time")]
    public Text currentTimeText;


    [Header("Text")]
    public Text playerListText;

    [Header("Dialogue")]
    public GameObject dialogue;
    public GameObject dialogueBox;
    public Text dialogueName;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
    private void Start()
    {
        //최초로 넘어온 값을 등록
        SetPlayerNameText();
        ShowPlayerList();
    }

    private void Update()
    {
        SetDateTime();
    }

    private void ShowPlayerList()
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
        characterNameBar.SetActive(true);
    }
    public void SetPlayerNameText()
    {

        if (DataManager.instance.playerName != null)
        {
            if(!(DataManager.instance.playerName.Length >= 2 && DataManager.instance.playerName.Length<=10))
            {
                StartCoroutine(ShowRetryText());
                return;
            }
            playerNameText.text = DataManager.instance.playerName;
            popUpCharacterName.SetActive(false);
            characterNameBar.SetActive(true);
        }
        //update
        ShowPlayerList();
    }

    public void EnterCharacterName()
    {
        DataManager.instance.SetCharacterName(inputField.text.ToString());
    }

    public void PopUpDialogue()
    {
        dialogue.SetActive(true);
    }

    public void PopDownDialogue()
    {
        dialogue.SetActive(false);
        dialogueBox.SetActive(false);
    }

    public void PopUpDialogueBox()
    {
        dialogueBox.SetActive(true);
    }

    public void SetDialogueName(string name)
    {
        dialogueName.text = name;
    }

    public void SetDateTime()
    {
        currentTimeText.text = DateTime.Now.ToString("HH:mm:ss tt");
    }
}
