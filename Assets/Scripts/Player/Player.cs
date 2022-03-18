using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed=1.0f;
    public Animator animator;
   
    public void Update()
    {
        if (!GetComponent<Animator>().GetBool("Dead"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }        
    }

    public void PlayerDead()
    {
        GetComponent<Animator>().SetBool("Dead", true);
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
       
    }

    public void WLose()
    {
        if (GetComponent<Animator>().GetBool("Dead"))
            animator.SetBool("Lose", true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            animator.SetBool("Win", true);
        }
       
    }
}
