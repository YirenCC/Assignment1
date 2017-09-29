using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Runtime.InteropServices;


public class Dialogue : MonoBehaviour {

    public GameObject DialogueBox;
    public Text DialogueText;

    public bool DialogueActive;

    public string m_dia;

    [DllImport("DialogueManager_Plugin")]
    public static extern IntPtr LoadFile();

    // Use this for initialization
    void Start () {
        m_dia = Marshal.PtrToStringAnsi(LoadFile());
        Debug.Log("m_dia:" + m_dia);
    }
	
	// Update is called once per frame
	void Update () {

        if(DialogueActive && Input.GetKeyDown(KeyCode.K))
        {
            DialogueBox.SetActive(false);
            DialogueActive = false;
        }
    }

    public void ShowBox()
    {
        DialogueActive = true;
        DialogueBox.SetActive(true);
        DialogueText.text = m_dia;
    }
}
