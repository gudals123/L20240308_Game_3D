using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_ItemCount : MonoBehaviour
{

    private void Start()
    {
        Text text = GetComponent<Text>();
        text.text = "Item : " + ItemCount.count;
    }
    // Update is called once per frame
    void Update()
    {
        Text text = GetComponent<Text>();
        text.text = "Item : " + ItemCount.count;
    }
}
