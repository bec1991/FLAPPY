using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    public float speed;
    public int scoreTally = 0;


    //public GameObject spawner;



    // Update is called once per frame
    void Start()
    {
        speed = transform.parent.gameObject.GetComponent<Spawner>().obsSpeed;
       
    }



    void Update()
    {



        transform.position += ((Vector3.left * speed) * Time.deltaTime);

    }

 }
