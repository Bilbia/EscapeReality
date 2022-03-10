using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chandelier_Descend : MonoBehaviour
{

    private float minHeight = 1.0f;
    private float mvSpeed = 0.01f;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("candle_light").Length <= 0)
        {
            if(this.transform.position.y >= minHeight){
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - mvSpeed, this.transform.position.z);
            }
            
        }
    }
}
