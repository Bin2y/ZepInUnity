using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static DataManager instance = null;

    public string playerName { get; set; }
    public Sprite playerSprite {  get; set; }
    

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


    public void SetCharacterName(string name)
    {
        playerName = name;
    }
}
