using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    private void Start()
    {
        ConnectGame();
    }

    public void ConnectGame()
    {
        DataManager.instance.currentUsers.Add(gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("대화시작");
        //TODO :  npc대화
    }
}
