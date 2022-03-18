using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layangan : MonoBehaviour
{
    public Transform position1,position2;
    public float speed;
    public Transform startPos;
    Vector3 nextpos;
    bool isFlying = false;
    public GameObject[] pijakan;
    public GameObject bocah;
    public void Start()
    {
        nextpos = startPos.position;
    }

    public void Update()
    {
        if (isFlying)
        {
            nextpos = position2.position;
        }
        if (transform.position.y > 0.5f)
        {
            for (int i = 0; i < pijakan.Length; i++)
            {
                pijakan[i].SetActive(true);

            }
            GetComponent<BoxCollider2D>().enabled = false;

        }
        else
        {

            transform.position = Vector3.MoveTowards(transform.position, nextpos, speed * Time.deltaTime);
        }
    }

    private void OnMouseDown()
    {
        for (int i = 0; i < pijakan.Length; i++)
        {
            pijakan[i].SetActive(false);

        }
        isFlying = true;
        bocah.GetComponent<Animator>().SetBool("LayanganTerbang", true);
    }
}
