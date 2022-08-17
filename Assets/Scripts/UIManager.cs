using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class UIManager : MonoBehaviour
{
    public GameObject textUI;
    public GameObject startUI;
    public GameObject inputField;
    public string name;

    public void EnterName()
    {
        startUI.SetActive(false);
        textUI.SetActive(true);
    }

    public void StartNew()
    {
        name = inputField.GetComponent<TextMeshProUGUI>().text;
        MainData.Instance.tempName = name;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
