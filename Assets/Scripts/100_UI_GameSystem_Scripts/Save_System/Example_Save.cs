using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Save : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Save()
    {
        PlayerPrefs.SetFloat("Life", Player_Health.playerHealth);
    }
}
