using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handuk : MonoBehaviour
{
    public GameObject botol;

   
    private void OnMouseDown()
    {
        botol.SetActive(true);
        GetComponent<Animator>().SetBool("isEvent5", true);
    }
}
