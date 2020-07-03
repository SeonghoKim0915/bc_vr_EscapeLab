using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider_ani : MonoBehaviour {

    Animation anim;
    public AnimationClip clip;
    

	void Start () {
        anim = GetComponentInParent<Animation>();
        	}
	
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            anim.CrossFade(clip.name, 0.3f);
            Destroy(transform.parent.gameObject, 1.0f);
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            anim.CrossFade(clip.name, 0.3f);
            Destroy(transform.parent.gameObject, 1.0f);
        }
    }

}
