  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneUIManager : UIManager
{
    public GameObject popUpCharacterName;
    public Text playerNameText;

    private void Start()
    {
        //최초로 넘어온 값을 등록
        SetPlayerNameText();
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
    }

    public void PopUpCharacterName()
    {
        popUpCharacterName.SetActive(true);
    }

    public void EnterCharacterName()
    {
        DataManager.instance.SetCharacterName(inputField.text.ToString());
    }
}
