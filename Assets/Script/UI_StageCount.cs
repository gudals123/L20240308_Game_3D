using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_StageCount : MonoBehaviour
{
    private void Start()
    {
        Text text = GetComponent<Text>();
        text.text = "Stage : " + GaolArea.stage;
    }
    // Update is called once per frame
    void Update()
    {
        Text text = GetComponent<Text>();
        text.text = "Stage : " + GaolArea.stage;
    }
}
