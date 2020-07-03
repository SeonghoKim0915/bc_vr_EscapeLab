using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head_Map : MonoBehaviour
{
    [SerializeField] private float distance = 1;
    [SerializeField] private GameObject mapObject;
    private HeadGesture gesture;
    private bool flag;
   
    
    

    void Start()
    {
        gesture = GetComponent<HeadGesture>();
        hideMenu();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gesture.isFacingDown && !flag)
        {
            
            openMenu();
            
        } else
        {
            hideMenu();
        }
    }

    public void openMenu()
    {

        mapObject.transform.position = Camera.main.transform.position + Camera.main.transform.forward * distance;
        mapObject.SetActive(true);
            
    }

    public void hideMenu()
    {
      
       mapObject.SetActive(false);
       
    }
}
