using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

 
    public float speed=1.0f;
   
    public void Update()
    {
        if(GetComponent<Animator>().GetBool("isEvent2")==false)
        {
            transform.position += (Vector3.right * speed * Time.deltaTime);
        }
   
        
        
    }


 
}
