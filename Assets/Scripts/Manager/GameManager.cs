using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject characterPrefab;
    public GameObject character;
    public GameObject newCharacter;

   
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        SetPlayerCharacter();
        MakeCharacter();
    }
    public void SetPlayerCharacter()
    {
        Debug.Log("Make Character : " + DataManager.instance.playerCharacterStr);
        characterPrefab = Resources.Load<GameObject>(DataManager.instance.playerCharacterStr);
        
    }

    public void MakeCharacter()
    {
        character = Instantiate(characterPrefab);
    }
    
    //기존 캐릭터를 지우고 새로운 캐릭터를 해당 자리에 생성
    public void SwapCharacter()
    {
        Vector3 position = character.transform.position;
        Quaternion rotation = character.transform.rotation;
        SetPlayerCharacter();
        Destroy(character);

        newCharacter = Instantiate(characterPrefab, position, rotation);
        character = newCharacter;
    }


}
