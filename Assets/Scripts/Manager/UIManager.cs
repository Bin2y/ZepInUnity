using UnityEngine;
using UnityEngine.UI;
using System;

public class UIManager : MonoBehaviour
{
    [Header("User Input Name")]
    public InputField inputField;
    [Header("Character Pop-Up")]
    public GameObject popUpCharacterPage;
    
    public virtual void PopUpCharacterPageUI()
    {
        popUpCharacterPage.SetActive(true);
    }

    public virtual void ChooseCharacter(GameObject obj)
    {
        DataManager.instance.SetCharacterStr(obj.name);
        popUpCharacterPage.SetActive(false);
    }
}
