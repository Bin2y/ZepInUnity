using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnterSceneUIManager : MonoBehaviour
{
    [Header("User Input Name")]
    public InputField inputField;
    [Header("Character Pop-Up")]
    public GameObject popUpCharacterImage;
    [Header("Image Contorl")]
    public Image mainImage;

    

    public void PopUpCharacterUI()
    {
        popUpCharacterImage.SetActive(true);
    }

    public void ChooseCharacter(GameObject obj)
    {
        DataManager.instance.SetCharacterStr(obj.name);
        Debug.Log(obj.name);
        ChangeMainImageSprite(obj.GetComponent<Image>().sprite);
        popUpCharacterImage.SetActive(false);
    }
    public void ChangeMainImageSprite(Sprite newSprite)
    {
        
        mainImage.sprite = newSprite;
    }
    
    public void MoveToMainScene()
    {
        if(inputField.text!="")
        {
            DataManager.instance.SetCharacterName(inputField.text.ToString());
            SceneManager.LoadScene("MainScene");
        }
        //TODO : 이름이 빈상태로 입력하면 다시 입력하라는 UI띄우기
        else
        {
            Debug.Log("다시 입력해주세요");

        }
    }
}
