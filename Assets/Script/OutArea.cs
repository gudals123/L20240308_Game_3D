using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutArea : MonoBehaviour
{
    public static int deathCount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            deathCount++;
            Debug.Log($"deathCount : {deathCount}");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
