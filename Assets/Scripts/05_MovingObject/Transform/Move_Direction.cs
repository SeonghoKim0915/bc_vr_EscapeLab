using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Direction : MonoBehaviour {

	public float Forward_Move;
    public float Right_Move;
    public float Up_Move;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

			transform.Translate (Vector3.forward * Time.deltaTime * Forward_Move);
            transform.Translate (Vector3.right * Time.deltaTime * Right_Move);
        transform.Translate(Vector3.up * Time.deltaTime * Up_Move);

    }
}
