using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layangan : MonoBehaviour
{
    public Transform position1,position2;
    public float speed;
    public Transform startPos;
    Vector3 nextpos;

    public void Start()
    {
        nextpos = startPos.position;
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            nextpos = position2.position;
        }
        if (transform.position == position2.position)
        {
            nextpos = position1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextpos, speed * Time.deltaTime);

        void OnDrawGizmos()
        {
            Gizmos.DrawLine(position1.position, position2.position);
        }
    }
    }
