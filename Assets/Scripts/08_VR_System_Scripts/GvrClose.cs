using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GvrClose : MonoBehaviour
{
    // Start is called before the first frame update

    void Awake()
    {
        Input.backButtonLeavesApp = true;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
