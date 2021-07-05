using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;
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
