using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VR_Teleport : MonoBehaviour
{
    public GameObject thePlayer;

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player_Head") 
        {
            Debug.Log("COLIDIU");
            thePlayer.transform.position = new Vector3(0, 20, 0);
        }
    }
}
