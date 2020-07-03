using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Toward : MonoBehaviour {
	public Transform target; //목표 지정
	public float speed; //속도

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);

	}
}
