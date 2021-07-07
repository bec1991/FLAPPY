using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float queueTime = 1.5f;
    private float time = 0;
    public GameObject obstacle;
    public float currentSpeed = 5f;
    public float obsSpeed = 5f;
    public float speedInc = 0.1f;
    public int height = 3;
    

    // Update is called once per frame
    void Update()
    {
       StartCoroutine(DifficultySpeed());
        WoodObstacle();

        time += Time.deltaTime;
        Debug.Log(time);

    }

    public void WoodObstacle()
    {
        if (time > queueTime)
        {
            GameObject go = Instantiate(obstacle, transform.position, Quaternion.identity, transform);
            //obstacle.transform.parent = go.transform;
            go.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            time = 0;

            Destroy(go, 10);
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
