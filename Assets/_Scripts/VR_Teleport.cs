using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VR_Teleport : MonoBehaviour
{
    public GameObject thePlayer;
    public bool spawn = false;

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player_Head") 
        {
            Debug.Log("COLIDIU");
            //thePlayer.transform.position = new Vector3(0, 5, 0);
            SceneManager.LoadScene(2);
        }
    }

    void Update()
    {
        if(spawn){
            Debug.Log("PDP");
            gameObject.SetActive(true);
        }
    }
}
