
using UnityEngine;


public class Player : MonoBehaviour

{
    public float jumpHeight;
    public float movementSpeed;

    public AudioClip clip;

    public AudioSource source;

    private bool playSoundOnce=false;

    public void Update()
    {
        if (Input.GetKey(KeyCode.D ) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += (new Vector3(1.0f, 0.0f, 0.0f) * Time.deltaTime *movementSpeed);
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
        if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += (new Vector3(-1.0f, 0.0f, 0.0f) * Time.deltaTime * movementSpeed);
            transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        }
        if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += (new Vector3(0.0f, 1.0f, 0.0f) * Time.deltaTime * jumpHeight );
            if (playSoundOnce==false)
            {
                source.PlayOneShot(clip);
                playSoundOnce = true;
            }
            
        }
        if (Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += (new Vector3(0.0f, -1.0f, 0.0f) * Time.deltaTime * movementSpeed);
        }



    }

}
