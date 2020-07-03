using UnityEngine;
using System.Collections;

public class HeadGesture : MonoBehaviour {

	public bool isFacingDown = false;
	public float HeaddownAngle = 60.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		isFacingDown = DetectFacingDown ();
	}

	private bool DetectFacingDown(){
		return (CameraAngleFromGround () < HeaddownAngle);
	}

	private float CameraAngleFromGround () {
		return Vector3.Angle (Vector3.down, Camera.main.transform.rotation * Vector3.forward);
	}

	}
