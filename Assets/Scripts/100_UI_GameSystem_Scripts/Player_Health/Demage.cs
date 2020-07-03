using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demage : MonoBehaviour {

    public float demage;
    public float destoryTime;
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
            Player_Health.playerHealth -= demage;
            Debug.Log(Player_Health.playerHealth);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player_Health.playerHealth -= demage;
            Destroy(this.gameObject, destoryTime);

        }
    }
}
