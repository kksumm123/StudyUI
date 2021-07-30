using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownUISameple : MonoBehaviour
{
    Dropdown dropdown;
    void Start()
    {
        dropdown = transform.Find("Dropdown").GetComponent<Dropdown>();
        dropdown.onValueChanged.AddListener(OnValueChanged);
    }
    void OnValueChanged(int selectedIndex)
    {
        print(dropdown.options[selectedIndex].text);
    }
}
