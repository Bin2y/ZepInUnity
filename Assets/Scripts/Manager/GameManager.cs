using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject character;
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
    private void SetPlayerCharacter()
    {
        Debug.Log("Make Character : " + DataManager.instance.playerCharacterStr);
        character = Resources.Load<GameObject>(DataManager.instance.playerCharacterStr);
    }

    private void MakeCharacter()
    {
        //복사본을 바라보게 세팅
        character = Instantiate(character);
    }
}
