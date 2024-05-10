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

    //두 개의 캐릭터 중에 하나 고르면 작동하는 메서드
    public void ChooseCharacter(Image image)
    {
        ChangeMainImageSprite(image.sprite);
        popUpCharacterImage.SetActive(false);
        //TODO : 캐릭터 스프라이트 받아서 넘기기 (캐릭터를 두개를 만들어야하나)
    }

    public void ChangeMainImageSprite(Sprite newSprite)
    {
        DataManager.instance.playerSprite = mainImage.sprite;
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
