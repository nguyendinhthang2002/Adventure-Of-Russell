using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int score = 0;

    [SerializeField] private Text scoreText;

    [SerializeField] private AudioSource collectSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Score"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            score++;
            scoreText.text = "Scores: " + score;
        }
    }
}
