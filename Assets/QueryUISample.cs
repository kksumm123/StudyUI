using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QueryUISample : MonoBehaviour
{
    public static QueryUISample Instance;
    void Awake()
    {
        Instance = this;
    }

    GameObject buttonBase;
    void Start()
    {
        buttonBase = transform.Find("ButtonGroup/Button").gameObject;
    }

    List<GameObject> buttons = new List<GameObject>();
    internal void Show(string content, Action<string> fn, params string[] buttonTexts)
    {
        buttons.ForEach(x => Destroy(x));
        foreach (var item in buttonTexts)
        {
            var newButton = (GameObject)Instantiate(buttonBase, buttonBase.transform.parent);
            buttons.Add(newButton);
            Button button = newButton.GetComponent<Button>();
            button.onClick.AddListener(() => OnClick(button));
        }
    }
    void OnClick(Button button)
    {

    }
}
