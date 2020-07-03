using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Load : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void load()
    {
        Player_Health.playerHealth = PlayerPrefs.GetFloat("Life");
    }
   
}
