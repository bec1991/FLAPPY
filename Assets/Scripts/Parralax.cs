using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parralax : MonoBehaviour
{
    public float length;
    public float startpos = 0;   
    
    public GameObject cam;
    public float parralaxEffect;

    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {   //move object
    	transform.position -= new Vector3(parralaxEffect, 0,0);	

        if(transform.position.x<=startpos+length)
        {
            transform.position+= new Vector3(length,0,0);
        }
    }

}
