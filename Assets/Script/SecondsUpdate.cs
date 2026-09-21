using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondsUpdate : MonoBehaviour
{

    float timeStart0ffset = 0;
    bool gotStarTime = false;

    void Update()
    {
        if(! gotStarTime)
        {
            timeStart0ffset = Time.realtimeSinceStartup;
            gotStarTime = true;
        }
        this.transform.position = new Vector3(this.transform.position.x, 
                                             this.transform.position.y, 
                                             Time.realtimeSinceStartup - timeStart0ffset);
    }
}
