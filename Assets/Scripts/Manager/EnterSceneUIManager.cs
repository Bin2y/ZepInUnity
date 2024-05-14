using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnterSceneUIManager : UIManager
{

    [Header("Image Contorl")]
    public Image mainImage;


    public override void ChooseCharacter(GameObject obj)
    {
        ChangeMainImageSprite(obj.GetComponent<Image>().sprite);
        base.ChooseCharacter(obj);
    }
    public void ChangeMainImageSprite(Sprite newSprite)
    {

        mainImage.sprite = newSprite;
    }

    public void MoveToMainScene()
    {
        if (inputField.text.Length >= 2 && inputField.text.Length <= 10)
        {
            DataManager.instance.SetCharacterName(inputField.text.ToString());
            SceneManager.LoadScene("MainScene");
        }
        //TODO : 이름이 빈상태로 입력하면 다시 입력하라는 UI띄우기
        else
        {
            StartCoroutine(ShowRetryText());
        }
    }
}
