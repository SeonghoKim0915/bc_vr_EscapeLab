using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Return_Menu : MonoBehaviour {

    public string scene_name;

	public void ReturnMenu()
    {
        SceneManager.LoadScene(scene_name);
    }

}
