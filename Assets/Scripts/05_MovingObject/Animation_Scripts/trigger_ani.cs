using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_ani : MonoBehaviour {
    Animation anim;
    public AnimationClip clip;
    private AnimationClip previous_clip;

	void Start () {
        anim = GetComponentInParent<Animation>();
        previous_clip = anim.clip;
        	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            anim.Play(clip.name);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.Play(previous_clip.name);
        }
    }
}
