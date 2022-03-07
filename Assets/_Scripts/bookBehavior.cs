using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookBehavior : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Invisible_Book") 
        {
            Debug.Log("the books on the chair");
            Destroy(door);
            //thePlayer.transform.position = new Vector3(0, 5, 0);
        }
    }
}
