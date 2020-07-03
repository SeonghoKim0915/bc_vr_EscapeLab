using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour {

    public Slider healthSlider;
    public static float playerHealth;
    public GameObject gameoverCanvas;
    // Use this for initialization

    void Start () {

        playerHealth = 100f;
        gameoverCanvas.SetActive(false);
        
	}

   
    // Update is called once per frame
    void Update () {
        if (playerHealth > 0)
        {
            healthSlider.value = playerHealth;
        }
        else
        {
            Time.timeScale = 0;
            gameoverCanvas.SetActive(true);
        }
           
        

	}
}
