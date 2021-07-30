using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadioButtonUISample : MonoBehaviour
{
    Toggle toggle1;
    Toggle toggle2;
    Toggle toggle3;

    void Awake()
    {
        toggle1 = transform.Find("ToggleGroup/Toggle1").GetComponent<Toggle>();
        toggle2 = transform.Find("ToggleGroup/Toggle2").GetComponent<Toggle>();
        toggle3 = transform.Find("ToggleGroup/Toggle3").GetComponent<Toggle>();
    }
}
