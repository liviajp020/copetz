using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bocah : MonoBehaviour
{
    public GameObject layangan;
    private void OnMouseDown()
    {
        layangan.SetActive(false);
        GetComponent<Animator>().SetBool("LayanganTerbang", true);
    }
}
