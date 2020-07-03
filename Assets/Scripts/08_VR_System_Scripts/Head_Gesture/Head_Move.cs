using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head_Move : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1;
    private HeadGesture gesture;
    private CharacterController controller;
       
    // Start is called before the first frame update
    void Start()
    {
        gesture = GetComponent<HeadGesture>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gesture.isFacingDown){
            Vector3 forward = Camera.main.transform.TransformDirection(Vector3.forward);
            controller.SimpleMove(forward * moveSpeed);
        }
    }
}
