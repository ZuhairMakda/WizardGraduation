﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueUI : MonoBehaviour
{
    public float delay = 0.1f;
    public string fullText;
    public string currentText = "";
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowText());
    }
 
    IEnumerator ShowText(){
        for (int i = 0; i <= fullText.Length; i++)
        {
            currentText = fullText.Substring(0,i);
            this.GetComponent<Text>().text = currentText;
            if (i == fullText.Length)
            {
                Thread.Sleep(3000);
                SceneManager.LoadScene(2);
            }
            yield return new WaitForSeconds(delay);
        }
    }  
}