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

        ScoreText();


    }

    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = "Score: " + score.ToString();
        
    }

    public static int ScoreText()
    {
        return score = 0;


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
        if (score == 5)
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
        if (score == 10)
        {
            if (isFemaleSelected == true)
            {
                say.clip = voiceListF[3];
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
        if (score == 20)
        {
            if (isFemaleSelected == true)
            {
                say.clip = voiceListF[4];
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
        if (score == 30)
                    {
                        if (isFemaleSelected == true)
                        {
                            say.clip = voiceListF[5];
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



