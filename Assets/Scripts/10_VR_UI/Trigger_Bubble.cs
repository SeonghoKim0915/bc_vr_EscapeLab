using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Bubble : MonoBehaviour {

    public GameObject speechBubble;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            speechBubble.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            speechBubble.SetActive(false);
        }
    }
}
