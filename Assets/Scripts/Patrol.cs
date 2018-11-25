using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {

    public float speed;
    public Transform[] moveSpots;
    private int randomSpots;
    private float waitTime;
    public float startWaitTime;

	void Start () {

        waitTime = startWaitTime;

        randomSpots = Random.Range(0, moveSpots.Length);

	}
	
	void Update () {

        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpots].position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, moveSpots[randomSpots].position) < 0.2f)
        {
            if(waitTime <= 0)
            {

                randomSpots = Random.Range(0, moveSpots.Length);

                waitTime = startWaitTime;

            }
            else
            {

                waitTime -= Time.deltaTime;

            }
        }

	}
}
