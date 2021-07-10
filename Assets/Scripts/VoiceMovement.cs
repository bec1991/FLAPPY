using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System; 
using UnityEngine.Windows.Speech;
using UnityEngine.SceneManagement;

public class VoiceMovement : MonoBehaviour
{   
    //speech recognision 
    private KeywordRecognizer keywordRecognizer;
    //have to add in a dictionary with keywords in functions - 
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();



    void Start()
    {
    
        actions.Add("down", Down);
        actions.Add("Up", Up);


        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;

        //Makes the program start listening
        keywordRecognizer.Start();
    }


    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log("speech.text");
        actions[speech.text].Invoke();

    }

   //functions for letting us move down and up 
    private void Down()
    {
        transform.Translate(0,-3,0);
    }

    private void Up()
    {
        transform.Translate(0,3,0);
    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {

        SceneManager.LoadScene(6);
        Debug.Log("Strike");
    }

}

