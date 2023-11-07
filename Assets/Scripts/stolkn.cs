using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class stolkn : MonoBehaviour
{
    public int n = 0;
    public TMP_Text textToEdit;

    void Awake()
    {
       //textToEdit = GetComponent<TMP_Text>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Tag2")
        { 
            n -= 1; 
            textToEdit.text = "Количество столкновений = " + n.ToString(); 
        }
    }
}
