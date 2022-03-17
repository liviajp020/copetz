using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipa : MonoBehaviour
{
    public GameObject botol;

    private void OnMouseDown()
    {
        botol.SetActive(true);
        GetComponent<Animator>().SetBool("IsBotolSudahKeluar", true);
    }
}
