using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position_Reset : MonoBehaviour {

    public Transform Reset_Position;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        other.transform.position = Reset_Position.position;
    }
}
