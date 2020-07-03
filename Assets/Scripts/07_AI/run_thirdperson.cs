﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
[RequireComponent(typeof(ThirdPersonCharacter))]

public class run_thirdperson : MonoBehaviour {

	public Transform[] points;
    public float searcharea;
	private int destPoint = 0;
    private NavMeshAgent agent;
    public float searchtime;
    public float runarea;
    private float timer;
    private Transform target;
    private Vector3 targetDestination;
    private bool flag = true;
    public ThirdPersonCharacter character { get; private set; }

   

    void Start () {
		agent = GetComponent<NavMeshAgent>();
        character = GetComponent<ThirdPersonCharacter>();
        agent.autoBraking = false;
        GotoNextPoint();
	}


	void GotoNextPoint() {
		if (points.Length == 0)
			return;
        agent.destination = points[destPoint].position;
        destPoint = (destPoint + 1) % points.Length;
       
    }


	void FixedUpdate () {


        character.Move(agent.desiredVelocity, false, false);

        if (!flag)
        {
            timer += Time.deltaTime;
            agent.SetDestination(targetDestination);
           
        }

        if (timer > searchtime)
        {
            flag = true;
            timer = 0.0f;
           
            
        }

       RaycastHit hit;
       if (Physics.Raycast(transform.position, transform.forward, out hit, searcharea)) {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Debug.DrawLine(transform.position, forward*searcharea, Color.red, 5.0f);
            if (hit.collider.tag == "Player") {
                flag = false;
                target = hit.collider.gameObject.transform;
                targetDestination = target.TransformDirection(transform.right) + new Vector3(Random.Range(-runarea, runarea), 0, Random.Range(-runarea, runarea));
                agent.SetDestination (targetDestination);
                character.Move(agent.desiredVelocity, false, false);
            } 
            
		} 

		if (agent.remainingDistance < agent.stoppingDistance && flag) {
           GotoNextPoint ();
		}
	
			
	}
         	
}