using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : BaseShape
{
    //ENCAPUSLATION START
    private int limit;  // field
    public int Limit    // property
    {
        get { return limit; }
        set { limit = value; }
    }

    public override void typeOfShape()
    {
        Debug.Log("This is a Shape");
    }
}

  

