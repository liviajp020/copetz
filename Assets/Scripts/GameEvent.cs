using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.name=="Player")
        {
            animator.SetBool("isEvent1", true);
        }
    }

   
}
