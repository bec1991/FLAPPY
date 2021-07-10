using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int scoreNum;
    public GameObject player;
    public Collider2D obsColl;
    public AudioClip[] voiceListF;
    public AudioClip[] voiceListM;
    public AudioSource say;
    public bool isFemaleSelected = true;


    public static int score = 0;

    private void Start()
    {
        score = 0;
    

    }

    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = "Score: " + score.ToString();
        
    }

    public void VoiceOvers()
    {
        if (score == 1)
        {
            if (isFemaleSelected == true)
            {
                say.clip = voiceListF[0];
                say.Play();
                //Debug.Log("WEEEEE!!!");
            }
            if (isFemaleSelected == false)
            {
                say.clip = voiceListM[0];
                say.Play();
                //Debug.Log("WEEEEE!!!");
            }
        }
        if (score == 2)
        {
            if (isFemaleSelected == true)
            {
                say.clip = voiceListF[1];
                say.Play();
                //Debug.Log("WEEEEE!!!");
            }
            if (isFemaleSelected == false)
            {
                say.clip = voiceListM[1];
                say.Play();
                //Debug.Log("WEEEEE!!!");
            }
        }
        if (score == 3)
        {
            if (isFemaleSelected == true)
            {
                say.clip = voiceListF[2];
                say.Play();
                //Debug.Log("WEEEEE!!!");
            }
            if (isFemaleSelected == false)
            {
                say.clip = voiceListM[2];
                say.Play();
                //Debug.Log("WEEEEE!!!");
            }
        }


    }
}



