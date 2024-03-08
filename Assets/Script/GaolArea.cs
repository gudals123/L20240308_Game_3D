using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class GaolArea : MonoBehaviour
{
    public static bool goal;
    public static int stage;

    void Start()
    {
        goal = false;
        stage = 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            goal = true;
            stage = stage+1;
            Debug.Log($"stage : {stage}");
            Debug.Log("Gaol~!");
            
        }
    }
        

}
