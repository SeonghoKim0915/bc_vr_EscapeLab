using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleTimer : MonoBehaviour {

    public static bool isRacing;
    public Text Timer_Text;
    private float timer;

	// Use this for initialization
	void Start () {
        isRacing = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isRacing)
        {
            timer += Time.deltaTime;
            Timer_Text.text = "Time:" + timer.ToString("#.00");
        }
    }
}
