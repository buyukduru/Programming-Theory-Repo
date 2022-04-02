using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{ 
 private float fallingDistance = -20.0f;

private float startTime;
private float timeSinceStartTime;

Shape shape;
private void Start()

{
    typeOfShape();
    startTime = Time.time;
    shape = new Shape();

    shape.Limit = 30;

}
// Update is called once per frame
void Update()
{
    timeSinceStartTime = Time.time - startTime;

    if (transform.position.y < fallingDistance || timeSinceStartTime >= shape.Limit)
    {

        Destroy(this.gameObject);
    }


}
// POLYMORPHISM
public override void typeOfShape()
{
    Debug.Log("You Stroke a Cylinder!");
}
}