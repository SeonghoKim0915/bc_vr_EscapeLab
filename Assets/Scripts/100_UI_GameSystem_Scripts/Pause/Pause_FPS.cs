using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Pause_FPS : MonoBehaviour {

	public GameObject Pause_Canvas;
	

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
		GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>().enabled = false;
        Cursor.visible = true;
        Pause_Canvas.SetActive(true);
		}


	public void hidePaused(){
		GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>().enabled = true;
        Cursor.visible = false;
        Pause_Canvas.SetActive(false);
		}


}
