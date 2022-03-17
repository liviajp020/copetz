using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restrartDelay = 1.0f;

    public void Win()
    {
        Debug.Log("Win");
    }

    public void EndGame()
    {
        if(gameHasEnded== false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("GameOver",2.0f);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
