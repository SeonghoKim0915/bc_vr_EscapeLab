using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	public GameObject Pause_Canvas;
	public GameObject player;
	public GameObject UI_Cam;

	void Start () {
		Time.timeScale = 1;
		hidePaused ();

	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.P))
		{
          
			if(Time.timeScale == 1)
			{
				Time.timeScale = 0;
				showPaused();
			} else if (Time.timeScale == 0){
				
				Time.timeScale = 1;
				hidePaused();
			}
		}
	}

	public void showPaused(){
		player.SetActive (false);
		UI_Cam.SetActive (true);
		Pause_Canvas.SetActive(true);
		}


	public void hidePaused(){
		player.SetActive (true);
		UI_Cam.SetActive (false);
		Pause_Canvas.SetActive(false);
		}


}
