using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("User Input Name")]
    public InputField inputField;
    [Header("Character Pop-Up")]
    public GameObject popUpCharacterPage;
    
    
    public void PopUpCharacterPageUI()
    {
        popUpCharacterPage.SetActive(true);
    }

    public virtual void ChooseCharacter(GameObject obj)
    {
        DataManager.instance.SetCharacterStr(obj.name);
        popUpCharacterPage.SetActive(false);
    }
}
