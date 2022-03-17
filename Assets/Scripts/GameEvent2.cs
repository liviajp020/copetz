using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEvent2 : MonoBehaviour
{
    public Animator animator;
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.GetComponent<Player>().PlayerDead();
        }
    }

    public void EndTrigger()
    {
        gameManager.Win();
    }
    

}