using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class UIManager : MonoBehaviour
{
    private float showTime = 2f;
    [Header("User Input Name")]
    public InputField inputField;
    public GameObject retryText;
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

    public IEnumerator ShowRetryText()
    {
        retryText.SetActive(true);
        yield return new WaitForSeconds(showTime);

        retryText.SetActive(false);
    }
}
