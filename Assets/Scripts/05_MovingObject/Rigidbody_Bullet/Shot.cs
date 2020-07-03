using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject Bullet;
	public Transform firePos;
    public float time;
    static float lastTime = 0;

    // Use this for initialization
    void Start () {
        lastTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastTime > time)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(Bullet, firePos.transform.position, firePos.transform.rotation);
                lastTime = Time.time;
            }
                
         }
       
    }

}


