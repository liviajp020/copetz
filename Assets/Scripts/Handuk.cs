using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handuk : MonoBehaviour
{
    public GameObject botol;
    public GameObject handuk;
   
    private void OnMouseDown()
    {
        handuk.GetComponent<Animator>().SetBool("KenaAC", true);
        botol.SetActive(true);
        GetComponent<Animator>().SetBool("kipas", true);
    }
}
