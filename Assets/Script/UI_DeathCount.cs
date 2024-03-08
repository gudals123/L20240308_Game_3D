using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_DeathCount : MonoBehaviour
{

    private void Start()
    {
        Text text = GetComponent<Text>();
        text.text = "DeathCount : " + OutArea.deathCount;
    }
    void Update()
    {
        Text text = GetComponent<Text>();
        text.text = "DeathCount : " + OutArea.deathCount;
    }
}
