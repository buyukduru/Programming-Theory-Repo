using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseShape
{
    public int points;
    public string tagName;

    public void ShapeType()
    {
        Debug.Log("This is a BaseShaep");
    }
}
