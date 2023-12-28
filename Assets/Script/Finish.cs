using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource finishSound;
    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            finishSound.Play();
            ComplateLevel();
        }    
    }

    private void ComplateLevel()
    {

    }

}
