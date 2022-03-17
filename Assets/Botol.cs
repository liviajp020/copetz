using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botol : MonoBehaviour
{
    private Vector2 mousePosition;
    public float moveSpeed = 1.0f;
    private void OnMouseDrag()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Yuyul_Idle1")
        {
            GetComponent<Animator>().SetBool("BotolinYuyul", true);
            Destroy(collision.gameObject);
            Destroy(GameObject.Find("Event1"));
            Destroy(GameObject.Find("Event2"));
        }
    }
}
