using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle_Behaviour : MonoBehaviour
{

    public GameObject candleLight;

    private void OnTriggerEnter(Collider col)
    {
        Destroy(candleLight);
        Destroy(gameObject);
    }
}
