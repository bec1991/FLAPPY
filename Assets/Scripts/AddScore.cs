using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    private GameObject score;
    // Start is called before the first frame update


    private void Start()
    {
        score = GameObject.Find("ScoreText");

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
        score.GetComponent<Score>().VoiceOvers();
        Debug.Log("addscore");
    }
}
