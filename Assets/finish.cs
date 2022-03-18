using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    public GameObject winPanel;
    public float timerToShowPanel;

    private bool isWin;

    private void Update()
    {
        if(isWin)
        {
            timerToShowPanel -= Time.deltaTime;
        }

        if(timerToShowPanel < 0f)
        {
            winPanel.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            isWin = true;
        }
    }
}
