using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KabelPutus : MonoBehaviour
{

    public GameObject kabelPutus;
    public BoxCollider2D cableCollider;
   
    private void OnMouseDown()
    {
        GetComponent<Animator>().SetBool("KenaBulan", true);
        cableCollider.enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "KabelPutus")
        {
            GetComponent<Animator>().SetBool("BotolinYuyul", true);
            Destroy(collision.gameObject);
            Destroy(GameObject.Find("Event1"));
            Destroy(GameObject.Find("Event2"));
        }
    }
}
