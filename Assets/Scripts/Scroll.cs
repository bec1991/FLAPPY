using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    Material material;
    Vector2 offset;
    

    //variavble to store how much we want to change background 
    public float xVelocity, yVelocity;
    private void Awake()
    {

        material = GetComponent<Renderer>().material;
    }


    // Update is called once per frame
    void Start()
    {
        offset = new Vector2(xVelocity, yVelocity);
    }

    void Update()
    {
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
