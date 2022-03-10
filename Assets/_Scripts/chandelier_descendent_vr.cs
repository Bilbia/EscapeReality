using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chandelier_descendent_vr : MonoBehaviour
{
   
    public float minHeight = 1.0f;
    public float mvSpeed = 0.01f;
    public bool drop = false;
    private Rigidbody rb;

    void Update()
    {
        rb = GetComponent<Rigidbody>();
        if(drop){
            // if(this.transform.position.y >= minHeight){
            //     this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - mvSpeed, this.transform.position.z);
            // }
            rb.isKinematic = false;
        }
    }
}
