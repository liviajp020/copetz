using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : MonoBehaviour
{
    public Animator yuyul;
    public bool isDeadEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (isDeadEvent)
            {
                GameObject.Find("Player").GetComponent<Player>().PlayerDead();
            }
            else // when enemy attacking
            {
                yuyul.SetBool("attacking", true);
            }
            Destroy(gameObject);
        }
    }
}
