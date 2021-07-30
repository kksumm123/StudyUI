using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QueryUISample : MonoBehaviour
{
    Button button;
    void Start()
    {
        button = transform.Find("ButtonGroup/Button").GetComponent<Button>();
    }
}
