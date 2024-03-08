using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCount : MonoBehaviour
{
    public static int count;
    void Start()
    {
        count = 0;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            count++; 
            Debug.Log(count);
        }
    }
}
