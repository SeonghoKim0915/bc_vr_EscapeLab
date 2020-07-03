using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger_Hud : MonoBehaviour {

    public Text hudTextUI;
    public string text;
	

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            hudTextUI.text = text;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            hudTextUI.text = "";
        }
    }
}
