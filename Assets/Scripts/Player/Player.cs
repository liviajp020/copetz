using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed=1.0f;
   
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
}
