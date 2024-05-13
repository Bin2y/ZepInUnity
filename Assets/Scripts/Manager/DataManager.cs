using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static DataManager instance = null;

    [SerializeField] public string playerName { get; set; }
    [SerializeField] public string playerCharacterStr {  get; set; }

    //현재 접속자
    public List<string> currentUsers;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if( instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad (gameObject);
    }

    public void Start()
    {
        playerName = "Default";
        playerCharacterStr = "Penguin";
    }

    public void SetCharacterName(string name)
    {
        playerName = name;
        currentUsers.Add(playerName);

        
    }

    public void SetCharacterStr(string characterStr)
    {
        playerCharacterStr = characterStr;
    }
}
