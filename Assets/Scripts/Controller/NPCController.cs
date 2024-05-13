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
        if(collision.CompareTag("Player"))
        {
            MainSceneUIManager.Instance.PopUpDialogue();
            MainSceneUIManager.Instance.SetDialogueName(gameObject.name);
        }
        //TODO :  npc대화
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            MainSceneUIManager.Instance.PopDownDialogue(); 
        } 
    }
}
