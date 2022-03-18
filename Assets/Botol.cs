using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botol : MonoBehaviour
{
    private Vector2 mousePosition;
    public float moveSpeed = 1.0f;
    public GameObject[] listDestroyedObject;

    private bool isAlreadyCaught;
    private void OnMouseDrag()
    {
        if (!isAlreadyCaught)
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "yuyul")
        {
            GetComponent<Animator>().SetBool("BotolinYuyul", true);
            Destroy(collision.gameObject);
            for (int i = 0; i < collision.gameObject.GetComponent<Yuyul>().listDestroyedObject.Length; i++)
            {
                Destroy(collision.gameObject.GetComponent<Yuyul>().listDestroyedObject[i]);

            }
            isAlreadyCaught = true;
        }
    }
}
