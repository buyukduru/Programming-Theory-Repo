using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private float fallingDistance = -20.0f;
    private float time;
    private float limit = 15;
    private float startTime;
    private float timeSinceStartTime;

    private void Start()

    {
        startTime = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        timeSinceStartTime = Time.time - startTime;

        if (transform.position.y < fallingDistance || timeSinceStartTime >= limit)
        {

            Destroy( this.gameObject);
        }
     
       
    }
}
