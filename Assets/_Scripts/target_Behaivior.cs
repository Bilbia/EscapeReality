using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_Behaivior : MonoBehaviour
{
    public GameObject chandelier;


    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "projectile") 
        {
            Debug.Log("bulls eye");
            chandelier.GetComponent<chandelier_descendent_vr>().drop = true;
        }
    }
}
