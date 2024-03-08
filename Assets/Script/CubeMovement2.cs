using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement2 : MonoBehaviour
{
    public float speed = 2.0f;
    public float length = 14.0f;

    private float runTime = 0.0f;
    private float posX = 0.0f;

    private void Update()
    {
        runTime += Time.deltaTime * speed;
        posX = Mathf.Sin(runTime) * length;
        posX = (-1) * posX;
        //Debug.Log(runTime);
        //Debug.Log(posX);

        transform.position = new Vector3(posX, 0, transform.position.z);
    }
}
