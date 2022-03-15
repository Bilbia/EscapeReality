using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_Behaivior : MonoBehaviour
{
    public GameObject chandelier;
    public GameObject vrHeadset;


    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "projectile") 
        {
            Debug.Log("bulls eye");
            chandelier.GetComponent<chandelier_descendent_vr>().drop = true;
            vrHeadset.SetActive(true);
        }
    }
}
