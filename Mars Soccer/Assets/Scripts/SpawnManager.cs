using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject [] shapes;

    private float axisConstrain = 125;
    private float axisY = 20;

    private float spawnTime=4.0f;
    private float delayTime = 1.0f;
 
    void Start()
    {
        InvokeRepeating("spawnShape",delayTime,spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnShape()
    {
        float randomConstrain = Random.Range(-axisConstrain, axisConstrain);
        float randomX = Random.Range(-axisConstrain, axisConstrain);
        float randomZ = Random.Range(-axisConstrain, axisConstrain);
        int randomIndex = Random.Range(0, shapes.Length);

        Vector3 randPos = new Vector3(randomX, axisY, randomZ);
        Instantiate(shapes[randomIndex],randPos,shapes[randomIndex].gameObject.transform.rotation);


    }
}
