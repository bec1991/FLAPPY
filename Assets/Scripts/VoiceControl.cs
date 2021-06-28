using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceControl : MonoBehaviour
{
    // voice command variables
    private Dictionary<string, Action> keyActs = new Dictionary<string, Action>();

    private KeywordRecognizer recognizer;

    private MeshRenderer squareRend;
    //Vars needed for sound playback.
    private AudioSource soundSource;
    public AudioClip[] sounds;
 

    void Start()
    {
    
    soundSource = GetComponent<AudioSource>();

    //Voice commands for playing sound
    keyActs.Add("please say something", Talk);
    //Voice command to show how complex it can get.
    keyActs.Add("pizza is a wonderful food that makes the world better", FactAcknowledgement);
    keyActs.Add("red", Red);
    keyActs.Add("green", Green);
    keyActs.Add("blue", Blue);
    keyActs.Add("white", White);
    recognizer = new KeywordRecognizer(keyActs.Keys.ToArray());
    recognizer.OnPhraseRecognized += OnKeywordsRecognized;
    recognizer.Start(); 
    }

  void OnKeywordsRecognized(PhraseRecognizedEventArgs args)
{
    Debug.Log("Command: " + args.text);
    keyActs[args.text].Invoke();
}


void Red()
{
    Debug.Log("i said something");
    squareRend.material.SetColor("_Color", Color.red);

}
void Green()
{
    squareRend.material.SetColor("_Color", Color.green);
    Debug.Log("i said something");
}
void Blue()
{
    squareRend.material.SetColor("_Color", Color.blue);
}
void White()
{
    squareRend.material.SetColor("_Color", Color.white);
}

void Talk()
{
    soundSource.clip = sounds[UnityEngine.Random.Range(0, sounds.Length)];
    soundSource.Play();
}

void FactAcknowledgement()
{
    Debug.Log("How right you are.");
}

}
