using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ComicSystem : MonoBehaviour
{

    public GameObject[] comicList;
    public int indexComic = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (indexComic < comicList.Length - 1)
            {
                comicList[indexComic].SetActive(false);               
                comicList[indexComic + 1].SetActive(true);

                indexComic++;

            }
            else
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
