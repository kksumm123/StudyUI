using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownUISameple : MonoBehaviour
{
    Dropdown dropdown;
    SaveInt lastSelectedIndex;
    void Start()
    {
        dropdown = transform.Find("Dropdown").GetComponent<Dropdown>();
        dropdown.onValueChanged.AddListener(OnValueChanged);
        lastSelectedIndex = new SaveInt("lastSelectedIndex");
        dropdown.value = lastSelectedIndex.Value;
    }
    void OnValueChanged(int selectedIndex)
    {
        lastSelectedIndex.Value = selectedIndex;
        string selectedText = dropdown.options[selectedIndex].text;
        print(selectedText);
        transform.Find("Selected/Text").GetComponent<Text>().text = selectedText;
    }
}
