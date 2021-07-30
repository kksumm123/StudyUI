using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadioButtonUISample : MonoBehaviour
{
    public Sprite sprite;
    Toggle toggle1;
    Toggle toggle2;
    Toggle toggle3;

    void Awake()
    {
        toggle1 = transform.Find("ToggleGroup/Toggle1").GetComponent<Toggle>();
        toggle2 = transform.Find("ToggleGroup/Toggle2").GetComponent<Toggle>();
        toggle3 = transform.Find("ToggleGroup/Toggle3").GetComponent<Toggle>();

        toggle1.onValueChanged.AddListener((bool bChecked) => { OnValueChanged(toggle1, bChecked); });
        toggle2.onValueChanged.AddListener((bool bChecked) => { OnValueChanged(toggle2, bChecked); });
        toggle3.onValueChanged.AddListener((bool bChecked) => { OnValueChanged(toggle3, bChecked); });
    }
    void OnValueChanged(Toggle toggle, bool bChecked)
    {
        if (bChecked)
        {
            string text = toggle.GetComponentInChildren<Text>().text;
            var image = toggle.transform.Find("Image")?.GetComponent<Image>();
            if (image != null)
                image.sprite = sprite;

            print($"{text} 변경됨 : {bChecked}");
        }
    }
}
