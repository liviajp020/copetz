using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bapakhaji : MonoBehaviour
{
    public float timer = 0;

    private void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            GetComponent<Animator>().SetBool("IsClosed", false);
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    private void OnMouseDown()
    {
        GetComponent<Animator>().SetBool("IsClosed", true);
        GetComponent<BoxCollider2D>().enabled = false;
        timer = 5;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("DEAD BY PA HAJI");
            collision.gameObject.GetComponent<Player>().PlayerDead();
        }
    }
}
