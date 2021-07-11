using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public float queueTime = 1.5f;
    private float time = 0;
    public GameObject obstacle;
    public GameObject caveObstacle;
    public float currentSpeed = 5f;
    public float obsSpeed = 5f;
    public float speedInc = 0.1f;
    public int height = 3;
    public Text scoreText;
    
    


   public void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       StartCoroutine(DifficultySpeed());
        Obstacle();

        time += Time.deltaTime;
        //Debug.Log(time);

    }

    public void Obstacle()
    {
        if (time > queueTime)
        {
            if (time > queueTime)
            {
                GameObject go = Instantiate(obstacle, transform.position, Quaternion.identity, transform);
                go.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

                time = 0;

                Destroy(go, 10);
            }
            if (time > queueTime)
            {

                GameObject go = Instantiate(caveObstacle, transform.position, Quaternion.identity, transform);
                go.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

                time = 0;

                Destroy(go, 10);
            }

        }


    }

    IEnumerator DifficultySpeed()
    {
        if (time > queueTime)
        {
            obsSpeed += speedInc;
           yield return new WaitForSeconds(10);
        }
    }

  

   
}
