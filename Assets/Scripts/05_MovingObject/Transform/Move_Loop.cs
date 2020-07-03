using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Loop : MonoBehaviour {
	public float left_area;
    public float left_speed;
    public float forward_area;
    public float forward_speed;
    public float up_area;
    public float up_speed;
   	float forward_flag = 1;
    float left_flag = 1;
    float up_flag = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (transform.localPosition.z < -forward_area) 
		{ 
			forward_flag = 1; 
		} 
		else if(transform.localPosition.z  > forward_area) 
		{ 
			forward_flag = -1; 
		}
        if (transform.localPosition.x < -left_area)
        {
            left_flag = -1;
        }
        else if (transform.localPosition.x > left_area)
        {
            left_flag = 1;
        }
        if (transform.localPosition.y < -up_area)
        {
            up_flag = 1;
        }
        else if (transform.localPosition.y > up_area)
        {
            up_flag = -1;
        }

            transform.Translate(Vector3.left * left_speed * Time.deltaTime * left_flag);
            transform.Translate(Vector3.forward * forward_speed * Time.deltaTime * forward_flag);
            transform.Translate(Vector3.up * up_speed * Time.deltaTime * up_flag);
        }
}
