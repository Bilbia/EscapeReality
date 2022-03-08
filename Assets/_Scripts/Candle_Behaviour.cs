using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle_Behaviour : MonoBehaviour
{

    public GameObject light;

    private void OnTriggerEnter(Collider col)
    {
        Destroy(light);
        Destroy(gameObject);
    }
}
