using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestQueryUI : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            QueryUISample.Instance.Show("내용1", PrintResuilt, "확인");
        if (Input.GetKeyDown(KeyCode.Alpha2))
            QueryUISample.Instance.Show("내용2", PrintResuilt, "확인", "취소");
        if (Input.GetKeyDown(KeyCode.Alpha3))
            QueryUISample.Instance.Show("내용3", PrintResuilt, "확인", "취소", "적용");
    }
    void PrintResuilt(string clickedText)
    {
        print(clickedText);
    }
}
