using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int scoreNum;
    public GameObject player;
    public GameObject obstacle;
    public Collider2D obsColl;
    public List<AudioClip> voiceList;


   // public void Awake()
   // {
   //     scoreText = transform.Find("scoreText").GetComponent<Text>();
   // }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider2D obsColl)
    {
       
        scoreNum ++;
        scoreText.text = "Score: " + scoreNum;
    }


}



