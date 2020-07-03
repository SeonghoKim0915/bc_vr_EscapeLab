using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class patrol_box_all : MonoBehaviour {

	public Transform[] points;
    public float searcharea;
    public float backward;
    public float left;
    public float right;
	private bool flag = true ;
	private int destPoint = 0;
	private NavMeshAgent agent;
    public float searchtime;
    private float timer;
    public Transform target;



    void Start () {
		agent = GetComponent<NavMeshAgent>();
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

        if (!flag)
        {
            timer += Time.deltaTime;
            agent.SetDestination(target.position);

        }

        if (timer > searchtime)
        {
            flag = true;
            timer = 0.0f;

        }

        Vector3 forward = transform.TransformDirection(Vector3.forward) ;
        RaycastHit hit;
       if (Physics.BoxCast(transform.position, transform.lossyScale /2, transform.forward, out hit, transform.rotation, searcharea)) {
            Debug.DrawLine(transform.position, forward*searcharea, Color.red, 5.0f);
            if (hit.collider.tag == "Player") {
				flag = false;
                agent.SetDestination (hit.collider.gameObject.transform.position);
                              
            } 
                       
		}
        if (Physics.BoxCast(transform.position, transform.lossyScale / 2, transform.forward*-1, out hit, transform.rotation, backward))
        {
            Debug.DrawLine(transform.position, forward * searcharea, Color.blue, 5.0f);
            if (hit.collider.tag == "Player")
            {
                flag = false;
                agent.SetDestination(hit.collider.gameObject.transform.position);
            }

        }

        if (Physics.BoxCast(transform.position, transform.lossyScale / 2, transform.right*-1, out hit, transform.rotation, left))
        {
            Debug.DrawLine(transform.position, forward * searcharea, Color.green, 5.0f);
            if (hit.collider.tag == "Player")
            {
                flag = false;
                agent.SetDestination(hit.collider.gameObject.transform.position);
            }

        }

        if (Physics.BoxCast(transform.position, transform.lossyScale / 2, transform.right, out hit, transform.rotation, right))
        {
            Debug.DrawLine(transform.position, forward * searcharea, Color.yellow, 5.0f);
            if (hit.collider.tag == "Player")
            {
                flag = false;
                agent.SetDestination(hit.collider.gameObject.transform.position);
            }

        }

        if (agent.remainingDistance < agent.stoppingDistance && flag) {		
			GotoNextPoint ();
		}
	
			
	}
         	
}