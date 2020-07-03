using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using VRStandardAssets.Utils;

public class vr_scene_portal : MonoBehaviour {

    [SerializeField] private string m_MenuSceneName;
    [SerializeField] private VRCameraFade m_VRCameraFade;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col) {

        if (col.tag == "Player")
        {
            StartCoroutine(FadeToMenu());
        }
		
	}

    private IEnumerator FadeToMenu()
    {
        // Wait for the screen to fade out.
        yield return StartCoroutine(m_VRCameraFade.BeginFadeOut(true));

        // Load the scene
       SceneManager.LoadScene(m_MenuSceneName, LoadSceneMode.Single);
    }
}
