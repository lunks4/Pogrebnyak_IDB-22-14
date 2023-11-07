using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Cube;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }
    public void ActivateOb()
    {
        if (Cube.activeSelf != true)
        {
            Cube.SetActive(true);
        }
        else
        {
            Cube.SetActive(false);
        }
    }

}
