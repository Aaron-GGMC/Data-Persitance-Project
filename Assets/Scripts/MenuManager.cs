using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuManager : MonoBehaviour
{
    public TMP_InputField tMP_Input;
    public string newName;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void StartNew()
        {
            SceneManager.LoadScene(1);
        }
    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit(); // original code to quit Unity player
        #endif
    }
    public void NewName()
    {
        newName = tMP_Input.text;
        Debug.Log(newName);
    }
}
