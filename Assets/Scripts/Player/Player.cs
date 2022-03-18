using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed=1.0f;
    public Animator animator;
    public GameObject losePanel;
    public float timerToShowPanel;

    private bool isLose;

    public void Update()
    {
        if (!GetComponent<Animator>().GetBool("Dead"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (isLose)
        {
            timerToShowPanel -= Time.deltaTime;
        }

        if (timerToShowPanel < 0f)
        {
            losePanel.SetActive(true);
        }

    }

    public void PlayerDead()
    {
        GetComponent<Animator>().SetBool("Dead", true);
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        isLose = true;
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
